using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Confeitaria.Models;

namespace Confeitaria
{

    public partial class FrmPedido : Form
    {
        private readonly string path = @"C:\Unifenas\4periodo\AtvIntegradoras\Confeitaria\Logs\logError.txt";
        public FrmPedido()
        {
            InitializeComponent();
        }

        private decimal valorTotal;
        private int qtdDisponivel = 0;
        private int qtdDisponivelInicial = 0;
        int idProduto = 0;
        void CarregaCombo()
        {
            Produto p = new();
            Cliente c = new();
            cmbProduto.DisplayMember = "nomeProd";
            cmbProduto.ValueMember = "idProduto";
            cmbProduto.DataSource = p.ListarDados().Tables[0];

            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.DataSource = c.ListAll().Tables[0];

        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            CarregaCombo();

            Lote l = new();
            LoteTmp lt = new();
            lt.Delete();

            var listLote = l.ListAll().Tables[0].AsEnumerable()
                .Select(dataRow => new Lote
                {
                    idItemLote = dataRow.Field<int>("idItemLote"),
                    qtdProd = dataRow.Field<int>("qtdProd"),
                    idProduto = dataRow.Field<int>("idProdutoFK")
                }).ToList();

            foreach(var item in listLote)
            {
                lt.qtdProdTmp = item.qtdProd;
                lt.idProdutoTmp = item.idProduto;
                lt.Add();
            }
            txtPreco.Text = string.Empty;
            try
            {
                cmbProduto.SelectedIndex = -1;
            }
            catch{ }
            try
            {
                cmbCliente.SelectedIndex = -1;
            }
            catch { }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente c = new();

            c.IdCliente = Convert.ToInt32(cmbCliente.SelectedValue);
            c.ListById(c.IdCliente);
            
            numericUpDown1.Maximum = qtdDisponivelInicial;
            valorTotal = 0;
            txtPrecoTotal.Text = "R$ " + valorTotal.ToString("F2");
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoteTmp lt = new();
            Produto p = new();

            idProduto = Convert.ToInt32(cmbProduto.SelectedValue);
            if (idProduto > 0)
            {
                p.GetById(idProduto);
                lt.GetByProductId(idProduto);
                qtdDisponivel = lt.qtdProdTmp;
                txtPreco.Text = p.precoProduto;
                numericUpDown1.Value = 0;
                numericUpDown1.Maximum = lt.qtdProdTmp;
            }

        }

        private void cmdFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if(lbCarrinho.Items.Count > 0)
                {
                    Cliente cliente = new();
                    Compra compra = new();
                    Pedido pedido = new();
                    Lote lote = new();
                    LoteTmp loteTmp = new();
                    Produto produto = new();

                    cliente.GetOnlyIdByName(cmbCliente.Text);
                    compra.idCliente = cliente.IdCliente;
                    compra.valorCompra = valorTotal.ToString();
                    compra.dataCompra = dateTimePicker1.Value;
                    compra.Add();
                    compra.GetByIdCliente(cliente.IdCliente);
                    pedido.idCompra = compra.idCompra;
                    pedido.qtdPedido++;
                    foreach(var item in lbCarrinho.Items)
                    {
                        produto.GetByName(item.ToString());
                        lote.GetByProductId(produto.idProduto);
                        pedido.idItemLote = lote.idItemLote;
                        loteTmp.GetByProductId(produto.idProduto);
                        if (lote.idProduto == loteTmp.idProdutoTmp)
                        {
                            lote.qtdProd = loteTmp.qtdProdTmp;
                        }
                    }
                    
                    pedido.Add();
                    lote.Edit(produto.idProduto);

                    MessageBox.Show("Pedido Realizado!");
                    loteTmp.Delete();
                    txtPreco.Clear();
                    txtPrecoTotal.Clear();
                    lbCarrinho.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Defina o Pedido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Erro ao realizar o pedido - " + DateTime.Now.ToString() + " - " + ex.Message.ToString());
                }
                MessageBox.Show("Erro ao realizar o pedido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region controles carrinho
        private void cmdAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            if (cmbProduto.SelectedIndex != -1 && cmbCliente.SelectedIndex != -1)
            {
                LoteTmp lt = new();
                Produto p = new();
                p.GetById(idProduto);

                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    if (qtdDisponivel > 0)
                    {
                        valorTotal += Convert.ToDecimal(txtPreco.Text);
                        lbCarrinho.Items.Add(p.nomeProduto);
                        qtdDisponivel--;
                    }
                }
                lt.qtdProdTmp = qtdDisponivel;
                lt.idProdutoTmp = idProduto;
                lt.Edit();
                numericUpDown1.Value = 0;
                txtPrecoTotal.Text = "R$ " + valorTotal.ToString("F2");
                numericUpDown1.Maximum = qtdDisponivel;
                cmbCliente.Enabled = false;
            }
            else
            {
                MessageBox.Show("Defina o cliente e o produto!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Lote lote = new();
            LoteTmp loteTmp = new();

            lbCarrinho.Items.Clear();
            valorTotal = 0;
            txtPrecoTotal.Text = "R$ " + valorTotal.ToString("F2");


            var listLote = lote.ListAll().Tables[0].AsEnumerable()
                .Select(dataRow => new Lote
                {
                    idItemLote = dataRow.Field<int>("idItemLote"),
                    qtdProd = dataRow.Field<int>("qtdProd"),
                    idProduto = dataRow.Field<int>("idProdutoFK")
                }).ToList();

            foreach (var item in listLote)
            {
                loteTmp.qtdProdTmp = item.qtdProd;
                loteTmp.idProdutoTmp = item.idProduto;
                loteTmp.Edit();
            }
        } 
        #endregion

        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            LoteTmp lt = new();
            lt.Delete();
            Close();

        }

        
    }
}


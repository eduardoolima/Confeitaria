using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Confeitaria.Models;

namespace Confeitaria
{

    public partial class FrmPedido : Form
    {
        private readonly string path = @"C:\Users\Fabio\source\repos\Confeitaria\Logs\logError.txt";
        public FrmPedido()
        {
            InitializeComponent();

        }
        private Produto prod = new Produto();
        private Cliente client = new Cliente();
        private Pedido ped = new Pedido();
        private Lote lot = new Lote();
        private LoteTmp lottmp = new LoteTmp();
        private Compra comp = new Compra();
        private decimal valorTotal;
        private int qtdDisponivel = 0;
        private int qtdDisponivelInicial = 0;
        private List<Produto> listProduto = new List<Produto>();

        void CarregaCombo()
        {
            cmbProduto.DisplayMember = "nomeProd";
            cmbProduto.ValueMember = "idProduto";
            cmbProduto.DataSource = prod.ListarDados().Tables[0];

            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.DataSource = client.ListAll().Tables[0];

        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            CarregaCombo();

            qtdDisponivel = lot.qtdProd;
            qtdDisponivelInicial = qtdDisponivel;
            numericUpDown1.Maximum = qtdDisponivel;
            lottmp.Delete();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            client.IdCliente = Convert.ToInt32(cmbCliente.SelectedValue);
            client.ListById(client.IdCliente);
            
            lbCarrinho.Items.Clear();
            numericUpDown1.Maximum = qtdDisponivelInicial;
            valorTotal = 0;
            txtPrecoTotal.Text = "R$ " + valorTotal.ToString("F2");
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            prod.idProduto = Convert.ToInt32(cmbProduto.SelectedValue);
            prod.ListById(prod.idProduto);
            txtPreco.Text = prod.precoProduto;
            lot.idProduto = prod.GetId(prod.nomeProduto);
            lot.ListarDadosLote();
            numericUpDown1.Value = 0;
            numericUpDown1.Maximum = lot.qtdProd;
        }

        private void cmdFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                client.GetOnlyIdByName(cmbCliente.Text);
                comp.idCliente = client.IdCliente;
                comp.valorCompra = txtPrecoTotal.Text;
                comp.dataCompra = dateTimePicker1.Value;
                comp.Add();
                comp.GetCompraByIdCliente(client.IdCliente);
                ped.idCompra = comp.idCompra;
                ped.qtdPedido++;
                lot.GetLoteByProductId(prod.idProduto);
                ped.idItemLote = lot.idItemLote;
                lottmp.GetByProductId(prod.idProduto);
                if (lot.idProduto == lottmp.idProdutoTmp)
                {
                    lot.qtdProd = lottmp.qtdProdTmp;
                }
                ped.Add();
                lot.Edit();

                MessageBox.Show("Pedido Realizado!");
                lottmp.Delete();
                txtPreco.Clear();
                txtPrecoTotal.Clear();
                lbCarrinho.Items.Clear();
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Erro ao realizar o pedido - " + DateTime.Now.ToString() + " - " + ex.Message.ToString());
                }

            }
        }

        private void cmdAdicionarCarrinho_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                if (qtdDisponivel > 0)
                {
                    valorTotal += Convert.ToDecimal(txtPreco.Text);
                    lbCarrinho.Items.Add(prod.nomeProduto);
                    qtdDisponivel--;
                }
            }
            lottmp.qtdProdTmp = qtdDisponivel;
            lottmp.idProdutoTmp = prod.idProduto;
            lottmp.Add();
            listProduto.Add(prod);
            numericUpDown1.Value = 0;
            txtPrecoTotal.Text = "R$ " + valorTotal.ToString("F2");
            numericUpDown1.Maximum = qtdDisponivel;
        }

        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}


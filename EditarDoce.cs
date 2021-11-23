using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Confeitaria.Models;
using System.IO;
using System.Data.SqlClient;

namespace Confeitaria
{
    public partial class EditarDoce : Form
    {
        public EditarDoce()
        {
            InitializeComponent();
        }

        private readonly string path = @"C:\Users\Fabio\source\repos\Confeitaria\Logs\logError.txt";
        private Produto p = new();
        private Lote l = new();
        DBConect database = new();
        void CarregaCombo()
        {
            cmbProdutos.DisplayMember = "nomeProd";
            cmbProdutos.ValueMember = "idProduto";
            cmbProdutos.DataSource = p.ListarDados().Tables[0];
        }
        private void EditarDoce_Load(object sender, EventArgs e)
        {
            CarregaCombo();
        }
        private void cmbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.idProduto = Convert.ToInt32(cmbProdutos.SelectedValue);
            p.GetById(p.idProduto);
            txtNome.Text = p.nomeProduto;
            txtPreco.Text = p.precoProduto;
            txtDesc.Text = p.descricao;
            l.idProduto = p.GetId(p.nomeProduto);
            l.ListarDadosLote();
            txtQtd.Text = l.qtdProd.ToString();
            dtpDataFab.Value = l.dataFabricacao;
            dtpDataVenc.Value = l.dataValidade;
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            try
            {
                p.nomeProduto = txtNome.Text;
                p.precoProduto = txtPreco.Text;
                p.descricao = txtDesc.Text;
                p.Edit();
                l.dataFabricacao = dtpDataFab.Value;
                l.dataValidade = dtpDataVenc.Value;
                l.qtdProd = Convert.ToInt32(txtQtd.Text);                
                l.Edit();

                MessageBox.Show("Registro Editado com sucesso!");
                txtNome.Clear();
                txtPreco.Clear();
                txtDesc.Clear();
                txtQtd.Clear();
                dtpDataFab.Value = DateTime.Now;
                dtpDataVenc.Value = DateTime.Now;

                CarregaCombo();
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Erro ao editar produto - " + DateTime.Now.ToString() + " - " + ex.Message.ToString());
                    MessageBox.Show("Aí eu vou ter q trucar pra cima docê uai");
                }

            }
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                p.idProduto = Convert.ToInt32(cmbProdutos.SelectedValue);
                l.idProduto = Convert.ToInt32(cmbProdutos.SelectedValue);
                l.Delete();
                p.Delete();

                MessageBox.Show("Registro Excluir com sucesso!");
                txtNome.Clear();
                txtPreco.Clear();
                txtDesc.Clear();
                txtQtd.Clear();
                dtpDataFab.Value = DateTime.Now;
                dtpDataVenc.Value = DateTime.Now;

                CarregaCombo();
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Erro ao Excluir produto - " + DateTime.Now.ToString() + " - " + ex.Message.ToString());
                    MessageBox.Show("o monte d bosta? vc ta bem?");
                }

            }
        }
    }
}

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
    public partial class CadastroDoces : Form
    {
        public CadastroDoces()
        {
            InitializeComponent();
        }
        private readonly string path = @"C:\Users\ricks\source\repos\Confeitaria\Logs\logError.txt";

        Produto p = new();
        Lote l = new();

        private void cmdIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                p.nomeProduto = txtNome.Text;
                p.precoProduto = txtPreco.Text;
                p.descricao = txtDesc.Text;
                l.dataFabricacao = dtpDataFab.Value;
                l.dataValidade = dtpDataVenc.Value;
                l.qtdProd = Convert.ToInt32(txtQtd.Text);

                p.Add();

                l.idProduto = p.GetId(p.nomeProduto);

                l.Add();

                MessageBox.Show("Registro incluido com sucesso!");
                txtNome.Clear();
                txtPreco.Clear();
                txtDesc.Clear();
                txtQtd.Clear();
                dtpDataFab.Value = DateTime.Now;
                dtpDataVenc.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Erro ao incluir produto - " + DateTime.Now.ToString() + " - " + ex.Message.ToString());
                }

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

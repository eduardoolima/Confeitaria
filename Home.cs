using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Confeitaria
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new();
            cadastroCliente.ShowDialog();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new();
            cadastroCliente.ShowDialog();
        }

        private void editarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarPedido editarPedido = new();
            editarPedido.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroDoces cadastrar = new();
            cadastrar.ShowDialog();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarDoce editarDoce = new();
            editarDoce.ShowDialog();
        }

        private void venderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmPedido pedido = new();
            pedido.ShowDialog();
        }

        private void verTodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPesqNomeDoce pesquisa = new();
            pesquisa.ShowDialog();
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new();
            relatorio.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCliente editarCliente = new();
            editarCliente.ShowDialog();
        }

        private void editarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarPedido editarPedido = new();
            editarPedido.ShowDialog();
        }

        private void pesquisarPorDataFabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarDoce pesquisarDoce = new();
            pesquisarDoce.ShowDialog();
        }

        //private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    FrmPedido frmPedido = new();
        //    frmPedido.ShowDialog();
        //}

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new();
            relatorio.Show();
        }
    }
}

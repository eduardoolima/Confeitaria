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
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.ShowDialog();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.ShowDialog();
        }

        private void editarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarPedido editarPedido = new EditarPedido();
            editarPedido.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroDoces cadastrar = new CadastroDoces();
            cadastrar.ShowDialog();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarDoce editarDoce = new EditarDoce();
            editarDoce.ShowDialog();
        }

        private void venderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmPedido pedido = new FrmPedido();
            pedido.ShowDialog();
        }

        private void verTodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPesqNomeDoce pesquisa = new FrmPesqNomeDoce();
            pesquisa.ShowDialog();
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.ShowDialog();
        }
    }
}

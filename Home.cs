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

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroDoces cd = new();
            cd.ShowDialog();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditarDoce ed = new();
            ed.ShowDialog();
        }

        private void PesquisarStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarDoce pd = new PesquisarDoce();
            pd.ShowDialog();
        }
    }
}

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

namespace Confeitaria
{
    public partial class FrmPesqNomeDoce : Form
    {
        public FrmPesqNomeDoce()
        {
            InitializeComponent();
        }
        Produto prod = new Produto();
        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            prod.nomeProduto = txtNome.Text;
            dataGridView1.DataSource = prod.ListByProductName().Tables[0];
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

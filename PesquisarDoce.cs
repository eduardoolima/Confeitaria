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

namespace Confeitaria
{
    public partial class PesquisarDoce : Form
    {
        public PesquisarDoce()
        {
            InitializeComponent();
        }
        Lote l = new Lote();

        private void cmdPesquisar_Click_1(object sender, EventArgs e)
        {
            l.dataFabricacao = dtpDataFab.Value;
            dataGridView1.DataSource = l.ListarporData().Tables[0];
        }
    }
}

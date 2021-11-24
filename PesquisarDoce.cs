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
        private readonly string path = @"C:\Unifenas\4periodo\AtvIntegradoras\Confeitaria\Logs\logError.txt";

        private void cmdPesquisar_Click_1(object sender, EventArgs e)
        {
            try
            {
                l.dataFabricacao = dtpDataFab.Value;
                dataGridView1.DataSource = l.ListarporData().Tables[0];
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Erro ao Pesquisar produto - " + DateTime.Now.ToString() + " - " + ex.Message.ToString());
                }
                MessageBox.Show("Houve um erro ao pesquisar as informações do doce!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

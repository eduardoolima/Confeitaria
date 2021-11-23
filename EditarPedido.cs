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
    public partial class EditarPedido : Form
    {
        public EditarPedido()
        {
            InitializeComponent();
        }
        
        private void EditarPedido_Load(object sender, EventArgs e)
        {
            Pedido ped = new();
            dataGridView1.DataSource = ped.ListAll().Tables[0];
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var resposta = DialogResult;
            Pedido ped = new();
            Compra comp = new();
            ped.idPedido=(Convert.ToInt32(dataGridView1[0, e.RowIndex].Value));
            ped.GetByidPedido(ped.idPedido);
            comp.idCompra = ped.idCompra;
            resposta = MessageBox.Show("Deseja excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resposta == DialogResult.Yes)
            {
                ped.Delete(ped.idPedido);
                comp.Delete(comp.idCompra);
                dataGridView1.DataSource = ped.ListAll().Tables[0];
            }
        }
    }
}


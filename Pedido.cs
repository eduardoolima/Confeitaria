using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Confeitaria.Models
{
    public partial class Pedido : Form
    {
        public Pedido()
        {

        }
        private DBConect dataBase = new DBConect();
        private Produto p = new Produto();
        private void Pedido_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}

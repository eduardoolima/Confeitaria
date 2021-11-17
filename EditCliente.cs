using Confeitaria.Models;
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
    public partial class EditCliente : Form
    {
        public EditCliente()
        {
            InitializeComponent();
        }

        private void EditCliente_Load(object sender, EventArgs e)
        {
            Cliente c = new();
            dataGridView1.DataSource = c.ListAll().Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente c = new();
            c.GetByName(dataGridView1[0, e.RowIndex].Value.ToString());

            #region dadosPessoais

            txtNome.Text = c.Nome.ToString();
            txtEmail.Text = c.Email.ToString();
            dtpDataNascimento.Value = c.DataNasc; //DateTime.Parse(c.DataNasc.ToString());
            foreach (var item in c.Telefones)
            {
                lbTelefones.Items.Add(item.ToString());
            }
            txtCidade.Text = c.Cidade.ToString();
            txtRua.Text = c.Rua.ToString();
            txtNumero.Text = c.Numero.ToString();
            txtCep.Text = c.Cep.ToString();

            #endregion

            pnlView.Visible = false;

        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            pnlView.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

    }
}

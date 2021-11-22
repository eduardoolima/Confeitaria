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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Cliente c = new();
            Telefone t = new();

            #region dadosPessoais
            c.Nome = txtNome.Text.ToString();
            c.Email = txtEmail.Text.ToString();
            c.DataNasc = DateTime.Parse(dtpDataNascimento.Text);
            c.Cidade = txtCidade.Text.ToString();
            c.Rua = txtRua.Text.ToString();
            c.Numero = txtNumero.Text.ToString();
            c.Cep = txtCep.Text.ToString();

            c.Add();
            #endregion

            c.GetOnlyIdByName(c.Nome);

            #region telefones
            foreach (var item in lbTelefones.Items)
            {
                t.Tel = item.ToString();
                t.IdCliente = c.IdCliente;
                t.Add();
            } 
            #endregion
        }

        private void btnAddTelefone_Click(object sender, EventArgs e)
        {
            lbTelefones.Items.Add(txtTelefone.Text.ToString());
        }

        private void btnRemoveTel_Click(object sender, EventArgs e)
        {
            lbTelefones.Items.Remove(lbTelefones.SelectedItems);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Home home = new();
            home.ShowDialog();
        }
    }
}

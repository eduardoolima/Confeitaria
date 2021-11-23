using Confeitaria.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Confeitaria
{
    public partial class EditCliente : Form
    {
        private readonly string path = @"C:\Unifenas\4periodo\AtvIntegradoras\Confeitaria\Logs\logError.txt";
        public EditCliente()
        {
            InitializeComponent();
        }

        int clientId = 0;

        #region carregarInfo
        private void EditCliente_Load(object sender, EventArgs e)
        {
            Cliente c = new();
            try
            {
                dataGridView1.DataSource = c.ListAll().Tables[0];
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Erro ao carregar as informações dos clientes - " + DateTime.Now.ToString() + " - " + ex.Message.ToString());
                }
                MessageBox.Show("Houve um erro ao carregar as informações dos clientes!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cliente c = new();
                Telefone t = new();
                c.GetByName(dataGridView1[0, e.RowIndex].Value.ToString());
                clientId = c.IdCliente;
                #region dadosPessoais

                txtNome.Text = c.Nome;
                txtEmail.Text = c.Email;
                dtpDataNascimento.Value = c.DataNasc; //DateTime.Parse(c.DataNasc.ToString());

                var telefones = t.ListByClientName(c.Nome).Tables[0].AsEnumerable()
                .Select(dataRow => new Telefone
                {
                    Tel = dataRow.Field<string>("telefone")
                }).ToList();

                foreach (var item in telefones)
                {
                    lbTelefones.Items.Add(item.Tel.ToString());
                }
                txtCidade.Text = c.Cidade;
                txtRua.Text = c.Rua;
                txtNumero.Text = c.Numero;
                txtCep.Text = c.Cep;

            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Erro ao carregar as informações do cliente - " + DateTime.Now.ToString() + " - " + ex.Message.ToString());
                }
                MessageBox.Show("Houve um erro ao carregar as informações do cliente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

            pnlView.Visible = false;

        } 
        #endregion

        #region editar
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Cliente c = new();
            Telefone t = new();

            try
            {
                c.GetById(clientId);

                #region dados pessoais
                c.Nome = txtNome.Text;
                c.Email = txtEmail.Text;
                c.DataNasc = dtpDataNascimento.Value; //DateTime.Parse(c.DataNasc.ToString());

                c.Cidade = txtCidade.Text;
                c.Rua = txtRua.Text;
                c.Numero = txtNumero.Text;
                c.Cep = txtCep.Text;

                c.Edit(c.IdCliente);
                #endregion

                #region telefones
                foreach (var item in lbTelefones.Items)
                {
                    t.Tel = item.ToString();
                    t.IdCliente = c.IdCliente;
                    t.Edit(t.IdCliente);
                }
                #endregion
                MessageBox.Show("Cliente editado com Sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Erro ao editar cliente - " + DateTime.Now.ToString() + " - " + ex.Message.ToString());
                }
                MessageBox.Show("Houve um erro ao gravar as novas informações do cliente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAddTelefone_Click(object sender, EventArgs e)
        {
            lbTelefones.Items.Add(txtTelefone.Text.ToString());
        }

        private void btnRemoveTel_Click(object sender, EventArgs e)
        {
            if (lbTelefones.SelectedIndex > -1)
            {
                lbTelefones.Items.RemoveAt(lbTelefones.SelectedIndex);
            }
        }
        #endregion

        #region deletar
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientId > 0)
                {
                    Cliente c = new();
                    Telefone t = new();

                    t.DeleteAll(clientId);
                    c.Delete(clientId);

                    dataGridView1.DataSource = c.ListAll().Tables[0];
                    MessageBox.Show("Cliente Excluido com sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlView.Visible = true;
                }
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Erro ao excluir cliente - " + DateTime.Now.ToString() + " - " + ex.Message.ToString());
                }
                MessageBox.Show("Houve um erro ao excluir o cliente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            pnlView.Visible = true;
        }        

        private void btnVoltarHome_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

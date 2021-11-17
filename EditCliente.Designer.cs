
namespace Confeitaria
{
    partial class EditCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCliente));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnAddTelefone = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lbTelefones = new System.Windows.Forms.ListBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblDadosPessoais = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.btnRemoveTel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.pnlView = new System.Windows.Forms.Panel();
            this.btnVoltarHome = new System.Windows.Forms.Button();
            this.lblClentes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVoltar.Location = new System.Drawing.Point(184, 491);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 41);
            this.btnVoltar.TabIndex = 48;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGravar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnGravar.Location = new System.Drawing.Point(38, 491);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(118, 41);
            this.btnGravar.TabIndex = 47;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnAddTelefone
            // 
            this.btnAddTelefone.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTelefone.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAddTelefone.Location = new System.Drawing.Point(157, 249);
            this.btnAddTelefone.Name = "btnAddTelefone";
            this.btnAddTelefone.Size = new System.Drawing.Size(104, 29);
            this.btnAddTelefone.TabIndex = 46;
            this.btnAddTelefone.Text = "Adicionar";
            this.btnAddTelefone.UseVisualStyleBackColor = false;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefone.Location = new System.Drawing.Point(157, 219);
            this.txtTelefone.Mask = "(##) #####-####";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(196, 23);
            this.txtTelefone.TabIndex = 45;
            // 
            // lbTelefones
            // 
            this.lbTelefones.FormattingEnabled = true;
            this.lbTelefones.ItemHeight = 15;
            this.lbTelefones.Location = new System.Drawing.Point(369, 167);
            this.lbTelefones.Name = "lbTelefones";
            this.lbTelefones.Size = new System.Drawing.Size(232, 79);
            this.lbTelefones.TabIndex = 44;
            // 
            // lblTelefone
            // 
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTelefone.Location = new System.Drawing.Point(36, 210);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(225, 37);
            this.lblTelefone.TabIndex = 42;
            this.lblTelefone.Text = "Telefones";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(244, 167);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(109, 23);
            this.dtpDataNascimento.TabIndex = 41;
            // 
            // txtRua
            // 
            this.txtRua.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtRua.Location = new System.Drawing.Point(119, 387);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(322, 23);
            this.txtRua.TabIndex = 38;
            // 
            // txtCidade
            // 
            this.txtCidade.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtCidade.Location = new System.Drawing.Point(119, 345);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(322, 23);
            this.txtCidade.TabIndex = 37;
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNome.Location = new System.Drawing.Point(157, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(444, 23);
            this.txtNome.TabIndex = 36;
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtEmail.Location = new System.Drawing.Point(157, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(444, 23);
            this.txtEmail.TabIndex = 35;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblNumero.Location = new System.Drawing.Point(450, 418);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(37, 30);
            this.lblNumero.TabIndex = 34;
            this.lblNumero.Text = "N°";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCep.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCep.Location = new System.Drawing.Point(38, 418);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(49, 30);
            this.lblCep.TabIndex = 33;
            this.lblCep.Text = "Cep";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRua.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblRua.Location = new System.Drawing.Point(36, 378);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(49, 30);
            this.lblRua.TabIndex = 31;
            this.lblRua.Text = "Rua";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCidade.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCidade.Location = new System.Drawing.Point(36, 336);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(77, 30);
            this.lblCidade.TabIndex = 30;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblEndereco.Location = new System.Drawing.Point(12, 280);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(144, 40);
            this.lblEndereco.TabIndex = 29;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblDadosPessoais
            // 
            this.lblDadosPessoais.AutoSize = true;
            this.lblDadosPessoais.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDadosPessoais.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDadosPessoais.Location = new System.Drawing.Point(12, 9);
            this.lblDadosPessoais.Name = "lblDadosPessoais";
            this.lblDadosPessoais.Size = new System.Drawing.Size(225, 40);
            this.lblDadosPessoais.TabIndex = 28;
            this.lblDadosPessoais.Text = "Dados Pessoais";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataNascimento.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDataNascimento.Location = new System.Drawing.Point(36, 161);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(225, 37);
            this.lblDataNascimento.TabIndex = 27;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblEmail.Location = new System.Drawing.Point(36, 110);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 30);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeCliente.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblNomeCliente.Location = new System.Drawing.Point(36, 66);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(70, 30);
            this.lblNomeCliente.TabIndex = 25;
            this.lblNomeCliente.Text = "Nome";
            // 
            // btnRemoveTel
            // 
            this.btnRemoveTel.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRemoveTel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveTel.BackgroundImage")));
            this.btnRemoveTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveTel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRemoveTel.Location = new System.Drawing.Point(607, 216);
            this.btnRemoveTel.Name = "btnRemoveTel";
            this.btnRemoveTel.Size = new System.Drawing.Size(36, 30);
            this.btnRemoveTel.TabIndex = 49;
            this.btnRemoveTel.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(662, 491);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 44);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "EXCLUIR";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(493, 425);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 51;
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCep.Location = new System.Drawing.Point(119, 427);
            this.txtCep.Mask = "#####-###";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(322, 23);
            this.txtCep.TabIndex = 54;
            // 
            // pnlView
            // 
            this.pnlView.Controls.Add(this.btnVoltarHome);
            this.pnlView.Controls.Add(this.lblClentes);
            this.pnlView.Controls.Add(this.dataGridView1);
            this.pnlView.Location = new System.Drawing.Point(12, 9);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(786, 537);
            this.pnlView.TabIndex = 55;
            // 
            // btnVoltarHome
            // 
            this.btnVoltarHome.BackColor = System.Drawing.Color.GhostWhite;
            this.btnVoltarHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltarHome.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVoltarHome.Location = new System.Drawing.Point(15, 485);
            this.btnVoltarHome.Name = "btnVoltarHome";
            this.btnVoltarHome.Size = new System.Drawing.Size(118, 41);
            this.btnVoltarHome.TabIndex = 49;
            this.btnVoltarHome.Text = "Voltar";
            this.btnVoltarHome.UseVisualStyleBackColor = false;
            // 
            // lblClentes
            // 
            this.lblClentes.AutoSize = true;
            this.lblClentes.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClentes.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblClentes.Location = new System.Drawing.Point(15, 18);
            this.lblClentes.Name = "lblClentes";
            this.lblClentes.Size = new System.Drawing.Size(125, 40);
            this.lblClentes.TabIndex = 29;
            this.lblClentes.Text = "Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 61);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(748, 389);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // EditCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRemoveTel);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnAddTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lbTelefones);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblDadosPessoais);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNomeCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCliente";
            this.Text = "Editar Cliente";
            this.Load += new System.EventHandler(this.EditCliente_Load);
            this.pnlView.ResumeLayout(false);
            this.pnlView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnAddTelefone;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.ListBox lbTelefones;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblDadosPessoais;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Button btnRemoveTel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Button btnVoltarHome;
        private System.Windows.Forms.Label lblClentes;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
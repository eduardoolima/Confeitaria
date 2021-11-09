
namespace Confeitaria
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblDadosPessoais = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            this.lbTelefones = new System.Windows.Forms.ListBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnAddTelefone = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeCliente.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblNomeCliente.Location = new System.Drawing.Point(36, 66);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(70, 30);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Nome";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblEmail.Location = new System.Drawing.Point(36, 110);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 30);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataNascimento.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDataNascimento.Location = new System.Drawing.Point(36, 161);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(225, 37);
            this.lblDataNascimento.TabIndex = 2;
            this.lblDataNascimento.Text = "Data de Nascimento";
            this.lblDataNascimento.Click += new System.EventHandler(this.lblDataNascimento_Click);
            // 
            // lblDadosPessoais
            // 
            this.lblDadosPessoais.AutoSize = true;
            this.lblDadosPessoais.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDadosPessoais.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDadosPessoais.Location = new System.Drawing.Point(12, 9);
            this.lblDadosPessoais.Name = "lblDadosPessoais";
            this.lblDadosPessoais.Size = new System.Drawing.Size(225, 40);
            this.lblDadosPessoais.TabIndex = 3;
            this.lblDadosPessoais.Text = "Dados Pessoais";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblEndereco.Location = new System.Drawing.Point(12, 280);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(144, 40);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCidade.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCidade.Location = new System.Drawing.Point(36, 336);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(77, 30);
            this.lblCidade.TabIndex = 5;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBairro.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblBairro.Location = new System.Drawing.Point(36, 378);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(67, 30);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRua.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblRua.Location = new System.Drawing.Point(36, 419);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(49, 30);
            this.lblRua.TabIndex = 7;
            this.lblRua.Text = "Rua";
            this.lblRua.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCep.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCep.Location = new System.Drawing.Point(36, 458);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(49, 30);
            this.lblCep.TabIndex = 8;
            this.lblCep.Text = "Cep";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumero.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblNumero.Location = new System.Drawing.Point(450, 418);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(37, 30);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "N°";
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtEmail.Location = new System.Drawing.Point(157, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(444, 23);
            this.txtEmail.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNome.Location = new System.Drawing.Point(157, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(444, 23);
            this.txtNome.TabIndex = 11;
            // 
            // txtCidade
            // 
            this.txtCidade.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtCidade.Location = new System.Drawing.Point(119, 345);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(322, 23);
            this.txtCidade.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtBairro.Location = new System.Drawing.Point(119, 387);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(322, 23);
            this.txtBairro.TabIndex = 13;
            // 
            // txtRua
            // 
            this.txtRua.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtRua.Location = new System.Drawing.Point(119, 426);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(322, 23);
            this.txtRua.TabIndex = 14;
            // 
            // txtCep
            // 
            this.txtCep.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtCep.Location = new System.Drawing.Point(119, 467);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(322, 23);
            this.txtCep.TabIndex = 15;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(244, 167);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(109, 23);
            this.dtpDataNascimento.TabIndex = 17;
            // 
            // lblTelefone
            // 
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTelefone.Location = new System.Drawing.Point(36, 210);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(225, 37);
            this.lblTelefone.TabIndex = 18;
            this.lblTelefone.Text = "Telefones";
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(493, 426);
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(108, 23);
            this.nudNumero.TabIndex = 19;
            // 
            // lbTelefones
            // 
            this.lbTelefones.FormattingEnabled = true;
            this.lbTelefones.ItemHeight = 15;
            this.lbTelefones.Location = new System.Drawing.Point(369, 167);
            this.lbTelefones.Name = "lbTelefones";
            this.lbTelefones.Size = new System.Drawing.Size(232, 79);
            this.lbTelefones.TabIndex = 20;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefone.Location = new System.Drawing.Point(157, 219);
            this.txtTelefone.Mask = "00 000000000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(196, 23);
            this.txtTelefone.TabIndex = 21;
            // 
            // btnAddTelefone
            // 
            this.btnAddTelefone.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTelefone.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAddTelefone.Location = new System.Drawing.Point(157, 249);
            this.btnAddTelefone.Name = "btnAddTelefone";
            this.btnAddTelefone.Size = new System.Drawing.Size(104, 29);
            this.btnAddTelefone.TabIndex = 22;
            this.btnAddTelefone.Text = "Adicionar";
            this.btnAddTelefone.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGravar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnGravar.Location = new System.Drawing.Point(38, 505);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(118, 41);
            this.btnGravar.TabIndex = 23;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVoltar.Location = new System.Drawing.Point(182, 505);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 41);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnAddTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lbTelefones);
            this.Controls.Add(this.nudNumero);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblDadosPessoais);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNomeCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "CadastroCliente";
            this.Text = "Cadastro de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblDadosPessoais;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.NumericUpDown nudNumero;
        private System.Windows.Forms.ListBox lbTelefones;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Button btnAddTelefone;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnVoltar;
    }
}

namespace Confeitaria
{
    partial class EditarDoce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarDoce));
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataVenc = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFab = new System.Windows.Forms.DateTimePicker();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbldataVenc = new System.Windows.Forms.Label();
            this.lblDataFab = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cmdEditar = new System.Windows.Forms.Button();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Location = new System.Drawing.Point(167, 84);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(448, 23);
            this.cmbProdutos.TabIndex = 0;
            this.cmbProdutos.SelectedIndexChanged += new System.EventHandler(this.cmbProdutos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(37, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto:";
            // 
            // dtpDataVenc
            // 
            this.dtpDataVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenc.Location = new System.Drawing.Point(535, 266);
            this.dtpDataVenc.Name = "dtpDataVenc";
            this.dtpDataVenc.Size = new System.Drawing.Size(80, 23);
            this.dtpDataVenc.TabIndex = 23;
            // 
            // dtpDataFab
            // 
            this.dtpDataFab.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFab.Location = new System.Drawing.Point(535, 203);
            this.dtpDataFab.Name = "dtpDataFab";
            this.dtpDataFab.Size = new System.Drawing.Size(80, 23);
            this.dtpDataFab.TabIndex = 22;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(167, 322);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(448, 23);
            this.txtDesc.TabIndex = 21;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(167, 266);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 23);
            this.txtQtd.TabIndex = 20;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(167, 203);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 23);
            this.txtPreco.TabIndex = 19;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(167, 143);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(448, 23);
            this.txtNome.TabIndex = 18;
            // 
            // lbldataVenc
            // 
            this.lbldataVenc.AutoSize = true;
            this.lbldataVenc.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldataVenc.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbldataVenc.Location = new System.Drawing.Point(312, 262);
            this.lbldataVenc.Name = "lbldataVenc";
            this.lbldataVenc.Size = new System.Drawing.Size(207, 30);
            this.lbldataVenc.TabIndex = 17;
            this.lbldataVenc.Text = "Data de Vencimento:";
            // 
            // lblDataFab
            // 
            this.lblDataFab.AutoSize = true;
            this.lblDataFab.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataFab.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDataFab.Location = new System.Drawing.Point(312, 197);
            this.lblDataFab.Name = "lblDataFab";
            this.lblDataFab.Size = new System.Drawing.Size(195, 30);
            this.lblDataFab.TabIndex = 16;
            this.lblDataFab.Text = "Data de Fabricação:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDescricao.Location = new System.Drawing.Point(37, 315);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(108, 30);
            this.lblDescricao.TabIndex = 15;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQtd.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblQtd.Location = new System.Drawing.Point(37, 262);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(127, 30);
            this.lblQtd.TabIndex = 14;
            this.lblQtd.Text = "Quantidade:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPreco.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPreco.Location = new System.Drawing.Point(37, 203);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(70, 30);
            this.lblPreco.TabIndex = 13;
            this.lblPreco.Text = "Preço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblNome.Location = new System.Drawing.Point(37, 143);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(75, 30);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(37, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 40);
            this.label2.TabIndex = 24;
            this.label2.Text = "Editar";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVoltar.Location = new System.Drawing.Point(497, 373);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 41);
            this.btnVoltar.TabIndex = 39;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cmdEditar
            // 
            this.cmdEditar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cmdEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdEditar.ForeColor = System.Drawing.Color.GhostWhite;
            this.cmdEditar.Location = new System.Drawing.Point(37, 373);
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(118, 41);
            this.cmdEditar.TabIndex = 38;
            this.cmdEditar.Text = "Editar";
            this.cmdEditar.UseVisualStyleBackColor = false;
            this.cmdEditar.Click += new System.EventHandler(this.cmdEditar_Click);
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackColor = System.Drawing.Color.DarkRed;
            this.cmdExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdExcluir.ForeColor = System.Drawing.Color.GhostWhite;
            this.cmdExcluir.Location = new System.Drawing.Point(194, 373);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(118, 41);
            this.cmdExcluir.TabIndex = 40;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = false;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // EditarDoce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(666, 437);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cmdEditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataVenc);
            this.Controls.Add(this.dtpDataFab);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbldataVenc);
            this.Controls.Add(this.lblDataFab);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProdutos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditarDoce";
            this.Text = "EditarDoce";
            this.Load += new System.EventHandler(this.EditarDoce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataVenc;
        private System.Windows.Forms.DateTimePicker dtpDataFab;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbldataVenc;
        private System.Windows.Forms.Label lblDataFab;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button cmdEditar;
        private System.Windows.Forms.Button cmdExcluir;
    }
}
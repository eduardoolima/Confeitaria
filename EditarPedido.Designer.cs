
namespace Confeitaria
{
    partial class EditarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarPedido));
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.cmbPedido = new System.Windows.Forms.ComboBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(75, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 40);
            this.label2.TabIndex = 39;
            this.label2.Text = "Editar";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(205, 229);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidade.TabIndex = 35;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(151, 346);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 23);
            this.txtPreco.TabIndex = 34;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQtd.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblQtd.Location = new System.Drawing.Point(75, 222);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(127, 30);
            this.lblQtd.TabIndex = 29;
            this.lblQtd.Text = "Quantidade:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPreco.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPreco.Location = new System.Drawing.Point(75, 339);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(70, 30);
            this.lblPreco.TabIndex = 28;
            this.lblPreco.Text = "Preço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblNome.Location = new System.Drawing.Point(75, 158);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(92, 30);
            this.lblNome.TabIndex = 27;
            this.lblNome.Text = "Produto:";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPedido.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPedido.Location = new System.Drawing.Point(75, 106);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(81, 30);
            this.lblPedido.TabIndex = 26;
            this.lblPedido.Text = "Pedido:";
            // 
            // cmbPedido
            // 
            this.cmbPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPedido.FormattingEnabled = true;
            this.cmbPedido.Location = new System.Drawing.Point(205, 113);
            this.cmbPedido.Name = "cmbPedido";
            this.cmbPedido.Size = new System.Drawing.Size(448, 23);
            this.cmbPedido.TabIndex = 25;
            // 
            // cmbProduto
            // 
            this.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(205, 167);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(448, 23);
            this.cmbProduto.TabIndex = 40;
            // 
            // EditarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.cmbPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarPedido";
            this.Text = "EditarPedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.ComboBox cmbPedido;
        private System.Windows.Forms.ComboBox cmbProduto;
    }
}
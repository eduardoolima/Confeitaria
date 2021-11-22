
namespace Confeitaria
{
    partial class PesquisarDoce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarDoce));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdPesquisar = new System.Windows.Forms.Button();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.dtpDataFab = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(664, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cmdPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdPesquisar.ForeColor = System.Drawing.Color.GhostWhite;
            this.cmdPesquisar.Location = new System.Drawing.Point(574, 23);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(118, 41);
            this.cmdPesquisar.TabIndex = 39;
            this.cmdPesquisar.Text = "Pesquisar";
            this.cmdPesquisar.UseVisualStyleBackColor = false;
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click_1);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPesquisa.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPesquisa.Location = new System.Drawing.Point(28, 27);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(322, 30);
            this.lblPesquisa.TabIndex = 40;
            this.lblPesquisa.Text = "Pesquisar por data de Fabricação:";
            // 
            // dtpDataFab
            // 
            this.dtpDataFab.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFab.Location = new System.Drawing.Point(356, 31);
            this.dtpDataFab.Name = "dtpDataFab";
            this.dtpDataFab.Size = new System.Drawing.Size(80, 23);
            this.dtpDataFab.TabIndex = 42;
            // 
            // PesquisarDoce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(727, 374);
            this.Controls.Add(this.dtpDataFab);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisarDoce";
            this.Text = "PesquisarDoce";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdPesquisar;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.DateTimePicker dtpDataFab;
    }
}
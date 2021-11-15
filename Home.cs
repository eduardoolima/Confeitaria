﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new();
            cadastroCliente.ShowDialog();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new();
            cadastroCliente.ShowDialog();
        }

        private void venderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pedido vender = new();
            vender.ShowDialog();
        }

        private void editarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarPedido editarPedido = new();
            editarPedido.ShowDialog();
        }
    }
}

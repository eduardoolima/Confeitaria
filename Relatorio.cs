﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Confeitaria.Models;

namespace Confeitaria
{
    public partial class Relatorio : Form
    {
        private int i;
        Cliente database = new Cliente();
        public Relatorio()
        {
            InitializeComponent();
        }

        private void cmdRelatorio_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Relatório";
            pd.BeginPrint += Pd_BeginPrint;
            pd.PrintPage += Imprimir;
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        private void Pd_BeginPrint(object sender, PrintEventArgs e)
        {
            i = 0;
        }

        private void Imprimir(object sender, PrintPageEventArgs ev)
        {
            //Configurações da página
            float linhaPorPagina = 0;
            float posicaoVertical = 0;
            float contador = 0;
            float margemEsqueda = 20;
            float margemSuperior = 20;
            float alturaFonte = 0;
            string linha = "";

            Font fonte = new Font("Arial", 14);
            alturaFonte = fonte.GetHeight(ev.Graphics);
            linhaPorPagina = Convert.ToInt32(ev.MarginBounds.Height / alturaFonte);

            //Título
            linha = "Lista Agenda";
            posicaoVertical = margemSuperior + contador * alturaFonte;

            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
            contador += 4;

            linha = "Nome";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);

            linha = "Telefone";
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 300, posicaoVertical);

            contador += 1;
            linha = "----------------------------------------------------------------------------------------------------------";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);

            contador++;
            DataSet ds = database.ListAllRelatorio();

            if (ds.Tables[0] != null)
            {
                while (i < ds.Tables[0].Rows.Count && contador < linhaPorPagina)
                {
                    DataRow item = ds.Tables[0].Rows[i];

                    linha = item["nome"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);

                    linha = item["telefone"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda + 300, posicaoVertical);
                    contador += 1;
                    linha = "----------------------------------------------------------------------------------------------------------";
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsqueda, posicaoVertical);
                    contador += 1;
                    i++;
                }

            }
            else MessageBox.Show("Não existe Pessoa cadastrada!");

            if (contador > linhaPorPagina)
            {
                ev.HasMorePages = true;
            }
            else
            {
                ev.HasMorePages = false;
            }
        }
    }
}

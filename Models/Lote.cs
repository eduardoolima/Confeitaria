﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Confeitaria.Models
{
    class Lote
    {
        public int idItemLote { get; set; }
        public int qtdProd { get; set; }
        public DateTime dataFabricacao { get; set; }
        public DateTime dataValidade { get; set; }
        public int idProduto { get; set; }
        DBConect database = new();

        public Lote()
        {
        }
        
        public void Add()
        {
            string sql = $"insert into Lote(qtdProd, dataFabricacao, dataValidade, idProdutoFK) values( '{qtdProd}', '{dataFabricacao.Date}', '{dataValidade.Date}','{idProduto}')";
            database.Execute(sql);
        }
        public void Edit()
        {
            string sql = $"update Lote set qtdProd = '{qtdProd}', dataFabricacao = '{dataFabricacao}', dataValidade = '{dataValidade}' where idProdutoFK = '{idProduto}'";
            database.Execute(sql);
        }

        public void Delete()
        {
            string sql = $"delete from Lote where idProdutoFK = {idProduto}";
            database.Execute(sql);
        }
        
        public void ListarDadosLote()
        {
            string sql = $"select * from Lote l join Produto p on l.idProdutoFK = p.idProduto where l.idProdutoFK = '{idProduto}'";
            database.Get(sql);
            string[] aux = database.Campos.Split(';');
            qtdProd = int.Parse(aux[1]);
            
            dataFabricacao = DateTime.Parse(aux[2]);
            dataValidade = DateTime.Parse(aux[3]);
        }
        public void GetLoteByProductId(int id)
        {
            string sql = $"select idItemLote,qtdProd, dataFabricacao,dataValidade,idProdutoFK from Lote l join Produto p on l.idProdutoFK = p.idProduto where l.idProdutoFK = '{id}'";
            database.Get(sql);
            string[] aux = database.Campos.Split(';');
            idItemLote = int.Parse(aux[0]);
            qtdProd = int.Parse(aux[1]);
            dataFabricacao = DateTime.Parse(aux[2]);
            dataValidade = DateTime.Parse(aux[3]);
            idProduto = int.Parse(aux[4]);
        }


    }
}

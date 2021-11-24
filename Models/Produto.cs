using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Confeitaria.Models
{
    class Produto
    {
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public string precoProduto { get; set; }
        public string descricao { get; set; }

        DBConect database = new();
        Lote l = new();

        public Produto()
        {
        }
        public void Add()
        {
            string sql = $"insert into Produto(nomeProd, precoProd, descricao) values( '{nomeProduto}', '{precoProduto.Replace(",",".")}', '{descricao}')";
            database.Execute(sql);
        }
        
        public void Edit()
        {
            string sql = $"update Produto set nomeProd = '{nomeProduto}', precoProd = '{precoProduto.Replace(",", ".")}', descricao = '{descricao}' where idProduto = '{idProduto}'";
            database.Execute(sql);
        }

        public void Delete()
        {
            string sql = $"delete from Produto where idProduto = '{idProduto}'";
            database.Execute(sql);
        }
        public DataSet ListByProductName()
        {
            string sql = $"select * from Produto p join Lote l on p.idProduto = l.idProduto where nomeProd = '{nomeProduto}'";
            return database.List(sql);
        }

        public int GetId(string name)
        {
            string sql = $"select idProduto from Produto where nomeProd = '{name}'";
            database.Get(sql);
            string[] aux = database.Campos.Split(';');
            idProduto = int.Parse(aux[0]);
            return idProduto;
        }
        public void ListById(int id)
        {
            string sql = $"select * from Produto p join Lote l on p.idProduto = l.idProdutoFK where p.idProduto = '{id}'";
            database.Get(sql);
            string[] aux;
            aux = database.Campos.Split(';');
            idProduto = int.Parse(aux[0]);
            nomeProduto = aux[1];
            precoProduto = aux[2];
            descricao = aux[3];
            l.qtdProd = int.Parse(aux[5]);
            l.dataFabricacao = DateTime.Parse(aux[6]);
            l.dataValidade = DateTime.Parse(aux[7]);
        }

        public DataSet ListarDados()
        {
            string sql = "select * from Produto";
            return database.List(sql);
        }
    }
}

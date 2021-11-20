using System;
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
            string sql = $"insert into Lote(qtdProd, dataFabricacao, dataValidade, idProduto) values( '{qtdProd}', '{dataFabricacao.Date}', '{dataValidade.Date}','{idProduto.ToString()}')";
            database.Execute(sql);
        }
        public void Edit()
        {
            string sql = $"update Lote set qtdProd = '{qtdProd}', dataFabricacao = '{dataFabricacao}', dataValidade = '{dataValidade}' where idProduto = '{idProduto.ToString()}'";
            database.Execute(sql);
        }
        public void Delete()
        {
            string sql = $"delete from Lote where idProduto = {idProduto.ToString()}";
            database.Execute(sql);
        }
        public void ListarDadosLote()
        {
            string sql = $"select * from Lote l join Produto p on l.idProduto = p.idProduto where l.idProduto = '{idProduto.ToString()}'";
            database.Get(sql);
            string[] aux = database.Campos.Split(';');
            qtdProd = int.Parse(aux[1]);
            dataFabricacao = DateTime.Parse(aux[2]);
            dataValidade = DateTime.Parse(aux[3]);
        }
    }
}

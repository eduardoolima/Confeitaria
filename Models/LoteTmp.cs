using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confeitaria.Models
{
    class LoteTmp
    {
        public int idItemLoteTmp { get; set; }
        public int qtdProdTmp { get; set; }
        public int idProdutoTmp { get; set; }
       

        DBConect database = new();
        public void Add()
        {
            string sql = $"insert into LoteTmp(qtdProdTmp, idProdutoTmp) values( '{qtdProdTmp}','{idProdutoTmp}')";
            database.Execute(sql);
        }
        public void Edit()
        {
            string sql = $"update LoteTmp set qtdProdTmp = '{qtdProdTmp}' where idProdutoTmp = '{idProdutoTmp}'";
            database.Execute(sql);
        }
        public void Delete()
        {
            string sql = $"delete from LoteTmp";
            database.Execute(sql);
        }
        public void GetByProductId(int id)
        {
            string sql = $"Select qtdProdTmp from LoteTmp where idProdutoTmp={id} ";
            database.Get(sql);
            string[] aux = database.Campos.Split(';');
            qtdProdTmp = int.Parse(aux[0]);
        }

        public DataSet ListAll()
        {
            string sql = "select * from LoteTmp";
            return database.List(sql);
        }

    }
}

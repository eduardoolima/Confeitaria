using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Confeitaria.Models
{
    public class Pedi
    {
        DBConect dataBase = new();
        #region propriedades
        public int idPedido { get; set; }
        public int idCompra { get; set; }
        public int idItemLote { get; set; }
        public int qtdPedido { get; set; }
        #endregion

        #region Métodos
        public void Add()
        {
            string sql = $"INSERT INTO Pedido(idPedido, idCompra, idItemLote, qtdPedido) values('{idPedido}', '{idCompra}', '{idItemLote}', '{qtdPedido}')";
            dataBase.Execute(sql);
        }
        public void Edit()
        {
            string sql = $"UPDATE Pedido set idItemLote='{idItemLote}', qtdPedido='{qtdPedido}' WHERE idPedido='{idPedido}'";
            dataBase.Execute(sql);
        }
        public void Delete()
        {
            string sql = $"DELETE Pedido WHERE idPedido='{idPedido}'";
            dataBase.Execute(sql);
        }
        public void GetByidPedido()
        {
            string sql = $"SELECT * FROM Pedido WHERE idPedido='{idPedido}'";
            dataBase.Execute(sql);
        }

        public DataSet List()
        {
            string sql = $"SELECT * FROM Pedido";
            return dataBase.List(sql);
        }
        #endregion
        public Pedi()
        {

        }

    }
}
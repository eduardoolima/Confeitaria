using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confeitaria.Models

{
    public class Pedido
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
            string sql = $"INSERT INTO Pedido(idCompraFK, idItemLoteFK, qtdPedido) values('{idCompra}', '{idItemLote}', '{qtdPedido}')";
            dataBase.Execute(sql);
        }
        public void Edit()
        {
            string sql = $"UPDATE Pedido set qtdPedido='{qtdPedido}' WHERE idPedido='{idPedido}'";
            dataBase.Execute(sql);
        }
        public void Delete(int id)
        {
            string sql = $"DELETE Pedido WHERE idPedido='{id}'";
            dataBase.Execute(sql);
        }
        public void GetByidPedido(int id)
        {
            string sql = $"SELECT * FROM Pedido WHERE idPedido='{id}'";
            dataBase.Get(sql);
            string[] aux = dataBase.Campos.Split(';');
            idPedido = int.Parse(aux[0]);
            idCompra= int.Parse(aux[1]);
            idItemLote= int.Parse(aux[2]);
            qtdPedido= int.Parse(aux[3]);
        }
       
        public DataSet ListAll()
        {
            string sql = "select idPedido, nome, dataCompra, valorCompra from Pedido p INNER JOIN Compra c on p.idCompraFK = c.idCompra INNER JOIN Cliente cl on cl.idCliente = c.idClienteFK";
            return dataBase.List(sql);
        }
        #endregion
        public Pedido()
        {

        }

    }
}


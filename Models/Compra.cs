using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confeitaria.Models
{
    class Compra
    {
        DBConect dataBase = new();
        public int idCompra { get; set; }
        public int idCliente { get; set; }
        public DateTime dataCompra { get; set; }
        public string valorCompra{ get; set; }


        #region Métodos
        public void Add()
        {
            string sql = $"INSERT INTO Compra( idClienteFK, dataCompra, valorCompra) values('{idCliente}', '{dataCompra}','{valorCompra.Replace(",",".")}')";
            dataBase.Execute(sql);
        }
        public void Edit()
        {
            string sql = $"UPDATE Compra set dataCompra='{dataCompra}', valorCompra='{valorCompra.Replace(",", ".")}' WHERE idCompra='{idCompra}'";
            dataBase.Execute(sql);
        }
        public void Delete(int id)
        {
            string sql = $"DELETE Compra WHERE idCompra='{id}'";
            dataBase.Execute(sql);
        }
        public void GetByidCompra(int id)
        {
            string sql = $"SELECT * FROM Compra WHERE idCompra='{id}'";
            dataBase.Get(sql);
            string[] aux = dataBase.Campos.Split(';');
            idCompra = int.Parse(aux[0]);
            idCliente = int.Parse(aux[1]);
            dataCompra = DateTime.Parse(aux[2]);
            valorCompra = aux[3];
        }
        public void GetCompraByIdCliente(int id)
        {
            string sql = $"SELECT idCompra, idClienteFK, dataCompra, valorCompra FROM Compra c INNER JOIN Cliente cl on c.idClienteFK = cl.idCliente where c.idClienteFK={id}";
            dataBase.Get(sql);
            string[] aux = dataBase.Campos.Split(';');
            idCompra = int.Parse(aux[0]);
            idCliente =int.Parse(aux[1]);
            dataCompra = DateTime.Parse(aux[2]);
            valorCompra = aux[3];
        }
        #endregion
    }
}

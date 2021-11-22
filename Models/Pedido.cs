﻿using System;
using System.Collections.Generic;
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
            string sql = $"INSERT INTO Pedido(idCompra, idItemLoteFK, qtdPedido) values('{idCompra}', '{idItemLote}', '{qtdPedido}')";
            dataBase.Execute(sql);
        }
        public void Edit()
        {
            string sql = $"UPDATE Pedido set qtdPedido='{qtdPedido}' WHERE idPedido='{idPedido}'";
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
        #endregion
        public Pedido()
        {

        }

    }
}


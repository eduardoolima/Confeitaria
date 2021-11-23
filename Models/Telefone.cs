using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confeitaria.Models
{
    class Telefone
    {
        #region propriedades

        public int IdTel { get; set; }
        public string Tel { get; set; }
        public int IdCliente { get; set; }
        #endregion

        DBConect dataBase = new();

        #region metodos
        public Telefone()
        {
        }

        public void Add()
        {
            string sql = "insert into Telefone(telefone, idCliente) " +
            "values( '" + Tel + "', '" + IdCliente + "')";

            dataBase.Execute(sql);
        }

        public void Delete(int id)
        {
            string sql = $"Delete from Telefone Where idTelefone = {id}";
            dataBase.Execute(sql);
        }

        public void DeleteAll(int ClientId)
        {
            string sql = $"Delete from Telefone Where idCliente = {ClientId}";
            dataBase.Execute(sql);
        }

        public void Edit(int clientId)
        {
            string sql = "";
            sql += $"Update Telefone SET telefone = '{Tel}' where idCliente = '{clientId}'";
            dataBase.Execute(sql);
        }

        public void GetByClientName(string name)
        {
            string sql = $"select t.telefone, c.idCliente from Telefone t join Cliente c on t.idCliente = c.idCliente where c.nome = '{name}'";
            dataBase.Get(sql);
            string[] aux = dataBase.Campos.Split(';');
            Tel = aux[0];
            IdCliente = int.Parse(aux[1]);
        }

        public DataSet ListByClientName(string name)
        {
            string sql = $"select t.telefone from Telefone t join Cliente c on t.idCliente = c.idCliente where c.nome = '{name}'";
            return dataBase.List(sql);
        }

        public DataSet ListAll()
        {
            string sql = "select c.nome, t.telefone from Telefone t join Cliente c on t.idCliente = c.idCliente";
            return dataBase.List(sql);
        }

        #endregion
    }
}

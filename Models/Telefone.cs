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

        public void Delete()
        {
            string sql = "Delete from Telefone Where idTelefone = " + IdTel.ToString();
            dataBase.Execute(sql);
        }

        public void Edit()
        {
            string sql = "";
            sql += $"Update Telefone SET telefone = '{Tel}";
            dataBase.Execute(sql);
        }

        public void GetByClientName(string name)
        {
            string sql = $"select c.nome, t.telefone from Telefone t join Cliente c on t.idCliente = c.idCliente where c.nome = '{name}'";
            dataBase.Get(sql);
            string[] aux = dataBase.Campos.Split(';');
            Tel = aux[0];
            IdCliente = int.Parse(aux[1]);
        }

        public DataSet ListAll()
        {
            string sql = "select c.nome, t.telefone from Telefone t join Cliente c on t.idCliente = c.idCliente";
            return dataBase.List(sql);
        }

        #endregion
    }
}

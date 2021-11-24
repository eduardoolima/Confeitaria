using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confeitaria.Models
{
    class Cliente
    {
        private readonly string path = @"C:\Users\Fabio\source\repos\Confeitaria\Logs\logError.txt";
        #region propriedades

        public int IdCliente { get; set; }  
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }


        #endregion

        DBConect dataBase = new();

        #region Metodos
        public Cliente()
        {
        }

        public void Add()
        {
            string sql = "insert into Cliente(nome, email, dataNascimento, rua, numEndereco, cidade, cep) " +
            "values( '" + Nome + "', '" + Email + "', '" + DataNasc + "', '" + Rua + "','" + Numero + "', '" + Cidade + "','" + Cep + "')";

            dataBase.Execute(sql);
        }

        public void Delete(int id)
        {
            string sql = $"Delete from Cliente Where idCliente = '{id}'";
            dataBase.Execute(sql);
        }

        public void Edit(int id)
        {
            string sql = "";
            sql += $"Update Cliente SET nome = '{Nome}', email = '{Email}', dataNascimento = '{DataNasc}', rua = '{Rua}'," +
                $" numEndereco = '{Numero}', cidade =  '{Cidade}', cep = '{Cep}' Where idCliente = {id}";
            dataBase.Execute(sql);
        }

        public void GetById(int id)
        {
            string sql = $"select * from Cliente where idCliente = '{id}'";
            dataBase.Get(sql);
            string[] aux = dataBase.Campos.Split(';');
            IdCliente = int.Parse(aux[0]);
            Nome = aux[1];
            Email = aux[2];
            DataNasc = DateTime.Parse(aux[3]);
            Rua = aux[4];
            Numero = aux[5];
            Cidade = aux[6];
            Cep = aux[7];
        }

        public void GetByClienteId(string id)
        {
            string sql = $"select * from Cliente where idCliente = '{id}'";
            dataBase.Get(sql);
            string[] aux = dataBase.Campos.Split(';');            
            IdCliente = int.Parse(aux[0]);
            Nome = aux[1];
            Email = aux[2];
            DataNasc = DateTime.Parse(aux[3]);
            Rua = aux[4];
            Numero = aux[5];
            Cidade = aux[6];
            Cep = aux[7];
        }

        public void GetOnlyIdByName(string name)
        {
            string sql = $"select idCliente from Cliente where nome = '{name}'";
            dataBase.Get(sql);
            string[] aux = dataBase.Campos.Split(';');
            IdCliente = int.Parse(aux[0]);

        }

        public DataSet ListAll()
        {
            string sql = "select * from Cliente";
            return dataBase.List(sql);
        }

        public DataSet ListAllRelatorio()
        {
            string sql = "select * from Cliente c INNER JOIN Telefone t on c.idCliente = t.idCliente";
            return dataBase.List(sql);
        }

        public void ListById(int id)
        {
            string sql = $"SELECT idCliente nome FROM Cliente where idCliente='{IdCliente}'";
            dataBase.Get(sql);
            string[] aux = dataBase.Campos.Split(';');
            IdCliente = int.Parse(aux[0]);
            Nome = aux[1];
        }

        #endregion

    }
}

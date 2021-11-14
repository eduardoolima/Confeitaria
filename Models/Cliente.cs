using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confeitaria.Models
{
    class Cliente
    {
        #region propriedades

        public int IdCliente { get; set; }  
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
        public int Numero { get; set; }
        #endregion

        DBConect dataBase = new();

        public Cliente()
        {
        }

        public void Add()
        {
            string sql = "insert into Cliente(nome, email, dataNascimento, rua, numEndereco, cidade, cep) " +
            "values( '" + Nome + "', '" + Email + "', '" + DataNasc + "', '" + Rua + "','" + Numero + "', '" + Cidade + "','" + Cep + "')";

            dataBase.Execute(sql);

            //SqlCommand cmd = new("AddCliente");
            //cmd.Parameters.AddWithValue("@nome", Nome);
            //cmd.Parameters.AddWithValue("@email", Email);
            //cmd.Parameters.AddWithValue("@dataNasc", DataNasc);
            //cmd.Parameters.AddWithValue("@cidade", Cidade);
            //cmd.Parameters.AddWithValue("@rua", Rua);
            //cmd.Parameters.AddWithValue("@cep", Cep);
            //cmd.Parameters.AddWithValue("@numero", Numero);

            //cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //dataBase.Execute(cmd);
        }

        public void GetByName(string name)
        {
            string sql = "select * from Cliente where Nome = '" + Nome + "'";
            dataBase.Get(sql);
            string[] aux = dataBase.Campos.Split(';');
            Nome = aux[0];
            Telefone = aux[1];
            Endereço = aux[2];
            Cidade = aux[3];
        }


    }
}

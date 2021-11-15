using System;
using System.Collections.Generic;
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

        public Telefone()
        {
        }



        //public void getbyclientname(string name)
        //{
        //    string sql = "select * from cliente c join telefone t on t.idcliente = c.idcliente nomewhere t.idcliente = '" + nome + "'";
        //    database.get(sql);
        //    string[] aux = database.campos.split(';');
        //    nome = aux[0];
        //    telefone = aux[1];
        //    endereço = aux[2];
        //    cidade = aux[3];
        //}
    }
}

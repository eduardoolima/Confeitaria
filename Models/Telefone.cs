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

        #endregion

        DBConect dataBase = new();

        public Telefone()
        {
        }

        public void Add()
        {
            string sql = "insert into Telefone(telefone, idCliente) " +
            "values( '" + Tel + "', '" + IdCliente + "')";

            dataBase.Execute(sql);
        }

        public void GetByClientName(string name)
        {
            string sql = "select * from Cliente c join Telefone t on t.idCliente = c.idCliente Nomewhere t.idCliente = '" + Nome + "'";
            dataBase.Get(sql);
            string[] aux = dataBase.Campos.Split(';');
            Nome = aux[0];
            Telefone = aux[1];
            Endereço = aux[2];
            Cidade = aux[3];
        }
    }
}

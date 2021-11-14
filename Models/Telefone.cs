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




        #endregion
    }
}

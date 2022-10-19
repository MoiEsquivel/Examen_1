using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    internal class Vendedor2 : Ivendedor2
    {
        private String Nombre_vendedor;

        public Vendedor2(string nombre_vendedor)
        {
            Nombre_vendedor = "Dosting";
        }

        public String Ventascredito()
        {
            return Nombre_vendedor;
        }
    }
}

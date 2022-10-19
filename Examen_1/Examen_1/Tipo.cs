using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    internal class Tipo
    {
        List<String> tipo = new List<String> { "Motocicleta", "Automovil", "Dron" };

        public static bool existe(List<String> existe, string buscar)
        {
            Boolean resultado = existe.Contains(buscar);

            
            return resultado;
        }

        public void Tipo_vehiculo()
        {
            Console.WriteLine("Existen diferentes tipos de vehiculos");            
        }
       
        
        public void Listado_vehiculos()
        {
            String buscar;
            Console.Write("Ingrese el tipo de vehiculo: "); buscar = Console.ReadLine();
            bool con = existe(tipo, buscar);

            if (con)
            {
                Console.WriteLine("Tipo de Vehiculo existe");                
            }
            else
            Console.WriteLine("Tipo de Vehiculo no existe");
           
        }
        
    }
}

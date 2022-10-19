using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    internal class Vendedores
    {
        Dictionary<int, String> vendedores = new Dictionary<int, String>()
        {
            {1, "Max" },
            {2, "Dosting" }
        };

        public Vendedores()
        {
        }

        public void Listado_vendedores()
        {

            for (int i = 0; i < vendedores.Count; i++)
            {
                Console.WriteLine($"Codigo vendedor: {vendedores.ElementAt(i).Key}\n" +
                    $"Nombre: {vendedores.ElementAt(i).Value} ");
                
            }            

        }

        public void String()
        {
            Console.WriteLine("Ingrese el codigo del vendedor");
            byte cod = byte.Parse(Console.ReadLine());
            String resustado = " ";
            if (vendedores.TryGetValue(cod, out resustado))
            {
                Console.WriteLine($"Vendedor: {resustado}");
                Console.ReadLine();
                Console.Clear();
            }
            else
                Console.WriteLine("Vendedor no existe");
                Console.ReadLine();
                Console.Clear();

        }

      

    }
}

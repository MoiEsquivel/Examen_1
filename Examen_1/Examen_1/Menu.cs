using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    static class Menu
    {
        static Menu() { }
        static Vehiculos vehiculo = new Vehiculos();
        static Vendedores vendedores = new Vendedores();

        /*
         * Creacion de menu principal
         */
        public static void menu()
        {
            byte opcion = 1;
            do
            {

                Console.WriteLine("*********** Menu Principal ********");
                
                Console.WriteLine("1- Vehiculos");                   
                Console.WriteLine("2- Ventas");                       
                Console.WriteLine("3- Reportes");             
                Console.WriteLine("4- Salir");
                
                Console.WriteLine("********************************");
                
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1: vehiculos(); break;
                    case 2:
                        vehiculo.Consultar_Articulos();
                        vendedores.String();
                        break;
                    case 3: 
                        vendedores.Listado_vendedores();
                        vehiculo.mostrar_todo();
                        break;
                    case 4:break;                     
                        
                    default:
                    Console.WriteLine("\nOpcion no existe.\nIngrese una opcion vailida.\n");
                    break;
                }
        } while (opcion != 4);
        }

        /*
        * sub menu para creacion de vehiculos
        */

        public static void vehiculos()
        {
            
            byte opcion = 1 ;
            do
            {

                Console.WriteLine("*********** Menu Principal ********");

                Console.WriteLine("1- Agregar");
                Console.WriteLine("2- Modificar");
                Console.WriteLine("3- Consultar");
                Console.WriteLine("4- Atras...");

                Console.WriteLine("********************************");

                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:vehiculo.Agregar_vehiculos(); break;
                    case 2:vehiculo.Modificar_vehiculo();  break;
                    case 3:vehiculo.Consultar_Articulos(); break;
                    case 4: menu();break;


                    default:
                        Console.WriteLine("\nOpcion no existe.\nIngrese una opcion vailida.\n"); 
                        break;
                }
            } while (opcion != 4);
        }

    }
}

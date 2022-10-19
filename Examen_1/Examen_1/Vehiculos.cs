using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    internal class Vehiculos
    {
        /*
        * Atributos 
        * get and set
        */
        protected byte codigo { get; set; } 
        protected string marca { get; set; }    
        protected double costo { get; set; }    
        protected string modelo { get; set; }   

        //Constructores

        public Vehiculos()
        {
        }

        public Vehiculos(byte codigo, string marca, double costo, string modelo)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.costo = costo;
            this.modelo = modelo;
        }

        //Arreglos
        byte[] Codigo = new byte[5];
        String[] Marca = new String[5];
        double[] Costo = new double[5]; 
        String[] Modelo = new String[5];

        //variables
        int i = 0;
        Tipo tipo = new Tipo();

        /*
        * booleano para la busqueda y validacion de arregls
        */
        public static Boolean buscar(Byte[] arreglo, byte buscar)
        {
            Boolean result = false;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (buscar == arreglo[i])
                {
                    result = true;
                }
            }
            return result;
        }

        /*
        * metodos
        */
        public void Agregar_vehiculos()
        {

            if (i < 5)
            {
                Console.WriteLine("Ingrese el codigo del veihiculo:"); Codigo[i] = byte.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la marca del veihiculo:"); Marca[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el modelo veihiculo:"); Modelo[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el costo del veihiculo:"); Costo[i] = double.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("***Vehiculo creado exitosamente***");
                Console.WriteLine("******************************\n");

                Console.WriteLine($"Codigo del vehiculo: {Codigo[i]}\n" +
                    $"Marca del vehiculo: {Marca[i]}\n" +
                    $"Modelo del vehiculo: {Modelo[i]}\n" +
                    $"Costo del vehiculo: ${Costo[i]}\n");

                Console.WriteLine("******************************\n");
                Console.ReadLine();
                Console.Clear();
                i++;
                Menu.menu();
            }
            else
            Console.WriteLine("Limite de vehiculos agregados");
            Console.ReadLine();
            Console.Clear();
                

        }

        public void Modificar_vehiculo()
        {
            byte codigo;
            Console.WriteLine("Ingrese el codigo del vehiculo a modificar"); codigo = byte.Parse(Console.ReadLine());
            bool con = buscar(Codigo,codigo);
            
            if (con)
            {
                for (int i = 0; i < Codigo.Length; i++)
                {
                    if (codigo == Codigo[i])
                    {
                        Console.WriteLine("Ingrese el codigo del veihiculo:"); Codigo[i] = byte.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la marca del veihiculo:"); Marca[i] = Console.ReadLine();
                        Console.WriteLine("Ingrese el modelo veihiculo:"); Modelo[i] = Console.ReadLine();
                        Console.WriteLine("Ingrese el costo del veihiculo:"); Costo[i] = double.Parse(Console.ReadLine());

                        Console.Clear();
                       
                    }
                }

            }
            else
            Console.WriteLine("Vehiculo no existe");
                 

        }
       

        public void Consultar_Articulos()
        {
            byte codigo;
            Console.WriteLine("Ingrese el codigo del vehiculo a Consultar"); codigo = byte.Parse(Console.ReadLine());
            bool con = buscar(Codigo, codigo);

            if (con)
            {
                for (int i = 0; i < Codigo.Length; i++)
                {
                    if (codigo == Codigo[i])
                    {
                        Console.WriteLine("******************************\n");
                        Console.WriteLine($"Codigo del vehiculo: {Codigo[i]}\n" +
                        $"Marca del vehiculo: {Marca[i]}\n" +
                        $"Modelo del vehiculo: {Modelo[i]}\n" +
                        $"Costo del vehiculo: ${Costo[i]}\n");
                        Console.WriteLine("******************************\n");
                        tipo.Listado_vehiculos();
                        Console.ReadLine();
                    }
                }
            }
            else
            Console.WriteLine("Vehiculo no existe");
            
            
        }  
        public void mostrar_todo()
        {
            byte vacio = 0;
            for (int i = 0; i < Codigo.Length; i++)
            {
                if (vacio == Codigo[i])
                {
                    Console.ReadLine();
                    Console.Clear();
                    Menu.menu();
                }
                Console.WriteLine("******************************\n");
                Console.WriteLine($"Codigo del vehiculo: {Codigo[i]}\n" +
                $"Marca del vehiculo: {Marca[i]}\n" +
                $"Modelo del vehiculo: {Modelo[i]}\n" +
                $"Costo del vehiculo: ${Costo[i]}\n");
                Console.WriteLine("******************************\n");
                
            }
            
        }
    }
}

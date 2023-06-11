using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograE4
{
    internal class ClsMenu
    {
        public static int[] vehiculos = new int[15];
        public static int[] tipoVehiculo = new int[15];
        public static int[] caseta = new int[15];
        public static int[] pago = new int[15];

        
        public static void menu()
        {
            {
                string opcion;

                Console.WriteLine("\tPrograma para controlar peaje de autopista");

                do
                {
                    Console.WriteLine("Desea continuar..(s/n)");
                    opcion = Console.ReadLine();

                    Console.WriteLine("1- Inicializar Vectores");
                    Console.WriteLine("2- Ingresar Paso Vehicular");
                    Console.WriteLine("3- Consulta de vehículos x Número de Placa");
                    Console.WriteLine("4- Modificar Datos Vehículos x número de Placa");
                    Console.WriteLine("5- Reporte Todos los Datos de los vectores");
                    Console.WriteLine("6- Salir");
                    Console.WriteLine("Digite la opcion que desea realizar: ");
                    opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1": break;
                        case "2": break;
                        case "3": ClsTransacciones.Consulta(); break;
                        case "4": ClsTransacciones.Modificar(); break;
                        //case "5": Reporte(); break;
                        case "6": break;
                        default:
                            Console.WriteLine("Opcion no es valida!!");
                            break;
                    }

                } while (opcion.Equals("s"));
                Console.ReadLine();


            }
        }
    }
}

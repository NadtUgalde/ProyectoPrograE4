using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograE4
{
    internal class ClsMenu
    {
               
        public static void menu()
        {
            string opcion;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ╔═══════════════════════════════════════════════════╗");
                Console.WriteLine(" ║    PROGRAMA DE CONTROL PARA PEAJE EN AUTOPISTA    ║");
                Console.WriteLine(" ╠═══════════════════════════════════════════════════╣");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" ║ 1. Inicializar Vectores                           ║");
                Console.WriteLine(" ║ 2. Ingresar Paso Vehicular                        ║");
                Console.WriteLine(" ║ 3. Consulta de vehículos x Número de Placa        ║");
                Console.WriteLine(" ║ 4. Modificar Datos Vehículos x número de Placa    ║");
                Console.WriteLine(" ║ 5. Reporte Todos los Datos de los vectores        ║");
                Console.WriteLine(" ║ 6. Salir                                          ║");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" ╠═══════════════════════════════════════════════════╣");
                Console.WriteLine(" ║        SELECCIONE UNA OPCIÓN DEL MENÚ             ║");
                Console.WriteLine(" ╚═══════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(" → ");
                Console.ForegroundColor = ConsoleColor.White; opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1": ClsTransacciones.inicializarV(); break;
                    case "2": ClsTransacciones.agregarVehiculos(); break;
                    case "3": ClsTransacciones.consulta(); break;
                    case "4": ClsTransacciones.Modificar(); break;
                    case "5": ClsTransacciones.Reporte(); break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("\n\n\t ╔═════════════════════════════════════╗");
                        Console.Write("\t ║    Cerrando sesión - CARGANDO");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write(".");
                            System.Threading.Thread.Sleep(1200);
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("    ║");
                        Console.WriteLine("\t ╚═════════════════════════════════════╝");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t -- ERROR 504 - Error de formato de datos --");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Se ha detectado un error en el valor ingresado, intentalo de nuevo :)");
                        break;
                }
                Console.ReadLine();
            } while (!opcion.Equals("6"));
          
        }
    }
}
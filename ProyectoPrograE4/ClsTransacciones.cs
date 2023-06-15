using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograE4
{
    internal class ClsTransacciones
    {
        private static float[] numFactura = new float[15];
        private static string[] numPlaca = new string[15];
        private static string[] fecha = new string[15];
        private static string[] hora = new string[15];
        private static int[] tipoVehiculo = new int[15];
        private static int[] montoCancelar = new int[15];
        private static int[] montoCliente = new int[15];
        private static int[] vuelto = new int[15];
        private static int[] numCaseta = new int[15];
        static int capacidad = 15;
        static int contador = 0;

        public static void inicializarV()//Limpia los vectores, para poder ingresar nuevos valores.
        {
            Console.Clear();
            for (int i = 0; i < numPlaca.Length; i++)
           //bucle que recorre la longitud de uno de los vectores, para asi utilizar la variable de control [I] para
           //formatear los demás vectores.
            {
                numPlaca[i] = "";
                numFactura[i] = 0;
                fecha[i] = "";
                hora[i] = "";
                tipoVehiculo[i] = 0;
                montoCancelar[i] = 0;
                montoCliente[i] = 0;
                vuelto[i] = 0;
                numCaseta[i] = 0;
                contador = 0;
            }
            Console.WriteLine("\n\n\t ╔═══════════════════════════════════════════════════╗");
            Console.WriteLine("\t ║       !VECTORES RESTABLECIDOS CON EXITO!          ║");
            Console.WriteLine("\t ╚═══════════════════════════════════════════════════╝");
        }
        public static void agregarVehiculos()//Agrega nuevo vehiculos que pasen por el peaje.
        {
            Console.Clear();
            string op = "";
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\t ╔════════════════════════════════════════╗");
                Console.WriteLine("\t ║       REGISTRAR FLUJO VEHICULAR        ║");
                Console.WriteLine("\t ╚════════════════════════════════════════╝\n");
                Console.ForegroundColor = ConsoleColor.White;//Se solicitan datos como el numero de la factura, placa, caseta, entre otros. 
                Console.Write("Numero de factura: ");
                numFactura[contador] = int.Parse(Console.ReadLine());

                Console.Write("Numero de placa: ");
                numPlaca[contador] = Console.ReadLine();

                Console.Write("Fecha: ");
                fecha[contador] = Console.ReadLine();

                Console.Write("Hora: ");
                hora[contador] = Console.ReadLine();

                int tipoVehiculo;
                bool CarroValido = false;
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;//2nd parte. Se solicita el tipo de vehiculo y dependiendo de la opcion seleccionada se aplica una tarifa en especifico.
                    Console.WriteLine("\n\t ╔════════════════════════════════════════════╗");
                    Console.WriteLine("\t ║       SELECCIONE UN TIPO DE VEHICULO       ║");
                    Console.WriteLine("\t ╚════════════════════════════════════════════╝\n");
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("1 → Moto\n2 → Vehículo liviano\n3 → Camión o C.Pesado\n4 → Autobús\nOpción elegida: ");
                    if (int.TryParse(Console.ReadLine(), out tipoVehiculo))
                    {
                        if (tipoVehiculo == 1)
                        {
                            int moto = 500;
                            montoCancelar[contador] = moto;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\t ╔═══════════════════════════════════════════════════╗");
                            Console.WriteLine("\t ║         REGISTRADA MOTOCICLETA CON EXITO          ║");
                            Console.WriteLine("\t ╚═══════════════════════════════════════════════════╝");
                            Console.ReadLine();
                            CarroValido = true;
                        }
                        else if (tipoVehiculo == 2)
                        {
                            int carroLiviano = 700;
                            montoCancelar[contador] = carroLiviano;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\t ╔═══════════════════════════════════════════════════╗");
                            Console.WriteLine("\t ║      REGISTRADO VEHÍCULO LIVIANO CON EXITO        ║");
                            Console.WriteLine("\t ╚═══════════════════════════════════════════════════╝");
                            Console.ReadLine();
                            CarroValido = true;
                        }
                        else if (tipoVehiculo == 3)
                        {
                            int carroPesado = 2700;
                            montoCancelar[contador] = carroPesado;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\t ╔═══════════════════════════════════════════════════╗");
                            Console.WriteLine("\t ║      REGISTRADO VEHÍCULO PESADO CON EXITO         ║");
                            Console.WriteLine("\t ╚═══════════════════════════════════════════════════╝");
                            Console.ReadLine();
                            CarroValido = true;
                        }
                        else if (tipoVehiculo == 4)
                        {
                            int bus = 3700;
                            montoCancelar[contador] = bus;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\t ╔═══════════════════════════════════════════════════╗");
                            Console.WriteLine("\t ║          REGISTRADO AUTOBÚS CON EXITO             ║");
                            Console.WriteLine("\t ╚═══════════════════════════════════════════════════╝");
                            Console.ReadLine();
                            CarroValido = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\t-- ERROR 4 - Error al seleccionar un tipo de vehiculo --");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("  Se ha detectado un error en el valor ingresado, intentalo de nuevo :)");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t-- ERROR 4 - Error al seleccionar un tipo de vehiculo --");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("  Se ha detectado un error en el valor ingresado, intentalo de nuevo :)");
                        Console.ReadLine();
                        Console.Clear();
                    }
                } while (!CarroValido);

                bool CasetaValida = false;
                int caseta;
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\t ╔═══════════════════════════════════════════════════╗");
                    Console.WriteLine("\t ║          NUMERO DE CASETA EN EL PEAJE             ║");
                    Console.WriteLine("\t ╚═══════════════════════════════════════════════════╝");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" → Caseta 1\n → Caseta 2\n → Caseta 3\nOpción elegida: ");
                    if (int.TryParse(Console.ReadLine(), out caseta))
                    {
                        if (caseta == 1)
                        {
                            numCaseta[contador] = caseta;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\t ╔═════════════════════════════════════════════════╗");
                            Console.WriteLine("\t ║         REGISTRADA CASETA 1 CON EXITO           ║");
                            Console.WriteLine("\t ╚═════════════════════════════════════════════════╝");
                            Console.ReadLine();
                            CasetaValida = true;
                        }
                        else if (caseta == 2)
                        {
                            numCaseta[contador] = caseta;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\t ╔═══════════════════════════════════════════╗");
                            Console.WriteLine("\t ║       REGISTRADO CASETA 2 CON EXITO       ║");
                            Console.WriteLine("\t ╚═══════════════════════════════════════════╝");
                            Console.ReadLine();
                            CasetaValida = true;
                        }
                        else if (caseta == 3)
                        {
                            numCaseta[contador] = caseta;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n\t ╔══════════════════════════════════════════╗");
                            Console.WriteLine("\t ║      REGISTRADO CASETA 3 CON EXITO       ║");
                            Console.WriteLine("\t ╚══════════════════════════════════════════╝");
                            CasetaValida = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\t-- ERROR 4 - Error al seleccionar una caseta del peaje --");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("  Se ha detectado un error en el valor ingresado, intentalo de nuevo :)");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\t-- ERROR 4 - Error al seleccionar una caseta del peaje --");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("  Se ha detectado un error en el valor ingresado, intentalo de nuevo :)");
                        Console.ReadLine();
                    }
                } while (!CasetaValida);

                Console.ForegroundColor = ConsoleColor.White; Console.Write("\nMonto con el paga (cliente): ");
                montoCliente[contador] = int.Parse(Console.ReadLine());

                if (montoCliente[contador] < montoCancelar[contador])//se solicita el monto con el que se va a pagar y en caso de que sea inferior a la tarifa se elimina esa posicion del arreglo.
                {
                    Console.Clear(); Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t -- ERROR 101 - Error con el monto a pagar --");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("El monto ingresado es inferior al que debe cancelar, intentalo de nuevo.");
                    numFactura[contador] = 0;
                    numPlaca[contador] = "";
                    numCaseta[contador] = 0;
                    fecha[contador] = "";
                    hora[contador] = "";
                    montoCancelar[contador] = 0;
                    montoCliente[contador] = 0;
                    vuelto[contador] = 0;
                    contador -= 1;
                    break;
                }
                vuelto[contador] = montoCliente[contador] - montoCancelar[contador];
                contador += 1;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n¿Desea continuar? (si/no)\n → ");
                Console.ForegroundColor = ConsoleColor.White;
                op = Console.ReadLine().ToLower();//Se utiliza un contador, además, de una variable con la capacidad para no perder la cantidad de vehiculos que ya han cruzado por el peaje y asi saber cuando llegue a su límite.
            } while (op == "si" && contador < capacidad);
        }
        public static void consulta()
        {
            Boolean Existe = false;
            Console.Write("Digite el numero de placa que desea consultar: "); string placa = Console.ReadLine();

            for (int i = 0; i < 15; i++)
            {
                if (numPlaca[i].Equals(placa))
                {
                    Console.Clear();

                    Console.WriteLine("Esta es la información de "+numPlaca[i]);
                    Console.WriteLine("Fecha: "+fecha[i]);
                    Console.WriteLine("Hora: " + hora[i]);
                    Console.WriteLine("Tipo de Vehiculo: " + tipoVehiculo[i]);
                    Console.WriteLine("Peaje: " + tipoVehiculo[i]);
                    Existe = true;
                    break;
                }

            }
            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("Placa no existe");
            }
            Console.ReadLine();
        }
       
        public static void Modificar()
        {
            int Placa;
            int montoPago;
            Boolean Existe = false;
            Console.WriteLine("Digite el numero de placa que desea consultar: ");
            Placa = int.Parse(Console.ReadLine());
            string op;

            for (int i = 0; i < 15; i++)
            {
                if (numPlaca[i].Equals(Placa))
                {
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\t ╔══════════════════════════╗");
                        Console.WriteLine("\t ║  1- Placa                 ║  ");
                        Console.WriteLine("\t ║  2- Tipo de vehículo      ║ ");
                        Console.WriteLine("\t ║ 3- Caseta                 ║ ");
                        Console.WriteLine("\t ║ 4- Salir                  ║ "); 
                        Console.WriteLine("\t ╚═══════════════════════════╝");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Digite la opcion que desea modificar: ");
                        op = Console.ReadLine();

                        switch (op)
                        {
                            case "1":
                                Console.Clear();
                                Console.Write("Actualice el numero de placa: ");
                                numPlaca[i] = Console.ReadLine();
                                break;
                            case "2":
                                Console.Write("Actualice el tipo de vehículo: ");
                                tipoVehiculo[i] = int.Parse(Console.ReadLine());

                                break;
                            case "3":
                                Console.Write("Actualice la caseta: ");
                                numCaseta[i] = int.Parse(Console.ReadLine());
                                break;
                            case "4": break;
                            default:
                                Console.WriteLine("Opcion no es valida!!");
                                break;
                        }

                    } while (!op.Equals("4"));

                    Existe = true;
                    break;
                }

            }

            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("Placa no existe");
            }

        }
        public static void Reporte()
        {    
            Console.Clear();
            Console.WriteLine("********* REPORTE DE VEHICULOS *************");
            for (int j = 0; j < numPlaca.Length; j++)
            {
                Console.WriteLine($"Placa: {numPlaca[j]} Factura: {numFactura[j]} Fecha: {fecha[j]} Hora: {hora[j]} Tarifa: {montoCancelar[j]} Monto cliente: {montoCliente[j]} Vuelto: {vuelto[j]}");
            }
            Console.WriteLine("********** Fin del reporte*************");
            Console.Read();
        }
        
    }
 }

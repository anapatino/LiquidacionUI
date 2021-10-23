using System;
using Entidad;
using Logica;

namespace Presentacion
{
    class Program
    {
        private static readonly LiquidacionCuotaModeradoraService liquidacionService = new LiquidacionCuotaModeradoraService();
        static void Main(string[] args)
        {
            char seguir='S';
            do
            {
               int opcion=Menu();
                switch (opcion)
                {
                    case 1:Guardar();
                        break;
                    case 2:ConsultarRegistros();
                        break;
                    case 3:Eliminar();
                        break;
                    case 4: Modificar();
                        break;
                    case 5: seguir = 'N';
                        break;
                }

            } while (seguir =='S');
        }

        public static int  Menu()
        {
            Console.Clear();
            Console.WriteLine("------BIENVENIDO A LA IPS VIDA Y SALUD--------");
            Console.WriteLine("1.Registar Paciente");
            Console.WriteLine("2.Consultar Registro ");
            Console.WriteLine("3.Eliminar");
            Console.WriteLine("4.Modificar");
            Console.WriteLine("5.Salir ");
            int opcion;
            do
            {
                Console.Write("        Seleccione su opcion: "); opcion = int.Parse(Console.ReadLine());
            } while (opcion < 1 && opcion > 5);
            return opcion;
           
        }

        private static LiquidacionCuotaModeradora RegistarDatos()
        {
            Console.Write("Nro.Liquidacion :"); decimal numeroLiquidacion = decimal.Parse(Console.ReadLine());
            Console.Write("Fecha Liquidacion:"); DateTime fechaLiquidacion= DateTime.Parse(Console.ReadLine());
            Console.Write("Identificacion  :"); long identificacion = long.Parse(Console.ReadLine());
            Console.Write("Tipo Afiliacion :"); string afiliacion = Console.ReadLine();
            Console.Write("Salario         :"); decimal salario = decimal.Parse(Console.ReadLine());
            Console.Write("Valor Servicio  :"); decimal valorServicio = decimal.Parse(Console.ReadLine());
            if (afiliacion.ToUpper().Equals("SUBSIDIADO"))
            {
                LiquidacionCuotaModeradora subsidiado = new LiquidacionSubsidiado(numeroLiquidacion, identificacion, afiliacion, salario, valorServicio, fechaLiquidacion);
                subsidiado.CalcularCuotaModeradora();
                return subsidiado;
            }
            else if (afiliacion.ToUpper().Equals("CONTRIBUTIVO"))
            {
                LiquidacionCuotaModeradora contributivo = new LiquidacionContributivo(numeroLiquidacion, identificacion, afiliacion, salario, valorServicio, fechaLiquidacion);
                contributivo.CalcularCuotaModeradora();
                return contributivo;
            }
            return null;
        }
        private static void Guardar()
        {
            Console.Clear();
            Console.WriteLine("------ Registro de  Pacientes--------");
            Console.WriteLine("");
            var paciente = RegistarDatos();
            string mensaje = liquidacionService.Guarda(paciente);
            Console.WriteLine($"     { mensaje}");
            Console.Write("          Pulse una tecla para salir "); Console.ReadKey();
        }
        public static void ConsultarRegistros()
        {
            Console.Clear();
            Console.WriteLine("------Consulta de Datos--------");
            Console.WriteLine();
            var respuesta = liquidacionService.Consultar();
            if (respuesta.Error)
            {
                Console.WriteLine($"     { respuesta.Mensaje}");
            }
            else
            {
                foreach (var item in respuesta.Pacientes)
                {
                    Console.WriteLine($"Nro.Liquidacion     : {item.NumeroLiquidacion} "); 
                    Console.WriteLine($"Fecha Liquidacion   : {item.FechaLiquidacion}"); 
                    Console.WriteLine($"Identificacion      : {item.Identificacion}"); 
                    Console.WriteLine($"Tipo Afiliacion     : {item.Afiliacion}"); 
                    Console.WriteLine($"Salario             : {item.Salario}"); 
                    Console.WriteLine($"Valor Servicio      : {item.ValorServicio}");
                    Console.WriteLine($"      Valor Liquidado-> {item.ValorLiquidado}");
                    Console.WriteLine("------------------------------------------------");
                }
                Console.Write("Pulse una tecla para salir "); Console.ReadKey();
            }
        }

        public static void Eliminar()
        {
            Console.Clear();
            Console.WriteLine("------Eliminar por Identificacion --------");
            Console.WriteLine();
            Console.Write(" Nro Liquidacion :");decimal numeroLiquidacion = decimal.Parse(Console.ReadLine());
            var (mensajeEliminacion, personaEliminada) = liquidacionService.Eliminar(numeroLiquidacion);
            Console.WriteLine($"    { mensajeEliminacion} ");
            Console.Write("   Pulse una tecla para salir "); Console.ReadKey();
        }
        public static void Modificar()
        {
            Console.Clear();
            Console.WriteLine("----------Datos deL Paciente----------");
            Console.WriteLine();
            BuscarYCambiarValorPaciente();
            Console.Write("   Pulse una tecla para salir "); Console.ReadKey();
        }

        public static void BuscarYCambiarValorPaciente()
        {
            Console.Write("Nro.Liquidacion: ");
            decimal numeroLiquidacion = decimal.Parse(Console.ReadLine());
            var mensajeBusqueda = liquidacionService.Buscar(numeroLiquidacion);
            if (mensajeBusqueda.IsError)
            {
                Console.WriteLine(mensajeBusqueda.Mensaje);
            }
            else
            {
                Console.WriteLine($"Nro.Liquidacion     : {mensajeBusqueda.Paciente.NumeroLiquidacion} ");
                Console.WriteLine($"Fecha Liquidacion   : {mensajeBusqueda.Paciente.FechaLiquidacion}");
                Console.WriteLine($"Identificacion      : {mensajeBusqueda.Paciente.Identificacion}");
                Console.WriteLine($"Tipo Afiliacion     : {mensajeBusqueda.Paciente.Afiliacion}");
                Console.WriteLine($"Salario             : {mensajeBusqueda.Paciente.Salario}");
                Console.WriteLine($"Valor Servicio      : {mensajeBusqueda.Paciente.ValorServicio}");
                Console.WriteLine($" Valor Liquidado    : {mensajeBusqueda.Paciente.ValorLiquidado}");
                Console.WriteLine("---------Solicitando los Nuevos Datos--------- ");
                Console.WriteLine($" NUEVO VALOR SERVICIO   :"); decimal nuevoValorServicio = decimal.Parse(Console.ReadLine());
                mensajeBusqueda.Paciente.ValorServicio = nuevoValorServicio;
                mensajeBusqueda.Paciente.CalcularCuotaModeradora();
            }
        }
    }
}

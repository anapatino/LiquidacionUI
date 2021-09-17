using System;
using System.Collections.Generic;
using System.IO;
using Entidad;
namespace Datos
{
    public class LiquidacionCuotaModeradoraRepository
    {
        public string ruta =@"ListaPersonaLiquidadas.txt";

        public void Guardar(LiquidacionCuotaModeradora paciente)
        {
            using StreamWriter escritor = new (ruta, true);
               escritor.WriteLine($"{paciente.NumeroLiquidacion};{paciente.Identificacion};{paciente.Afiliacion};{paciente.Salario};{paciente.ValorServicio};{paciente.FechaLiquidacion};{paciente.ValorLiquidado}");
        }
        public List<LiquidacionCuotaModeradora> Consultar()
        {
            List<LiquidacionCuotaModeradora> pacientes = new();
            StreamReader lector = new(ruta);
            string linea;
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                if (dato[2].ToUpper().Equals("SUBSIDIADO"))
                {
                    LiquidacionCuotaModeradora pacienteSubsicidiado = new LiquidacionContributivo()
                    {
                        NumeroLiquidacion = decimal.Parse(dato[0]),
                        Identificacion = long.Parse(dato[1]),
                        Afiliacion = dato[2],
                        Salario = decimal.Parse(dato[3]),
                        ValorServicio = decimal.Parse(dato[4]),
                        FechaLiquidacion = dato[5],
                        ValorLiquidado = decimal.Parse(dato[6])
                    };
                    pacientes.Add(pacienteSubsicidiado);
                }
                else
                {
                    LiquidacionCuotaModeradora pacienteContributivo = new LiquidacionContributivo()
                    {
                        NumeroLiquidacion = decimal.Parse(dato[0]),
                        Identificacion = long.Parse(dato[1]),
                        Afiliacion = dato[2],
                        Salario = decimal.Parse(dato[3]),
                        ValorServicio = decimal.Parse(dato[4]),
                        FechaLiquidacion = dato[5],
                        ValorLiquidado = decimal.Parse(dato[6])
                    };
                    pacientes.Add(pacienteContributivo);
                }
               
            }
            lector.Close();
            return pacientes;
        }

        public void Eliminar(decimal numeroLiquidacion)
        {
            List<LiquidacionCuotaModeradora> pacientes = Consultar();
            File.Delete(ruta);
            foreach (var item in pacientes)
            {
                if (!item.NumeroLiquidacion.Equals(numeroLiquidacion))
                {
                    Guardar(item);
                }
            }

        }
        public void Modificar(decimal valorServicio,LiquidacionCuotaModeradora personaNew)
        {
            List<LiquidacionCuotaModeradora> liquidacion = Consultar();
            File.Delete(ruta);
            foreach (var item in liquidacion)
            {
                if (!item.ValorServicio.Equals(valorServicio))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(personaNew);
                }
            }
        }
        public LiquidacionCuotaModeradora Buscar(decimal numeroLiquidacion)
        {
            List<LiquidacionCuotaModeradora> pacientes = Consultar();
            foreach (var item in pacientes)
            {  
                if (item.NumeroLiquidacion.Equals(numeroLiquidacion))
                {
                    return item;
                }
            }
            return null;
        }

        public LiquidacionCuotaModeradora BuscarValorServicio(decimal valorServicio)
        {
            List<LiquidacionCuotaModeradora> pacientes = Consultar();
            foreach (var item in pacientes)
            {
                if (item.ValorServicio.Equals(valorServicio))
                {
                    return item;
                }
            }
            return null;
        }

    }
}

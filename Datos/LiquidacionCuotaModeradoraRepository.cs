using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Entidad;
namespace Datos
{
    public class LiquidacionCuotaModeradoraRepository
    {
        public string ruta =@"ListaPersonaLiquidadas.txt";

        public void Guardar(LiquidacionCuotaModeradora paciente)
        {
            using StreamWriter escritor = new (ruta, true);
               escritor.WriteLine($"{paciente.NumeroLiquidacion};{paciente.Identificacion};{paciente.Afiliacion};{paciente.Salario};{paciente.ValorServicio};{paciente.FechaLiquidacion};{paciente.ValorLiquidado};");
        }
        public List<LiquidacionCuotaModeradora> Consultar()
        {
            List<LiquidacionCuotaModeradora> pacientes = new();
            LiquidacionCuotaModeradora paciente;
            StreamReader lector = new(ruta);
            string linea;
            while ((linea = lector.ReadLine()) != null)
            {
                paciente = MapearLiquidacion(linea);
                pacientes.Add(paciente);
            }
            lector.Close();
            return pacientes;
        }
        public static LiquidacionCuotaModeradora MapearLiquidacion(string linea)
        {
            string[] dato = linea.Split(';');
            var liquidacion = CrearLiquidacion(dato[2]);
            liquidacion.NumeroLiquidacion = decimal.Parse(dato[0]);
            liquidacion.Identificacion = long.Parse(dato[1]);
            liquidacion.Afiliacion = dato[2];
            liquidacion.Salario = decimal.Parse(dato[3]);
            liquidacion.ValorServicio = decimal.Parse(dato[4]);
            liquidacion.FechaLiquidacion = DateTime.Parse(dato[5]);
            liquidacion.ValorLiquidado = decimal.Parse(dato[6]);
             return liquidacion;
        }
        public static LiquidacionCuotaModeradora CrearLiquidacion(string afiliacion)
        {
            LiquidacionCuotaModeradora liquidacion;
            if (afiliacion.Equals("CONTRIBUTIVO"))
            {
                liquidacion = new LiquidacionContributivo();
            }
            else 
            {
                liquidacion = new LiquidacionSubsidiado();
            }
            return liquidacion;
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

        public LiquidacionCuotaModeradora FiltrarPorLiquidacion(decimal liquidacion)
        {
            return (LiquidacionCuotaModeradora)Consultar().FirstOrDefault(p => p.NumeroLiquidacion.Equals(liquidacion));
        }

        public LiquidacionCuotaModeradora FiltrarPorIdentificacion(long identificacion)
        {
            return (LiquidacionCuotaModeradora)Consultar().FirstOrDefault(p => p.Identificacion.Equals(identificacion));
        }

        public List<LiquidacionCuotaModeradora> FiltrarPorAfiliacion(string afiliacion)
        {
            return Consultar().Where(p => p.Afiliacion.ToUpper().Equals(afiliacion)).ToList();
        }

        public List<LiquidacionCuotaModeradora> FiltrarPorServicio(decimal servicio)
        {
            return Consultar().Where(p => p.ValorServicio.Equals(servicio)).ToList();
        }

        public List<LiquidacionCuotaModeradora> FiltrarPorAnio(int year)
        {
            return Consultar().Where(p => p.FechaLiquidacion.Year == year).ToList();
        }
    }
}

using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LiquidacionBuscarResponse
    {
       public LiquidacionCuotaModeradora Paciente { get; set; }
       public string Mensaje { get; set; }
       public bool IsError { get; set; }

       public LiquidacionBuscarResponse(LiquidacionCuotaModeradora paciente)
        {
            Paciente = paciente;
            IsError = false;
        }
        public LiquidacionBuscarResponse(string mensaje)
        {
            Mensaje = mensaje;
            IsError = true;
        }
    }
}

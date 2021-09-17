using System;
using Entidad;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LiquidacionConsultaResponse
    {
        public List<LiquidacionCuotaModeradora> Pacientes { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public LiquidacionConsultaResponse(List<LiquidacionCuotaModeradora> pacientes)
        {
            Pacientes = pacientes;
            Error = false;
        }
        public LiquidacionConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
       
    }
}

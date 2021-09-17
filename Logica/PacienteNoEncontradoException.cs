using System;
using Entidad;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PacienteNoEncontradoException:Exception
    {
        public PacienteNoEncontradoException()
        {

        }
        public PacienteNoEncontradoException(string message):base(message)
        {

        }
    }
}

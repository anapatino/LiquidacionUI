using System;
using Datos;
using Entidad;

namespace Logica
{
    public class LiquidacionCuotaModeradoraService
    {
        readonly LiquidacionCuotaModeradoraRepository liquidacionRepository;
      
        public LiquidacionCuotaModeradoraService()
        {
            liquidacionRepository = new LiquidacionCuotaModeradoraRepository();
          
        }

        public string Guarda(LiquidacionCuotaModeradora paciente)
        {
            try
            {
                 liquidacionRepository.Guardar(paciente);
                 return "Se guardo el registro Satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error inesperado al Guardar: {e.Message}";
            }
        }
        public LiquidacionConsultaResponse Consultar()
        {
            try
            {
                return new LiquidacionConsultaResponse(liquidacionRepository.Consultar());
            }
            catch (Exception e)
            {

                return new LiquidacionConsultaResponse($"Error inesperado al Consultar: {e.Message}");
            }
        }
        
        public LiquidacionBuscarResponse Buscar(decimal numeroLiquidacion)
        {
            try
            {
                var paciente = liquidacionRepository.Buscar(numeroLiquidacion);
                if (paciente == null)
                {

                    throw new PacienteNoEncontradoException("No se encontró un registro con el Nro.Liquidacion Solicitada");
                }
                return new LiquidacionBuscarResponse(paciente);
            }
            catch (PacienteNoEncontradoException e)
            {
                return new LiquidacionBuscarResponse($"Error al Buscar :{e.Message}");
            }
        }
        public string Eliminar(decimal numeroLiquidacion)
        {
            try
            {
                if (liquidacionRepository.Buscar(numeroLiquidacion) !=null)
                {
                    liquidacionRepository.Eliminar(numeroLiquidacion);
                    return $"Se Eliminó el registro de la persona con Nro.Liquidacion ({numeroLiquidacion})";
                }
                return $"No fue posible eliminar el registro, porque no existe la persona con Nro.Liquidacion ({numeroLiquidacion})";
            }
            catch (Exception e)
            {
                return $"Error inesperado al Eliminar: {e.Message}";
            }

        }

        public string Modificar(long identificacion,LiquidacionCuotaModeradora personaNew)
        {
            try
            {
                if (liquidacionRepository.Buscar(identificacion)==null)
                {
                    return $"No es posible realizar la Modificación, la persona con Identificacion {identificacion} no existe";
                }
                if (liquidacionRepository.Buscar(personaNew.Identificacion)!=null)
                {
                    return $"No es posible realizar la Modificación, La Nueva Identificación {personaNew.Identificacion} ya se encuentra asignada a otra persona";
                }
                liquidacionRepository.Modificar(identificacion, personaNew);
                return "Se realizó la Modificación Satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error inesperado al Modificar: {e.Message}";
            }
        }

     

    }
}

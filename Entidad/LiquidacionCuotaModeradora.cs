using System;

namespace Entidad
{
    public abstract class LiquidacionCuotaModeradora
    {
      
        public decimal valorLiquidado;
        public LiquidacionCuotaModeradora()
        {

        }
        public LiquidacionCuotaModeradora(decimal numeroLiquidacion, long identificacion, string afiliacion, decimal salario, decimal valorServicio,DateTime fecha)
        {
            NumeroLiquidacion = numeroLiquidacion;
            Identificacion = identificacion;
            Afiliacion = afiliacion;
            Salario = salario;
            ValorServicio = valorServicio;
            ValorLiquidado = valorLiquidado;
            FechaLiquidacion = fecha;
        }

        public decimal NumeroLiquidacion { get; set; }
        public long Identificacion { get; set; }
        public string Afiliacion { get; set; }
        public decimal Salario { get; set; }
        public decimal ValorServicio { get; set; }
        public DateTime FechaLiquidacion { get; set; }
        public decimal ValorLiquidado { get; set; }
    
        public void CalcularCuotaModeradora()
        {
            decimal tarifa = CalcularTarifa();
            decimal cuotaModeradora = ValorServicio * tarifa;
            ValorLiquidado =ValidarTope(cuotaModeradora);
        }
        public abstract decimal CalcularTarifa();
        public abstract decimal ValidarTope(decimal cuotaModeradora);
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class LiquidacionSubsidiado:LiquidacionCuotaModeradora
    {
        public LiquidacionSubsidiado()
        {

        }
        public LiquidacionSubsidiado(decimal numeroLiquidacion, long identificacion, string afiliacion, decimal salario, decimal valorServicio, string fechaLiquidacion)
        : base(numeroLiquidacion, identificacion, afiliacion, salario, valorServicio, fechaLiquidacion)
        {

        }
       
        public override decimal CalcularTarifa()
        {
            decimal tarifa = (decimal)((double)Salario * 0.05);
            return tarifa;
        }

        public override decimal ValidarTope(decimal cuotaModeradora)
        {
            decimal valorLiquidado = 0;
            if (cuotaModeradora > 200000)
            {
                valorLiquidado = 200000;
            }
            else
            {
                valorLiquidado = cuotaModeradora;
            }

            return valorLiquidado;
        }
    }
}

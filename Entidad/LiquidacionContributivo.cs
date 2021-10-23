using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class LiquidacionContributivo:LiquidacionCuotaModeradora
    {
        private decimal salarioMinimo=908526;
        public LiquidacionContributivo()
        {

        }
        public LiquidacionContributivo(decimal numeroLiquidacion, long identificacion, string afiliacion, decimal salario, decimal valorServicio, DateTime fechaLiquidacion)
        : base(numeroLiquidacion, identificacion, afiliacion, salario, valorServicio, fechaLiquidacion)
        {

        }

   
        public override decimal CalcularTarifa()
        {

            decimal tarifa;
            if (Salario < (salarioMinimo * 2))
            {
                tarifa = (decimal)((double)Salario * 0.15);
            }
            else if ((Salario > (salarioMinimo * 2)) && (Salario < (salarioMinimo * 5)))
            {
                tarifa = (decimal)((double)Salario * 0.2);
            }
            else if (Salario > (salarioMinimo * 5))
            {
                tarifa = (decimal)((double)Salario * 0.25);
            }
            else
            {
                tarifa = 0;
            }
            return tarifa;
        }

        public override decimal ValidarTope(decimal cuotaModeradora)
        {
            decimal valorLiquidado;
            if ((Salario < (salarioMinimo * 2)) && (cuotaModeradora > 250000))
            {
                valorLiquidado = 250000;
            }
            else if ((Salario > (salarioMinimo * 2)) && (Salario < (Salario * 5)) && (cuotaModeradora > 900000))
            {
                valorLiquidado = 900000;
            }
            else if ((Salario > (salarioMinimo * 5)) && (cuotaModeradora > 1500000))
            {
                valorLiquidado = 1500000;
            }
            else
            {
                valorLiquidado = cuotaModeradora;
            }

            return valorLiquidado;
        }
    }
}

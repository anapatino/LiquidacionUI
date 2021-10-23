using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;

namespace PresentacionGUI
{
    public partial class FrmGestion : Form
    {
        private static readonly LiquidacionCuotaModeradoraService liquidacionService = new LiquidacionCuotaModeradoraService();
        public FrmGestion()
        {
            InitializeComponent();
        }

        private void bnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            var persona = RegistarDatos();
            string mensaje = liquidacionService.Guarda(persona);
            MessageBox.Show(mensaje);
            Limpiar();
        }
        public LiquidacionCuotaModeradora RegistarDatos()
        {
            decimal numeroLiquidacion = decimal.Parse(txtLiquidacion.Text);
            DateTime fechaLiquidacion =dateTimePicker1.Value;
            long identificacion = long.Parse(txtIdentificacion.Text);
            string afiliacion = cmAfiliacion.Text;
            decimal salario = decimal.Parse(txtSalario.Text);
            decimal valorServicio = decimal.Parse(txtValor.Text);
            if (afiliacion.Equals("SUBSIDIADO"))
            {
                LiquidacionCuotaModeradora subsidiado = new LiquidacionSubsidiado(numeroLiquidacion, identificacion, afiliacion, salario, valorServicio, fechaLiquidacion);
                subsidiado.CalcularCuotaModeradora();
                return subsidiado;
            }
            else if (afiliacion.Equals("CONTRIBUTIVO"))
            {
                LiquidacionCuotaModeradora contributivo = new LiquidacionContributivo(numeroLiquidacion, identificacion, afiliacion, salario, valorServicio, fechaLiquidacion);
                contributivo.CalcularCuotaModeradora();
                return contributivo;
            }
            return null;
        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txtLiquidacion.Text = null;
            txtIdentificacion.Text = null;
            cmAfiliacion.Text = null;
            txtSalario.Text = null;
            txtValor.Text = null;
        }

        private void bnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

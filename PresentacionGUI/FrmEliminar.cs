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
    public partial class FrmEliminar : Form
    {
        private static readonly LiquidacionCuotaModeradoraService liquidacionService = new LiquidacionCuotaModeradoraService();
        public FrmEliminar()
        {
            InitializeComponent();
        }
        public void Visualizar()
        {
            decimal numeroLiquidacion =decimal.Parse(txtLiquidacion.Text);
            var  (mensaje,personaEliminada) = liquidacionService.Eliminar(numeroLiquidacion);
            if (mensaje.Equals($"Se Eliminó el registro de la persona con identificacion {numeroLiquidacion}"))
            {
                ActivarTabla(personaEliminada);
            }
            MessageBox.Show(mensaje);
            LimpiarTxtBox();
        }
        public void ActivarTabla(LiquidacionCuotaModeradora paciente)
        {
            dgvTabla.Visible = true;
           dgvTabla.Rows.Add(paciente.NumeroLiquidacion, paciente.Identificacion, paciente.Afiliacion, paciente.Salario, paciente.ValorServicio, paciente.FechaLiquidacion.Year, paciente.ValorLiquidado);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxtBox();
            dgvTabla.Visible = false;
        }
        public void LimpiarTxtBox()
        {
            txtLiquidacion.Text = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Visualizar();
        }
    }
}

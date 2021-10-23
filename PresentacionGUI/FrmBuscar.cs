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
    public partial class FrmBuscar : Form
    {
        public FrmBuscar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public void LimpiarTxtBox()
        {
            cbItem.Text = null;
            txtBusqueda.Text = null;
            dgvTabla.Rows.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ValidarFiltro();
        }
        private void ValidarFiltro()
        {
            string filtro = cbItem.Text;
            if (filtro.Equals("Nro Liquidacion"))
            {
                VisualizarLiquidacion();
            }
            else if (filtro.Equals("Identificacion"))
            {
                VisualizarIdentificacion();
            }
            else if (filtro.Equals("Anio"))
            {
                VisualizarAnio();
            }
            else if (filtro.Equals("afiliacion"))
            {
                VisualizarAfiliacion();
            }
            else if (filtro.Equals("servicio"))
            {
                VisualizarServicio();
            }
        }

        public void VisualizarIdentificacion()
        {
           long identificacion =long.Parse( txtBusqueda.Text);
            LiquidacionCuotaModeradoraService personaService = new LiquidacionCuotaModeradoraService();
            var personaBuscada = personaService.ConsultarPorIdentificacion(identificacion);
            ValidarSiExiste(personaBuscada);
        }

        public void VisualizarLiquidacion()
        {
            decimal liquidacion = long.Parse(txtBusqueda.Text);
            LiquidacionCuotaModeradoraService personaService = new LiquidacionCuotaModeradoraService();
            var personaBuscada = personaService.ConsultarPorLiquidacion(liquidacion);
            ValidarSiExiste(personaBuscada);
        }

        public void ValidarSiExiste(LiquidacionBuscarResponse personaBuscada)
        {
            if (personaBuscada.IsError == false)
            {
                ActivarTabla(personaBuscada.Paciente);
            }
            MessageBox.Show(personaBuscada.Mensaje);
        }

        public void VisualizarAnio()
        {
            LiquidacionConsultaResponse respuesta;
            LiquidacionCuotaModeradoraService personaService = new LiquidacionCuotaModeradoraService();
            int year = int.Parse(txtBusqueda.Text);
            respuesta = personaService.ConsultarPorAnio(year);
            AgregarRegistroPanel(respuesta);
        }

        public void VisualizarAfiliacion()
        {
            LiquidacionConsultaResponse respuesta;
            LiquidacionCuotaModeradoraService personaService = new LiquidacionCuotaModeradoraService();
            string afiliacion =txtBusqueda.Text;
            respuesta = personaService.ConsultarPorAfiliacion(afiliacion);
            AgregarRegistroPanel(respuesta);
        }

        public void VisualizarServicio()
        {
            LiquidacionConsultaResponse respuesta;
            LiquidacionCuotaModeradoraService personaService = new LiquidacionCuotaModeradoraService();
            int servicio = int.Parse(txtBusqueda.Text);
            respuesta = personaService.ConsultarPorServicio(servicio);
            AgregarRegistroPanel(respuesta);
        }

        public void AgregarRegistroPanel(LiquidacionConsultaResponse respuesta)
        {
            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvTabla.Visible = true;
                foreach (var paciente in respuesta.Pacientes)
                {
                    dgvTabla.Rows.Add(paciente.NumeroLiquidacion, paciente.Identificacion, paciente.Afiliacion, paciente.Salario, paciente.ValorServicio, paciente.FechaLiquidacion.Year, paciente.ValorLiquidado);
                }

            }
        }

        public void ActivarTabla(LiquidacionCuotaModeradora paciente)
        {
            dgvTabla.Visible = true;
            dgvTabla.Rows.Add(paciente.NumeroLiquidacion,paciente.Identificacion, paciente.Afiliacion, paciente.Salario, paciente.ValorServicio,paciente.FechaLiquidacion.Year, paciente.ValorLiquidado);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
             LimpiarTxtBox();
             dgvTabla.Visible = false;
        }
    }
}

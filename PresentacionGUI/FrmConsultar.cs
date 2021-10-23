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
    public partial class FrmConsultar : Form
    {
        private static readonly LiquidacionCuotaModeradoraService personaService = new LiquidacionCuotaModeradoraService();
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            VisualizarTabla();
        }
        public void VisualizarTabla()
        {
            var respuesta = personaService.Consultar();
            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                foreach (var paciente in respuesta.Pacientes)
                {
                    dgvTabla.Rows.Add(paciente.NumeroLiquidacion, paciente.Identificacion, paciente.Afiliacion, paciente.Salario,   paciente.ValorServicio, paciente.FechaLiquidacion.Year,  paciente.ValorLiquidado);  
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void itemGestion_Click(object sender, EventArgs e)
        {
            new FrmGestion().Show();
        }
        private void itemConsulta_Click(object sender, EventArgs e)
        {
            new FrmConsultar().Show();
        }

        private void itemEliminar_Click(object sender, EventArgs e)
        {
            new FrmEliminar().Show();
        }

        private void itemBuscar_Click(object sender, EventArgs e)
        {
            new FrmBuscar().Show();
        }
    }
}

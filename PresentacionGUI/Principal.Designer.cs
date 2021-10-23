
namespace PresentacionGUI
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.itemConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personaToolStripMenuItem
            // 
            this.personaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemGestion,
            this.itemConsulta,
            this.itemEliminar,
            this.itemBuscar,
            this.modificarToolStripMenuItem});
            this.personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            this.personaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personaToolStripMenuItem.Text = "Paciente";
            // 
            // itemGestion
            // 
            this.itemGestion.Name = "itemGestion";
            this.itemGestion.Size = new System.Drawing.Size(180, 22);
            this.itemGestion.Text = "Gestion";
            this.itemGestion.Click += new System.EventHandler(this.itemGestion_Click);
            // 
            // itemConsulta
            // 
            this.itemConsulta.Name = "itemConsulta";
            this.itemConsulta.Size = new System.Drawing.Size(180, 22);
            this.itemConsulta.Text = "Consulta";
            this.itemConsulta.Click += new System.EventHandler(this.itemConsulta_Click);
            // 
            // itemEliminar
            // 
            this.itemEliminar.Name = "itemEliminar";
            this.itemEliminar.Size = new System.Drawing.Size(180, 22);
            this.itemEliminar.Text = "Eliminar";
            this.itemEliminar.Click += new System.EventHandler(this.itemEliminar_Click);
            // 
            // itemBuscar
            // 
            this.itemBuscar.Name = "itemBuscar";
            this.itemBuscar.Size = new System.Drawing.Size(180, 22);
            this.itemBuscar.Text = "Buscar";
            this.itemBuscar.Click += new System.EventHandler(this.itemBuscar_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 338);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemGestion;
        private System.Windows.Forms.ToolStripMenuItem itemConsulta;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemEliminar;
        private System.Windows.Forms.ToolStripMenuItem itemBuscar;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
    }
}


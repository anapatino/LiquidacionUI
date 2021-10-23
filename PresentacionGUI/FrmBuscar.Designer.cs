
namespace PresentacionGUI
{
    partial class FrmBuscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.dgvNroLiquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAfiliacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValorLiquidado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cbItem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNroLiquidacion,
            this.dgvIdentificacion,
            this.dgvAfiliacion,
            this.dgvSalario,
            this.dgvServicio,
            this.cnFecha,
            this.dgvValorLiquidado});
            this.dgvTabla.Location = new System.Drawing.Point(33, 147);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowTemplate.Height = 25;
            this.dgvTabla.Size = new System.Drawing.Size(734, 157);
            this.dgvTabla.TabIndex = 8;
            // 
            // dgvNroLiquidacion
            // 
            this.dgvNroLiquidacion.HeaderText = "NroLiquidacion";
            this.dgvNroLiquidacion.Name = "dgvNroLiquidacion";
            this.dgvNroLiquidacion.ReadOnly = true;
            // 
            // dgvIdentificacion
            // 
            this.dgvIdentificacion.HeaderText = "Identificacion";
            this.dgvIdentificacion.Name = "dgvIdentificacion";
            this.dgvIdentificacion.ReadOnly = true;
            // 
            // dgvAfiliacion
            // 
            this.dgvAfiliacion.HeaderText = "Afiliacion";
            this.dgvAfiliacion.Name = "dgvAfiliacion";
            this.dgvAfiliacion.ReadOnly = true;
            // 
            // dgvSalario
            // 
            this.dgvSalario.HeaderText = "Salario";
            this.dgvSalario.Name = "dgvSalario";
            this.dgvSalario.ReadOnly = true;
            // 
            // dgvServicio
            // 
            this.dgvServicio.HeaderText = "Servicio";
            this.dgvServicio.Name = "dgvServicio";
            this.dgvServicio.ReadOnly = true;
            // 
            // cnFecha
            // 
            this.cnFecha.HeaderText = "Fecha";
            this.cnFecha.Name = "cnFecha";
            this.cnFecha.ReadOnly = true;
            // 
            // dgvValorLiquidado
            // 
            this.dgvValorLiquidado.HeaderText = "ValorLiquidado";
            this.dgvValorLiquidado.Name = "dgvValorLiquidado";
            this.dgvValorLiquidado.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(525, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(313, 348);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(434, 348);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(322, 85);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(187, 23);
            this.txtBusqueda.TabIndex = 11;
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Location = new System.Drawing.Point(148, 88);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(34, 15);
            this.lbFiltro.TabIndex = 10;
            this.lbFiltro.Text = "Filtro";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(322, 36);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(109, 15);
            this.lbTitulo.TabIndex = 9;
            this.lbTitulo.Text = "BUSCAR REGISTRO ";
            // 
            // cbItem
            // 
            this.cbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Items.AddRange(new object[] {
            "Nro Liquidacion",
            "Identificacion",
            "Anio",
            "afiliacion",
            "servicio"});
            this.cbItem.Location = new System.Drawing.Point(188, 85);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(117, 23);
            this.cbItem.TabIndex = 8;
            // 
            // FrmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.lbFiltro);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.dgvTabla);
            this.Name = "FrmBuscar";
            this.Text = "FrmBuscar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNroLiquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAfiliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValorLiquidado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ComboBox cbItem;
    }
}
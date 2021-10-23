
namespace PresentacionGUI
{
    partial class FrmEliminar
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbIdentificacion = new System.Windows.Forms.Label();
            this.txtLiquidacion = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.dgvNroLiquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAfiliacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValorLiquidado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(313, 32);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(118, 15);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "ELIMINAR REGISTRO ";
            // 
            // lbIdentificacion
            // 
            this.lbIdentificacion.AutoSize = true;
            this.lbIdentificacion.Location = new System.Drawing.Point(196, 85);
            this.lbIdentificacion.Name = "lbIdentificacion";
            this.lbIdentificacion.Size = new System.Drawing.Size(92, 15);
            this.lbIdentificacion.TabIndex = 2;
            this.lbIdentificacion.Text = "Nro Liquidacion";
            // 
            // txtLiquidacion
            // 
            this.txtLiquidacion.Location = new System.Drawing.Point(294, 85);
            this.txtLiquidacion.Name = "txtLiquidacion";
            this.txtLiquidacion.Size = new System.Drawing.Size(187, 23);
            this.txtLiquidacion.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(516, 85);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(425, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(304, 358);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.dgvTabla.Location = new System.Drawing.Point(21, 157);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowTemplate.Height = 25;
            this.dgvTabla.Size = new System.Drawing.Size(734, 157);
            this.dgvTabla.TabIndex = 7;
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
            // FrmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 425);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtLiquidacion);
            this.Controls.Add(this.lbIdentificacion);
            this.Controls.Add(this.lbTitulo);
            this.Name = "FrmEliminar";
            this.Text = "Eliminar Persona";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbIdentificacion;
        private System.Windows.Forms.TextBox txtLiquidacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNroLiquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAfiliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValorLiquidado;
    }
  
}

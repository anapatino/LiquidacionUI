
namespace PresentacionGUI
{
    partial class FrmConsultar
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
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
            this.dgvTabla.Location = new System.Drawing.Point(27, 79);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowTemplate.Height = 25;
            this.dgvTabla.Size = new System.Drawing.Size(735, 188);
            this.dgvTabla.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTROS INGRESADOS";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(411, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(291, 307);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 3;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
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
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 375);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTabla);
            this.Name = "FrmConsultar";
            this.Text = "Consultar Persona";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNroLiquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAfiliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValorLiquidado;
    }
}
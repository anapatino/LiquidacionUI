
namespace PresentacionGUI
{
    partial class FrmGestion
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
            this.lbLiquidacion = new System.Windows.Forms.Label();
            this.lbIdentificacion = new System.Windows.Forms.Label();
            this.lbAfiliacion = new System.Windows.Forms.Label();
            this.lbSalario = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.txtLiquidacion = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.bnGuardar = new System.Windows.Forms.Button();
            this.bnLimpiar = new System.Windows.Forms.Button();
            this.bnCancelar = new System.Windows.Forms.Button();
            this.cmAfiliacion = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(258, 42);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(109, 15);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "GESTION DE DATOS";
            // 
            // lbLiquidacion
            // 
            this.lbLiquidacion.AutoSize = true;
            this.lbLiquidacion.Location = new System.Drawing.Point(106, 96);
            this.lbLiquidacion.Name = "lbLiquidacion";
            this.lbLiquidacion.Size = new System.Drawing.Size(89, 15);
            this.lbLiquidacion.TabIndex = 1;
            this.lbLiquidacion.Text = "NroLiquidacion";
            // 
            // lbIdentificacion
            // 
            this.lbIdentificacion.AutoSize = true;
            this.lbIdentificacion.Location = new System.Drawing.Point(116, 138);
            this.lbIdentificacion.Name = "lbIdentificacion";
            this.lbIdentificacion.Size = new System.Drawing.Size(79, 15);
            this.lbIdentificacion.TabIndex = 2;
            this.lbIdentificacion.Text = "Identificacion";
            // 
            // lbAfiliacion
            // 
            this.lbAfiliacion.AutoSize = true;
            this.lbAfiliacion.Location = new System.Drawing.Point(138, 182);
            this.lbAfiliacion.Name = "lbAfiliacion";
            this.lbAfiliacion.Size = new System.Drawing.Size(57, 15);
            this.lbAfiliacion.TabIndex = 3;
            this.lbAfiliacion.Text = "Afiliacion";
            // 
            // lbSalario
            // 
            this.lbSalario.AutoSize = true;
            this.lbSalario.Location = new System.Drawing.Point(153, 224);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(42, 15);
            this.lbSalario.TabIndex = 4;
            this.lbSalario.Text = "Salario";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(162, 265);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(33, 15);
            this.lbValor.TabIndex = 5;
            this.lbValor.Text = "Valor";
            // 
            // txtLiquidacion
            // 
            this.txtLiquidacion.Location = new System.Drawing.Point(217, 88);
            this.txtLiquidacion.Name = "txtLiquidacion";
            this.txtLiquidacion.Size = new System.Drawing.Size(205, 23);
            this.txtLiquidacion.TabIndex = 6;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(217, 130);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(205, 23);
            this.txtIdentificacion.TabIndex = 7;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(217, 216);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(205, 23);
            this.txtSalario.TabIndex = 9;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(217, 262);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(205, 23);
            this.txtValor.TabIndex = 10;
            // 
            // bnGuardar
            // 
            this.bnGuardar.Location = new System.Drawing.Point(159, 324);
            this.bnGuardar.Name = "bnGuardar";
            this.bnGuardar.Size = new System.Drawing.Size(75, 23);
            this.bnGuardar.TabIndex = 11;
            this.bnGuardar.Text = "Guardar";
            this.bnGuardar.UseVisualStyleBackColor = true;
            this.bnGuardar.Click += new System.EventHandler(this.bnGuardar_Click);
            // 
            // bnLimpiar
            // 
            this.bnLimpiar.Location = new System.Drawing.Point(267, 324);
            this.bnLimpiar.Name = "bnLimpiar";
            this.bnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bnLimpiar.TabIndex = 12;
            this.bnLimpiar.Text = "Limpiar";
            this.bnLimpiar.UseVisualStyleBackColor = true;
            this.bnLimpiar.Click += new System.EventHandler(this.bnLimpiar_Click);
            // 
            // bnCancelar
            // 
            this.bnCancelar.Location = new System.Drawing.Point(381, 324);
            this.bnCancelar.Name = "bnCancelar";
            this.bnCancelar.Size = new System.Drawing.Size(75, 23);
            this.bnCancelar.TabIndex = 13;
            this.bnCancelar.Text = "Cancelar";
            this.bnCancelar.UseVisualStyleBackColor = true;
            this.bnCancelar.Click += new System.EventHandler(this.bnCancelar_Click);
            // 
            // cmAfiliacion
            // 
            this.cmAfiliacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmAfiliacion.FormattingEnabled = true;
            this.cmAfiliacion.Items.AddRange(new object[] {
            "SUBSIDIADO",
            "CONTRIBUTIVO"});
            this.cmAfiliacion.Location = new System.Drawing.Point(217, 174);
            this.cmAfiliacion.Name = "cmAfiliacion";
            this.cmAfiliacion.Size = new System.Drawing.Size(205, 23);
            this.cmAfiliacion.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(489, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 23);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // FrmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 412);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmAfiliacion);
            this.Controls.Add(this.bnCancelar);
            this.Controls.Add(this.bnLimpiar);
            this.Controls.Add(this.bnGuardar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtLiquidacion);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbSalario);
            this.Controls.Add(this.lbAfiliacion);
            this.Controls.Add(this.lbIdentificacion);
            this.Controls.Add(this.lbLiquidacion);
            this.Controls.Add(this.lbTitulo);
            this.Name = "FrmGestion";
            this.Text = "Gestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbLiquidacion;
        private System.Windows.Forms.Label lbIdentificacion;
        private System.Windows.Forms.Label lbAfiliacion;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.TextBox txtLiquidacion;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button bnGuardar;
        private System.Windows.Forms.Button bnLimpiar;
        private System.Windows.Forms.Button bnCancelar;
        private System.Windows.Forms.ComboBox cmAfiliacion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
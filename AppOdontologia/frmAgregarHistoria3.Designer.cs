namespace AppOdontologia
{
    partial class frmAgregarHistoria3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.gbxSecuencia = new System.Windows.Forms.GroupBox();
            this.btnSecuencia = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbxSecuencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diagnostico y plan de tratamiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(29, 628);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(131, 50);
            this.btnAnterior.TabIndex = 8;
            this.btnAnterior.Text = "< Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(552, 628);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(240, 50);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar historia clinica";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(73, 153);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(681, 124);
            this.txtDiagnostico.TabIndex = 10;
            this.txtDiagnostico.TextChanged += new System.EventHandler(this.txtAspecto_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(274, 60);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(377, 33);
            this.txtDescripcion.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Descripcion del tratamieto:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(31, 60);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 33);
            this.dtpFecha.TabIndex = 22;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // gbxSecuencia
            // 
            this.gbxSecuencia.Controls.Add(this.button2);
            this.gbxSecuencia.Controls.Add(this.btnCerrar);
            this.gbxSecuencia.Controls.Add(this.label3);
            this.gbxSecuencia.Controls.Add(this.label4);
            this.gbxSecuencia.Controls.Add(this.dtpFecha);
            this.gbxSecuencia.Controls.Add(this.txtDescripcion);
            this.gbxSecuencia.Location = new System.Drawing.Point(71, 419);
            this.gbxSecuencia.Name = "gbxSecuencia";
            this.gbxSecuencia.Size = new System.Drawing.Size(683, 165);
            this.gbxSecuencia.TabIndex = 23;
            this.gbxSecuencia.TabStop = false;
            this.gbxSecuencia.Text = "Secuencia de tratamiento";
            this.gbxSecuencia.Enter += new System.EventHandler(this.gbxSecuencia_Enter);
            // 
            // btnSecuencia
            // 
            this.btnSecuencia.Location = new System.Drawing.Point(443, 381);
            this.btnSecuencia.Name = "btnSecuencia";
            this.btnSecuencia.Size = new System.Drawing.Size(313, 32);
            this.btnSecuencia.TabIndex = 24;
            this.btnSecuencia.Text = "Añadir secuencia de tratamiento";
            this.btnSecuencia.UseVisualStyleBackColor = true;
            this.btnSecuencia.Click += new System.EventHandler(this.btnSecuencia_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(172, 325);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(454, 33);
            this.txtEstado.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Historia clínica odontologíca";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(31, 120);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(250, 39);
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.Text = "Cerrar secuencia";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 39);
            this.button2.TabIndex = 24;
            this.button2.Text = "Guardar secuencia";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAgregarHistoria3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 690);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSecuencia);
            this.Controls.Add(this.gbxSecuencia);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAgregarHistoria3";
            this.Text = "frmAgregarHistoria3";
            this.Load += new System.EventHandler(this.frmAgregarHistoria3_Load);
            this.gbxSecuencia.ResumeLayout(false);
            this.gbxSecuencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox gbxSecuencia;
        private System.Windows.Forms.Button btnSecuencia;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCerrar;
    }
}
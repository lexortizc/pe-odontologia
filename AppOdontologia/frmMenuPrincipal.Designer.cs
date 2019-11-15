namespace AppOdontologia
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.panelReporte = new System.Windows.Forms.Panel();
            this.btnCrearReporte = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.panelHistoria = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnAgregarHistoria = new System.Windows.Forms.Button();
            this.btnHistoria = new System.Windows.Forms.Button();
            this.panelPaciente = new System.Windows.Forms.Panel();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.btnAgregarPaciente = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelReporte.SuspendLayout();
            this.panelHistoria.SuspendLayout();
            this.panelPaciente.SuspendLayout();
            this.panelEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnCredito);
            this.panelMenu.Controls.Add(this.panelReporte);
            this.panelMenu.Controls.Add(this.btnReporte);
            this.panelMenu.Controls.Add(this.panelHistoria);
            this.panelMenu.Controls.Add(this.btnHistoria);
            this.panelMenu.Controls.Add(this.panelPaciente);
            this.panelMenu.Controls.Add(this.btnPaciente);
            this.panelMenu.Controls.Add(this.panelEncabezado);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 720);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 670);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(250, 50);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Cerrar sesión";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnCredito.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCredito.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCredito.FlatAppearance.BorderSize = 0;
            this.btnCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredito.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredito.ForeColor = System.Drawing.Color.White;
            this.btnCredito.Location = new System.Drawing.Point(0, 450);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(250, 50);
            this.btnCredito.TabIndex = 8;
            this.btnCredito.Text = "Créditos";
            this.btnCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCredito.UseVisualStyleBackColor = false;
            this.btnCredito.Click += new System.EventHandler(this.BtnCredito_Click);
            // 
            // panelReporte
            // 
            this.panelReporte.Controls.Add(this.btnCrearReporte);
            this.panelReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReporte.Location = new System.Drawing.Point(0, 410);
            this.panelReporte.Name = "panelReporte";
            this.panelReporte.Size = new System.Drawing.Size(250, 40);
            this.panelReporte.TabIndex = 7;
            // 
            // btnCrearReporte
            // 
            this.btnCrearReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnCrearReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearReporte.FlatAppearance.BorderSize = 0;
            this.btnCrearReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearReporte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReporte.ForeColor = System.Drawing.Color.White;
            this.btnCrearReporte.Location = new System.Drawing.Point(0, 0);
            this.btnCrearReporte.Name = "btnCrearReporte";
            this.btnCrearReporte.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCrearReporte.Size = new System.Drawing.Size(250, 40);
            this.btnCrearReporte.TabIndex = 1;
            this.btnCrearReporte.Text = "Crear reporte";
            this.btnCrearReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearReporte.UseVisualStyleBackColor = false;
            this.btnCrearReporte.Click += new System.EventHandler(this.BtnCrearReporte_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(0, 360);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(250, 50);
            this.btnReporte.TabIndex = 6;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // panelHistoria
            // 
            this.panelHistoria.Controls.Add(this.btnHistorial);
            this.panelHistoria.Controls.Add(this.btnAgregarHistoria);
            this.panelHistoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHistoria.Location = new System.Drawing.Point(0, 280);
            this.panelHistoria.Name = "panelHistoria";
            this.panelHistoria.Size = new System.Drawing.Size(250, 80);
            this.panelHistoria.TabIndex = 5;
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Location = new System.Drawing.Point(0, 40);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHistorial.Size = new System.Drawing.Size(250, 40);
            this.btnHistorial.TabIndex = 2;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
            // 
            // btnAgregarHistoria
            // 
            this.btnAgregarHistoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnAgregarHistoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarHistoria.FlatAppearance.BorderSize = 0;
            this.btnAgregarHistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarHistoria.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHistoria.ForeColor = System.Drawing.Color.White;
            this.btnAgregarHistoria.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarHistoria.Name = "btnAgregarHistoria";
            this.btnAgregarHistoria.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAgregarHistoria.Size = new System.Drawing.Size(250, 40);
            this.btnAgregarHistoria.TabIndex = 1;
            this.btnAgregarHistoria.Text = "Agregar";
            this.btnAgregarHistoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarHistoria.UseVisualStyleBackColor = false;
            this.btnAgregarHistoria.Click += new System.EventHandler(this.BtnAgregarHistoria_Click);
            // 
            // btnHistoria
            // 
            this.btnHistoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnHistoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistoria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHistoria.FlatAppearance.BorderSize = 0;
            this.btnHistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoria.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoria.ForeColor = System.Drawing.Color.White;
            this.btnHistoria.Location = new System.Drawing.Point(0, 230);
            this.btnHistoria.Name = "btnHistoria";
            this.btnHistoria.Size = new System.Drawing.Size(250, 50);
            this.btnHistoria.TabIndex = 4;
            this.btnHistoria.Text = "Historias";
            this.btnHistoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoria.UseVisualStyleBackColor = false;
            this.btnHistoria.Click += new System.EventHandler(this.BtnHistoria_Click);
            // 
            // panelPaciente
            // 
            this.panelPaciente.Controls.Add(this.btnArchivo);
            this.panelPaciente.Controls.Add(this.btnAgregarPaciente);
            this.panelPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPaciente.Location = new System.Drawing.Point(0, 150);
            this.panelPaciente.Name = "panelPaciente";
            this.panelPaciente.Size = new System.Drawing.Size(250, 80);
            this.panelPaciente.TabIndex = 2;
            // 
            // btnArchivo
            // 
            this.btnArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnArchivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArchivo.FlatAppearance.BorderSize = 0;
            this.btnArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchivo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivo.ForeColor = System.Drawing.Color.White;
            this.btnArchivo.Location = new System.Drawing.Point(0, 40);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnArchivo.Size = new System.Drawing.Size(250, 40);
            this.btnArchivo.TabIndex = 1;
            this.btnArchivo.Text = "Archivo";
            this.btnArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchivo.UseVisualStyleBackColor = false;
            this.btnArchivo.Click += new System.EventHandler(this.BtnArchivo_Click);
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnAgregarPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarPaciente.FlatAppearance.BorderSize = 0;
            this.btnAgregarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPaciente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPaciente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPaciente.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAgregarPaciente.Size = new System.Drawing.Size(250, 40);
            this.btnAgregarPaciente.TabIndex = 0;
            this.btnAgregarPaciente.Text = "Agregar";
            this.btnAgregarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPaciente.UseVisualStyleBackColor = false;
            this.btnAgregarPaciente.Click += new System.EventHandler(this.BtnAgregarPaciente_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.Color.White;
            this.btnPaciente.Location = new System.Drawing.Point(0, 100);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(250, 50);
            this.btnPaciente.TabIndex = 1;
            this.btnPaciente.Text = "Pacientes";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.BtnPaciente_Click);
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(122)))), ((int)(((byte)(209)))));
            this.panelEncabezado.Controls.Add(this.pictureBox2);
            this.panelEncabezado.Controls.Add(this.panel2);
            this.panelEncabezado.Controls.Add(this.label1);
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(250, 100);
            this.panelEncabezado.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppOdontologia.Properties.Resources.Logo1;
            this.pictureBox2.Location = new System.Drawing.Point(166, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 30);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 30);
            this.panel1.TabIndex = 1;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.SystemColors.Menu;
            this.panelContenido.Controls.Add(this.pictureBox1);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(250, 30);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(830, 690);
            this.panelContenido.TabIndex = 2;
            this.panelContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenido_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::AppOdontologia.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(223, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelReporte.ResumeLayout(false);
            this.panelHistoria.ResumeLayout(false);
            this.panelPaciente.ResumeLayout(false);
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Panel panelPaciente;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Button btnAgregarPaciente;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHistoria;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnAgregarHistoria;
        private System.Windows.Forms.Button btnHistoria;
        private System.Windows.Forms.Panel panelReporte;
        private System.Windows.Forms.Button btnCrearReporte;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


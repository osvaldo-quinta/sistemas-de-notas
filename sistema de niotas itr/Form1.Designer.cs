namespace sistema_de_niotas_itr
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbRegistroNotas = new System.Windows.Forms.GroupBox();
            this.gbPromedio = new System.Windows.Forms.GroupBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblPromedioObtenido = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnAgregarPromedio = new System.Windows.Forms.Button();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlpAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.gbRegistroNotas.SuspendLayout();
            this.gbPromedio.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRegistroNotas
            // 
            this.gbRegistroNotas.BackColor = System.Drawing.Color.LavenderBlush;
            this.gbRegistroNotas.Controls.Add(this.pictureBox1);
            this.gbRegistroNotas.Controls.Add(this.lblNota3);
            this.gbRegistroNotas.Controls.Add(this.lblNota2);
            this.gbRegistroNotas.Controls.Add(this.lblNota1);
            this.gbRegistroNotas.Controls.Add(this.txtNota2);
            this.gbRegistroNotas.Controls.Add(this.txtNota3);
            this.gbRegistroNotas.Controls.Add(this.txtNota1);
            this.gbRegistroNotas.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistroNotas.Location = new System.Drawing.Point(22, 25);
            this.gbRegistroNotas.Name = "gbRegistroNotas";
            this.gbRegistroNotas.Size = new System.Drawing.Size(487, 233);
            this.gbRegistroNotas.TabIndex = 0;
            this.gbRegistroNotas.TabStop = false;
            this.gbRegistroNotas.Text = "Registro de Notas";
            // 
            // gbPromedio
            // 
            this.gbPromedio.BackColor = System.Drawing.Color.LavenderBlush;
            this.gbPromedio.Controls.Add(this.lblPromedioObtenido);
            this.gbPromedio.Controls.Add(this.textBox5);
            this.gbPromedio.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPromedio.Location = new System.Drawing.Point(22, 283);
            this.gbPromedio.Name = "gbPromedio";
            this.gbPromedio.Size = new System.Drawing.Size(487, 155);
            this.gbPromedio.TabIndex = 1;
            this.gbPromedio.TabStop = false;
            this.gbPromedio.Text = "Promedio";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(126, 48);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 25);
            this.txtNota1.TabIndex = 1;
            this.tlpAyuda.SetToolTip(this.txtNota1, "Ingresa valores entre 0 y 10\r\n");
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(126, 178);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 25);
            this.txtNota3.TabIndex = 2;
            this.tlpAyuda.SetToolTip(this.txtNota3, "Ingresa valores entre 0 y 10\r\n\r\n");
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(126, 109);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 25);
            this.txtNota2.TabIndex = 3;
            this.tlpAyuda.SetToolTip(this.txtNota2, "Ingresa valores entre 0 y 10\r\n");
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(167, 62);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 28);
            this.textBox5.TabIndex = 5;
            this.tlpAyuda.SetToolTip(this.textBox5, "Ingresa valores entre 0 y 10\r\n");
            // 
            // lblPromedioObtenido
            // 
            this.lblPromedioObtenido.AutoSize = true;
            this.lblPromedioObtenido.Location = new System.Drawing.Point(29, 65);
            this.lblPromedioObtenido.Name = "lblPromedioObtenido";
            this.lblPromedioObtenido.Size = new System.Drawing.Size(132, 23);
            this.lblPromedioObtenido.TabIndex = 6;
            this.lblPromedioObtenido.Text = "Promedio obtenido";
            this.lblPromedioObtenido.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(50, 48);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(50, 18);
            this.lblNota1.TabIndex = 4;
            this.lblNota1.Text = "Nota 1";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(50, 116);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(50, 18);
            this.lblNota2.TabIndex = 5;
            this.lblNota2.Text = "Nota 2";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(50, 185);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(50, 18);
            this.lblNota3.TabIndex = 6;
            this.lblNota3.Text = "Nota 3";
            // 
            // gbAcciones
            // 
            this.gbAcciones.BackColor = System.Drawing.Color.LavenderBlush;
            this.gbAcciones.Controls.Add(this.btnAgregarPromedio);
            this.gbAcciones.Controls.Add(this.btnNuevoRegistro);
            this.gbAcciones.Controls.Add(this.btnSalir);
            this.gbAcciones.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcciones.Location = new System.Drawing.Point(568, 47);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(187, 267);
            this.gbAcciones.TabIndex = 4;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // btnAgregarPromedio
            // 
            this.btnAgregarPromedio.Image = global::sistema_de_niotas_itr.Properties.Resources.icons8_agregar_administrador_32;
            this.btnAgregarPromedio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarPromedio.Location = new System.Drawing.Point(30, 19);
            this.btnAgregarPromedio.Name = "btnAgregarPromedio";
            this.btnAgregarPromedio.Size = new System.Drawing.Size(126, 69);
            this.btnAgregarPromedio.TabIndex = 2;
            this.btnAgregarPromedio.Text = "Agregar Promedio";
            this.btnAgregarPromedio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlpAyuda.SetToolTip(this.btnAgregarPromedio, "Gazenbo gazenbo GAZENBOOOOO");
            this.btnAgregarPromedio.UseVisualStyleBackColor = true;
            this.btnAgregarPromedio.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Image = global::sistema_de_niotas_itr.Properties.Resources.icons8_símbolo_vaciar_48;
            this.btnNuevoRegistro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevoRegistro.Location = new System.Drawing.Point(30, 94);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(126, 71);
            this.btnNuevoRegistro.TabIndex = 3;
            this.btnNuevoRegistro.Text = "Nuevo Registro";
            this.btnNuevoRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::sistema_de_niotas_itr.Properties.Resources.icons8_x_32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(30, 171);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 61);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema_de_niotas_itr.Properties.Resources.icons8_usuario_48;
            this.pictureBox1.Location = new System.Drawing.Point(338, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tlpAyuda
            // 
            this.tlpAyuda.IsBalloon = true;
            this.tlpAyuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tlpAyuda.ToolTipTitle = "Mensaje de Ayuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbPromedio);
            this.Controls.Add(this.gbRegistroNotas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Academia Gazebo";
            this.gbRegistroNotas.ResumeLayout(false);
            this.gbRegistroNotas.PerformLayout();
            this.gbPromedio.ResumeLayout(false);
            this.gbPromedio.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistroNotas;
        private System.Windows.Forms.GroupBox gbPromedio;
        private System.Windows.Forms.Button btnAgregarPromedio;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.Label lblPromedioObtenido;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tlpAyuda;
    }
}


namespace frmReseñaAnalisis
{
    partial class frmRseñaAnalisis
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
            this.grpanalisis = new System.Windows.Forms.GroupBox();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblValoracion = new System.Windows.Forms.Label();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.nudwValor = new System.Windows.Forms.NumericUpDown();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpanalisis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudwValor)).BeginInit();
            this.SuspendLayout();
            // 
            // grpanalisis
            // 
            this.grpanalisis.Controls.Add(this.txtComentarios);
            this.grpanalisis.Controls.Add(this.nudwValor);
            this.grpanalisis.Controls.Add(this.txtCorreo);
            this.grpanalisis.Controls.Add(this.txtNombre);
            this.grpanalisis.Controls.Add(this.lblComentarios);
            this.grpanalisis.Controls.Add(this.lblValoracion);
            this.grpanalisis.Controls.Add(this.lblCorreo);
            this.grpanalisis.Controls.Add(this.lblNombre);
            this.grpanalisis.Controls.Add(this.lstProductos);
            this.grpanalisis.Location = new System.Drawing.Point(12, 37);
            this.grpanalisis.Name = "grpanalisis";
            this.grpanalisis.Size = new System.Drawing.Size(513, 304);
            this.grpanalisis.TabIndex = 0;
            this.grpanalisis.TabStop = false;
            this.grpanalisis.Text = "Seleccione producto y realice análisis";
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(17, 28);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(243, 264);
            this.lstProductos.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(266, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Completo:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(266, 95);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(97, 13);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "Correo Electrónico:";
            // 
            // lblValoracion
            // 
            this.lblValoracion.AutoSize = true;
            this.lblValoracion.Location = new System.Drawing.Point(266, 145);
            this.lblValoracion.Name = "lblValoracion";
            this.lblValoracion.Size = new System.Drawing.Size(57, 13);
            this.lblValoracion.TabIndex = 3;
            this.lblValoracion.Text = "Valoración";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(266, 193);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(68, 13);
            this.lblComentarios.TabIndex = 4;
            this.lblComentarios.Text = "Comentarios:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(272, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(272, 111);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(228, 20);
            this.txtCorreo.TabIndex = 6;
            // 
            // nudwValor
            // 
            this.nudwValor.Location = new System.Drawing.Point(272, 161);
            this.nudwValor.Name = "nudwValor";
            this.nudwValor.Size = new System.Drawing.Size(228, 20);
            this.nudwValor.TabIndex = 7;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(269, 209);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(228, 77);
            this.txtComentarios.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(70, 357);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(104, 38);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(359, 357);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 38);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmRseñaAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 407);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpanalisis);
            this.Name = "frmRseñaAnalisis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reseña Análisis de Productos";
            this.Load += new System.EventHandler(this.frmRseñaAnalisis_Load);
            this.grpanalisis.ResumeLayout(false);
            this.grpanalisis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudwValor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpanalisis;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.NumericUpDown nudwValor;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label lblValoracion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
    }
}


namespace BancoHRT
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.tabVerClientes = new System.Windows.Forms.TabPage();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGuardat = new System.Windows.Forms.Button();
            this.btnVerClientes = new System.Windows.Forms.Button();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            this.tabVerClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRegistro);
            this.tabControl1.Controls.Add(this.tabVerClientes);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(524, 363);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRegistro
            // 
            this.tabRegistro.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabRegistro.Controls.Add(this.btnGuardat);
            this.tabRegistro.Controls.Add(this.txtEmail);
            this.tabRegistro.Controls.Add(this.txtDireccion);
            this.tabRegistro.Controls.Add(this.txtNombre);
            this.tabRegistro.Controls.Add(this.lblEmail);
            this.tabRegistro.Controls.Add(this.lblDireccion);
            this.tabRegistro.Controls.Add(this.lblNombre);
            this.tabRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(516, 337);
            this.tabRegistro.TabIndex = 0;
            this.tabRegistro.Text = "Registro";
            // 
            // tabVerClientes
            // 
            this.tabVerClientes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabVerClientes.Controls.Add(this.rtbMostrar);
            this.tabVerClientes.Controls.Add(this.btnVerClientes);
            this.tabVerClientes.Location = new System.Drawing.Point(4, 22);
            this.tabVerClientes.Name = "tabVerClientes";
            this.tabVerClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerClientes.Size = new System.Drawing.Size(516, 337);
            this.tabVerClientes.TabIndex = 1;
            this.tabVerClientes.Text = "Ver Clientes";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(23, 50);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 79);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(85, 46);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 74);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // btnGuardat
            // 
            this.btnGuardat.Location = new System.Drawing.Point(26, 111);
            this.btnGuardat.Name = "btnGuardat";
            this.btnGuardat.Size = new System.Drawing.Size(159, 23);
            this.btnGuardat.TabIndex = 6;
            this.btnGuardat.Text = "Guardar";
            this.btnGuardat.UseVisualStyleBackColor = true;
            this.btnGuardat.Click += new System.EventHandler(this.btnGuardat_Click);
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.Location = new System.Drawing.Point(19, 22);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Size = new System.Drawing.Size(92, 21);
            this.btnVerClientes.TabIndex = 0;
            this.btnVerClientes.Text = "Ver Clientes";
            this.btnVerClientes.UseVisualStyleBackColor = true;
            this.btnVerClientes.Click += new System.EventHandler(this.btnVerClientes_Click);
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtbMostrar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rtbMostrar.Location = new System.Drawing.Point(132, 22);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(368, 299);
            this.rtbMostrar.TabIndex = 1;
            this.rtbMostrar.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 403);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabRegistro.ResumeLayout(false);
            this.tabRegistro.PerformLayout();
            this.tabVerClientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.TabPage tabVerClientes;
        private System.Windows.Forms.Button btnGuardat;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.RichTextBox rtbMostrar;
    }
}


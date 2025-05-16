namespace ClubDeportivo
{
    partial class FormRegistrarSocio
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
            btnRegistrarSocio = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDNI = new Label();
            txtDNI = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            SuspendLayout();
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.Location = new Point(354, 250);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(75, 23);
            btnRegistrarSocio.TabIndex = 0;
            btnRegistrarSocio.Text = "REGISTRAR";
            btnRegistrarSocio.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(130, 168);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(154, 150);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(258, 150);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(236, 168);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(379, 150);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 6;
            lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(342, 168);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(471, 150);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(448, 168);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 7;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(574, 150);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 10;
            lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(554, 168);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 9;
            // 
            // FormRegistrarSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDireccion);
            Controls.Add(txtDireccion);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblDNI);
            Controls.Add(txtDNI);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnRegistrarSocio);
            Name = "FormRegistrarSocio";
            Text = "FormRegistrarSocio";
            Load += FormRegistrarSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarSocio;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDNI;
        private TextBox txtDNI;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblDireccion;
        private TextBox txtDireccion;
    }
}

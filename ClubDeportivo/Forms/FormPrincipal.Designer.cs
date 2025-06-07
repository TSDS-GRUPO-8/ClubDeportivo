namespace ClubDeportivo
{
    partial class FormPrincipal
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
            panelNav = new Panel();
            panelAdmin = new Panel();
            label1 = new Label();
            label3 = new Label();
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            button1 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnInscri = new Button();
            btnCerrarSesion = new Button();
            label4 = new Label();
            panelContainer = new Panel();
            label2 = new Label();
            panelNav.SuspendLayout();
            panelAdmin.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.Black;
            panelNav.Controls.Add(panelAdmin);
            panelNav.Controls.Add(button6);
            panelNav.Controls.Add(button5);
            panelNav.Controls.Add(button4);
            panelNav.Controls.Add(button3);
            panelNav.Controls.Add(button2);
            panelNav.Controls.Add(btnInscri);
            panelNav.Controls.Add(btnCerrarSesion);
            panelNav.Controls.Add(label4);
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.Margin = new Padding(2, 1, 2, 1);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(215, 527);
            panelNav.TabIndex = 0;
            // 
            // panelAdmin
            // 
            panelAdmin.BackColor = Color.CornflowerBlue;
            panelAdmin.Controls.Add(label1);
            panelAdmin.Controls.Add(label3);
            panelAdmin.Controls.Add(txtContrasena);
            panelAdmin.Controls.Add(txtUsuario);
            panelAdmin.Controls.Add(button1);
            panelAdmin.Dock = DockStyle.Fill;
            panelAdmin.Location = new Point(0, 0);
            panelAdmin.Margin = new Padding(2, 1, 2, 1);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(215, 527);
            panelAdmin.TabIndex = 7;
            panelAdmin.Paint += panelAdmin_Paint;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 249);
            label1.Name = "label1";
            label1.Size = new Size(155, 24);
            label1.TabIndex = 11;
            label1.Text = "CONTRASEÑA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 178);
            label3.Name = "label3";
            label3.Size = new Size(155, 24);
            label3.TabIndex = 10;
            label3.Text = "USUARIO";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.Location = new Point(27, 284);
            txtContrasena.Margin = new Padding(2, 1, 2, 1);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(155, 23);
            txtContrasena.TabIndex = 9;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(27, 219);
            txtUsuario.Margin = new Padding(2, 1, 2, 1);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(155, 23);
            txtUsuario.TabIndex = 8;
            txtUsuario.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(27, 351);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(155, 33);
            button1.TabIndex = 7;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Navy;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(0, 271);
            button6.Margin = new Padding(2, 1, 2, 1);
            button6.Name = "button6";
            button6.Size = new Size(213, 28);
            button6.TabIndex = 15;
            button6.Text = "NO SOCIOS";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Enabled = false;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Navy;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(-2, 301);
            button5.Margin = new Padding(2, 1, 2, 1);
            button5.Name = "button5";
            button5.Size = new Size(215, 28);
            button5.TabIndex = 14;
            button5.Text = "ACTIVIDADES";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(-2, 241);
            button4.Margin = new Padding(2, 1, 2, 1);
            button4.Name = "button4";
            button4.Size = new Size(215, 28);
            button4.TabIndex = 13;
            button4.Text = "SOCIOS";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Enabled = false;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(-2, 211);
            button3.Margin = new Padding(2, 1, 2, 1);
            button3.Name = "button3";
            button3.Size = new Size(215, 28);
            button3.TabIndex = 11;
            button3.Text = "PAGO ACTIVIDAD";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(-2, 181);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(215, 28);
            button2.TabIndex = 10;
            button2.Text = "PAGOS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnInscri
            // 
            btnInscri.BackColor = Color.White;
            btnInscri.FlatAppearance.BorderSize = 0;
            btnInscri.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            btnInscri.FlatStyle = FlatStyle.Flat;
            btnInscri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInscri.Location = new Point(-2, 151);
            btnInscri.Margin = new Padding(2, 1, 2, 1);
            btnInscri.Name = "btnInscri";
            btnInscri.Size = new Size(215, 28);
            btnInscri.TabIndex = 9;
            btnInscri.Text = "NUEVO REGISTRO";
            btnInscri.UseVisualStyleBackColor = false;
            btnInscri.Click += btnInscri_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.IndianRed;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Location = new Point(42, 362);
            btnCerrarSesion.Margin = new Padding(2, 1, 2, 1);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(123, 22);
            btnCerrarSesion.TabIndex = 8;
            btnCerrarSesion.Text = "Cerra Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(193, 132);
            label4.TabIndex = 9;
            label4.Text = "CLUB DEPORTIVO";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.Black;
            panelContainer.Controls.Add(label2);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(215, 0);
            panelContainer.Margin = new Padding(2, 1, 2, 1);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(897, 527);
            panelContainer.TabIndex = 1;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // label2
            // 
            label2.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(240, 196);
            label2.Name = "label2";
            label2.Size = new Size(435, 133);
            label2.TabIndex = 8;
            label2.Text = "CLUB DEPORTIVO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 527);
            Controls.Add(panelContainer);
            Controls.Add(panelNav);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += Form1_Load;
            panelNav.ResumeLayout(false);
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion        
        private Panel panelAdmin;
        private Panel panelNav;
        private Panel panelContainer;
        private Button btnCerrarSesion;
        private Button btnInscri;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button button6;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private Button button1;
        private Label label4;
    }
}

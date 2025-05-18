namespace ClubDeportivo
{
    partial class Pago
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
            lblDatos = new Label();
            label3 = new Label();
            txtDNI = new TextBox();
            cmbFormaPago = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label9 = new Label();
            btnLimpiar = new Button();
            btnPagar = new Button();
            button3 = new Button();
            txtDatos = new TextBox();
            nudMonto = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            SuspendLayout();
            // 
            // lblDatos
            // 
            lblDatos.Font = new Font("Segoe UI", 13.875F);
            lblDatos.Location = new Point(29, 163);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(187, 37);
            lblDatos.TabIndex = 0;
            lblDatos.Text = "DATOS USUARIO";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 106);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 2;
            label3.Text = "DNI :";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(88, 106);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(128, 23);
            txtDNI.TabIndex = 3;
            txtDNI.TextChanged += txtDNI_TextChanged;
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.Items.AddRange(new object[] { "EFECTIVO", "TARJETA DEBITO", "TARJETA CREDITO", "TRANSFERENCIA" });
            cmbFormaPago.Location = new Point(495, 105);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Size = new Size(121, 23);
            cmbFormaPago.TabIndex = 7;
            cmbFormaPago.SelectedIndexChanged += cmbFormaPago_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 9);
            label6.Name = "label6";
            label6.Size = new Size(359, 41);
            label6.TabIndex = 8;
            label6.Text = "NUEVO PAGO DE CUOTA";
            // 
            // label7
            // 
            label7.Location = new Point(439, 108);
            label7.Name = "label7";
            label7.Size = new Size(50, 23);
            label7.TabIndex = 9;
            label7.Text = "Forma :";
            // 
            // label8
            // 
            label8.Location = new Point(236, 109);
            label8.Name = "label8";
            label8.Size = new Size(50, 23);
            label8.TabIndex = 11;
            label8.Text = "Monto :";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(391, 194);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(246, 23);
            dateTimePicker2.TabIndex = 13;
            // 
            // label9
            // 
            label9.Location = new Point(292, 194);
            label9.Name = "label9";
            label9.Size = new Size(93, 23);
            label9.TabIndex = 14;
            label9.Text = "Fecha de Cobro :";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(360, 310);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(129, 38);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnPagar
            // 
            btnPagar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagar.Location = new Point(508, 310);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(129, 38);
            btnPagar.TabIndex = 16;
            btnPagar.Text = "REALIZAR PAGO";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(649, 19);
            button3.Name = "button3";
            button3.Size = new Size(28, 28);
            button3.TabIndex = 17;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtDatos
            // 
            txtDatos.Location = new Point(29, 194);
            txtDatos.Multiline = true;
            txtDatos.Name = "txtDatos";
            txtDatos.ReadOnly = true;
            txtDatos.Size = new Size(227, 105);
            txtDatos.TabIndex = 20;
            txtDatos.TextChanged += txtDatos_TextChanged;
            // 
            // nudMonto
            // 
            nudMonto.Location = new Point(292, 106);
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(120, 23);
            nudMonto.TabIndex = 24;
            nudMonto.ValueChanged += nudMonto_ValueChanged;
            // 
            // Pago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 384);
            Controls.Add(nudMonto);
            Controls.Add(txtDatos);
            Controls.Add(button3);
            Controls.Add(btnPagar);
            Controls.Add(btnLimpiar);
            Controls.Add(label9);
            Controls.Add(dateTimePicker2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbFormaPago);
            Controls.Add(txtDNI);
            Controls.Add(label3);
            Controls.Add(lblDatos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pago";
            Text = "Pago";
            Load += Pago_Load;
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatos;
        private Label label3;
        private TextBox txtDNI;
        private ComboBox cmbFormaPago;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker2;
        private Label label9;
        private Button btnLimpiar;
        private Button btnPagar;
        private Button button3;
        private TextBox txtDatos;
        private NumericUpDown nudMonto;
    }
}
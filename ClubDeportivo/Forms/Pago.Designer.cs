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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.875F);
            label1.Location = new Point(29, 140);
            label1.Name = "label1";
            label1.Size = new Size(104, 37);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE :";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.875F);
            label2.Location = new Point(29, 177);
            label2.Name = "label2";
            label2.Size = new Size(117, 37);
            label2.TabIndex = 1;
            label2.Text = "APELLIDO :";
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
            // textBox1
            // 
            textBox1.Location = new Point(88, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.Location = new Point(148, 148);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.Location = new Point(148, 185);
            label5.Name = "label5";
            label5.Size = new Size(108, 23);
            label5.TabIndex = 5;
            label5.Text = "label5";
            label5.Click += label5_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(29, 220);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "ESTADO del PAGO";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "EFECTIVO", "TARJETA DEBITO", "TARJETA CREDITO", "TRANSFERENCIA" });
            comboBox1.Location = new Point(516, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
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
            label7.Location = new Point(460, 109);
            label7.Name = "label7";
            label7.Size = new Size(50, 23);
            label7.TabIndex = 9;
            label7.Text = "Forma :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(360, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(82, 23);
            textBox2.TabIndex = 10;
            // 
            // label8
            // 
            label8.Location = new Point(292, 109);
            label8.Name = "label8";
            label8.Size = new Size(50, 23);
            label8.TabIndex = 11;
            label8.Text = "Monto :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(29, 256);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(391, 163);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(246, 23);
            dateTimePicker2.TabIndex = 13;
            // 
            // label9
            // 
            label9.Location = new Point(292, 163);
            label9.Name = "label9";
            label9.Size = new Size(93, 23);
            label9.TabIndex = 14;
            label9.Text = "Fecha de Cobro :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(360, 310);
            button1.Name = "button1";
            button1.Size = new Size(129, 38);
            button1.TabIndex = 15;
            button1.Text = "LIMPIAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(508, 310);
            button2.Name = "button2";
            button2.Size = new Size(129, 38);
            button2.TabIndex = 16;
            button2.Text = "REALIZAR PAGO";
            button2.UseVisualStyleBackColor = true;
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
            // Pago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 384);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pago";
            Text = "Pago";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label9;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
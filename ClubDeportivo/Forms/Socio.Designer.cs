namespace ClubDeportivo
{
    partial class Socio
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
            dgvSocios = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            SuspendLayout();
            // 
            // dgvSocios
            // 
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.AllowUserToOrderColumns = true;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(26, 76);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.Size = new Size(640, 262);
            dgvSocios.TabIndex = 0;
            dgvSocios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(638, 12);
            button1.Name = "button1";
            button1.Size = new Size(28, 28);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 58);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 2;
            label1.Text = "LISTA DE SOCIOS";
            // 
            // Socio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(700, 384);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dgvSocios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Socio";
            Text = "Socio";
            Load += Socio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSocios;
        private Button button1;
        private Label label1;
    }
}
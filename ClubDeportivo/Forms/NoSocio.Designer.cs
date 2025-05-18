namespace ClubDeportivo.Forms
{
    partial class NoSocio
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
            dgvNoSocios = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNoSocios).BeginInit();
            SuspendLayout();
            // 
            // dgvNoSocios
            // 
            dgvNoSocios.AllowUserToAddRows = false;
            dgvNoSocios.AllowUserToDeleteRows = false;
            dgvNoSocios.AllowUserToOrderColumns = true;
            dgvNoSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNoSocios.Location = new Point(12, 64);
            dgvNoSocios.Name = "dgvNoSocios";
            dgvNoSocios.ReadOnly = true;
            dgvNoSocios.Size = new Size(640, 262);
            dgvNoSocios.TabIndex = 1;
            dgvNoSocios.CellContentClick += dgvNoSocios_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 3;
            label1.Text = "LISTA DE NO SOCIOS";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(624, 8);
            button1.Name = "button1";
            button1.Size = new Size(28, 28);
            button1.TabIndex = 4;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // NoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(710, 352);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dgvNoSocios);
            Name = "NoSocio";
            Text = "NoSocio";
            Load += NoSocio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNoSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNoSocios;
        private Label label1;
        private Button button1;
    }
}
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
            ((System.ComponentModel.ISupportInitialize)dgvNoSocios).BeginInit();
            SuspendLayout();
            // 
            // dgvNoSocios
            // 
            dgvNoSocios.AllowUserToAddRows = false;
            dgvNoSocios.AllowUserToDeleteRows = false;
            dgvNoSocios.AllowUserToOrderColumns = true;
            dgvNoSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNoSocios.Location = new Point(80, 94);
            dgvNoSocios.Name = "dgvNoSocios";
            dgvNoSocios.ReadOnly = true;
            dgvNoSocios.Size = new Size(640, 262);
            dgvNoSocios.TabIndex = 1;
            dgvNoSocios.CellContentClick += dgvNoSocios_CellContentClick;
            // 
            // NoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvNoSocios);
            Name = "NoSocio";
            Text = "NoSocio";
            Load += NoSocio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNoSocios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNoSocios;
    }
}
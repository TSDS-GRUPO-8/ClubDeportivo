namespace ClubDeportivo
{
    partial class Home
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
            label2 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Showcard Gothic", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(133, 126);
            label2.Name = "label2";
            label2.Size = new Size(435, 133);
            label2.TabIndex = 9;
            label2.Text = "CLUB DEPORTIVO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(700, 384);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
    }
}
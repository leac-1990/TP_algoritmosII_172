namespace WinFormsApp3
{
    partial class frmhechopor
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
            btnvolver2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(383, 350);
            label1.TabIndex = 0;
            label1.Text = "Algoritmos y Estructura de datos II (2025)\r\n\r\nProfesor: Eduardo Ferrando\r\n\r\nTP N1\r\n\r\nAlumnos:\r\n\r\nAcevedo Leandro\r\nCingolani Sofia\r\nLuque Mauricio \r\nMendez Diego\r\nPino Liliana\r\n\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // btnvolver2
            // 
            btnvolver2.BackColor = Color.FromArgb(46, 59, 170);
            btnvolver2.FlatAppearance.BorderSize = 0;
            btnvolver2.FlatStyle = FlatStyle.Flat;
            btnvolver2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnvolver2.ForeColor = Color.White;
            btnvolver2.Location = new Point(24, 372);
            btnvolver2.Name = "btnvolver2";
            btnvolver2.Size = new Size(390, 33);
            btnvolver2.TabIndex = 2;
            btnvolver2.Text = "&Volver";
            btnvolver2.UseVisualStyleBackColor = false;
            btnvolver2.Click += btnvolver2_Click;
            // 
            // frmhechopor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 104);
            ClientSize = new Size(434, 432);
            Controls.Add(btnvolver2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmhechopor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "hechopor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnvolver2;
    }
}
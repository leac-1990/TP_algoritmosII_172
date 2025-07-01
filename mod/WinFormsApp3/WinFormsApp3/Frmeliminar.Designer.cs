namespace WinFormsApp3
{
    partial class Frmeliminar
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
            lstusuarios = new ListBox();
            btneliminar = new Button();
            lblmostrarlista = new Label();
            btnvolver2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstusuarios
            // 
            lstusuarios.Font = new Font("Segoe UI", 11.25F);
            lstusuarios.FormattingEnabled = true;
            lstusuarios.ItemHeight = 20;
            lstusuarios.Location = new Point(21, 86);
            lstusuarios.Name = "lstusuarios";
            lstusuarios.Size = new Size(402, 104);
            lstusuarios.TabIndex = 27;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(46, 59, 170);
            btneliminar.FlatAppearance.BorderSize = 0;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.ForeColor = Color.White;
            btneliminar.Location = new Point(21, 211);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(402, 33);
            btneliminar.TabIndex = 24;
            btneliminar.Text = "E&liminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click1;
            // 
            // lblmostrarlista
            // 
            lblmostrarlista.AutoSize = true;
            lblmostrarlista.Location = new Point(262, 290);
            lblmostrarlista.Name = "lblmostrarlista";
            lblmostrarlista.Size = new Size(0, 15);
            lblmostrarlista.TabIndex = 23;
            // 
            // btnvolver2
            // 
            btnvolver2.BackColor = Color.FromArgb(46, 59, 170);
            btnvolver2.FlatAppearance.BorderSize = 0;
            btnvolver2.FlatStyle = FlatStyle.Flat;
            btnvolver2.ForeColor = Color.White;
            btnvolver2.Location = new Point(21, 264);
            btnvolver2.Name = "btnvolver2";
            btnvolver2.Size = new Size(402, 33);
            btnvolver2.TabIndex = 20;
            btnvolver2.Text = "&Volver";
            btnvolver2.UseVisualStyleBackColor = false;
            btnvolver2.Click += btnvolver2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(103, 24);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 19;
            label1.Text = "Eliminar Usuarios";
            // 
            // Frmeliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 104);
            ClientSize = new Size(444, 315);
            Controls.Add(lstusuarios);
            Controls.Add(btneliminar);
            Controls.Add(lblmostrarlista);
            Controls.Add(btnvolver2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frmeliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frmeliminar";
            Load += Frmeliminar_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstusuarios;
        private Button btneliminar;
        private Label lblmostrarlista;
        private Button btnvolver2;
        private Label label1;
    }
}
namespace WinFormsApp3
{
    partial class frmAdminPrin
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
            btnagregar = new Button();
            btnmodificar = new Button();
            btneliminar = new Button();
            btnvolver3 = new Button();
            SuspendLayout();
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.FromArgb(46, 59, 170);
            btnagregar.FlatAppearance.BorderSize = 0;
            btnagregar.FlatStyle = FlatStyle.Flat;
            btnagregar.Font = new Font("Segoe UI", 9.75F);
            btnagregar.ForeColor = Color.White;
            btnagregar.Location = new Point(28, 40);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(231, 33);
            btnagregar.TabIndex = 0;
            btnagregar.Tag = "";
            btnagregar.Text = "Agregar &Usuario";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // btnmodificar
            // 
            btnmodificar.BackColor = Color.FromArgb(46, 59, 170);
            btnmodificar.FlatAppearance.BorderSize = 0;
            btnmodificar.FlatStyle = FlatStyle.Flat;
            btnmodificar.Font = new Font("Segoe UI", 9.75F);
            btnmodificar.ForeColor = Color.White;
            btnmodificar.Location = new Point(28, 99);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(231, 33);
            btnmodificar.TabIndex = 1;
            btnmodificar.Text = "&Modificar";
            btnmodificar.UseVisualStyleBackColor = false;
            btnmodificar.Click += btnmodificar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(46, 59, 170);
            btneliminar.FlatAppearance.BorderSize = 0;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.Font = new Font("Segoe UI", 9.75F);
            btneliminar.ForeColor = Color.White;
            btneliminar.Location = new Point(28, 155);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(231, 33);
            btneliminar.TabIndex = 2;
            btneliminar.Text = "&Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnvolver3
            // 
            btnvolver3.BackColor = Color.FromArgb(46, 59, 170);
            btnvolver3.FlatAppearance.BorderSize = 0;
            btnvolver3.FlatStyle = FlatStyle.Flat;
            btnvolver3.Font = new Font("Segoe UI", 9.75F);
            btnvolver3.ForeColor = Color.White;
            btnvolver3.Location = new Point(28, 211);
            btnvolver3.Name = "btnvolver3";
            btnvolver3.Size = new Size(231, 33);
            btnvolver3.TabIndex = 3;
            btnvolver3.Text = "&Volver";
            btnvolver3.UseVisualStyleBackColor = false;
            btnvolver3.Click += btnvolver3_Click;
            // 
            // frmAdminPrin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 104);
            ClientSize = new Size(288, 266);
            Controls.Add(btnvolver3);
            Controls.Add(btneliminar);
            Controls.Add(btnmodificar);
            Controls.Add(btnagregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminPrin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdminPrin";
            Load += frmAdminPrin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnagregar;
        private Button btnmodificar;
        private Button btneliminar;
        private Button btnvolver3;
    }
}
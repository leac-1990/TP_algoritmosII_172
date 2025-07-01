namespace WinFormsApp3
{
    partial class frminicio
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
            label3 = new Label();
            txtusernue = new TextBox();
            lblmostrarlista = new Label();
            btncargar = new Button();
            txtemail = new TextBox();
            txtpass = new TextBox();
            lstusuarios = new ListBox();
            cmbnivel = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(125, 24);
            label1.Name = "label1";
            label1.Size = new Size(240, 37);
            label1.TabIndex = 0;
            label1.Text = "Agregar Usuarios";
            // 
            // btnvolver2
            // 
            btnvolver2.BackColor = Color.FromArgb(46, 59, 170);
            btnvolver2.FlatAppearance.BorderSize = 0;
            btnvolver2.FlatStyle = FlatStyle.Flat;
            btnvolver2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnvolver2.ForeColor = Color.White;
            btnvolver2.Location = new Point(40, 358);
            btnvolver2.Name = "btnvolver2";
            btnvolver2.Size = new Size(390, 33);
            btnvolver2.TabIndex = 1;
            btnvolver2.Text = "&Volver";
            btnvolver2.UseVisualStyleBackColor = false;
            btnvolver2.Click += btnvolver2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(176, 83);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "Usuario";
            label3.Click += label3_Click;
            // 
            // txtusernue
            // 
            txtusernue.BackColor = Color.FromArgb(46, 59, 104);
            txtusernue.BorderStyle = BorderStyle.FixedSingle;
            txtusernue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusernue.ForeColor = Color.White;
            txtusernue.Location = new Point(176, 101);
            txtusernue.Name = "txtusernue";
            txtusernue.Size = new Size(253, 27);
            txtusernue.TabIndex = 4;
            txtusernue.KeyDown += txtusernue_KeyDown;
            // 
            // lblmostrarlista
            // 
            lblmostrarlista.AutoSize = true;
            lblmostrarlista.Location = new Point(115, 348);
            lblmostrarlista.Name = "lblmostrarlista";
            lblmostrarlista.Size = new Size(0, 15);
            lblmostrarlista.TabIndex = 5;
            // 
            // btncargar
            // 
            btncargar.BackColor = Color.FromArgb(46, 59, 170);
            btncargar.FlatAppearance.BorderSize = 0;
            btncargar.FlatStyle = FlatStyle.Flat;
            btncargar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btncargar.ForeColor = Color.White;
            btncargar.Location = new Point(38, 195);
            btncargar.Name = "btncargar";
            btncargar.Size = new Size(390, 33);
            btncargar.TabIndex = 6;
            btncargar.Text = "&Cargar";
            btncargar.UseVisualStyleBackColor = false;
            btncargar.Click += btncargar_Click;
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.FromArgb(46, 59, 104);
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.ForeColor = Color.White;
            txtemail.Location = new Point(39, 155);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(204, 27);
            txtemail.TabIndex = 7;
            txtemail.KeyDown += txtemail_KeyDown;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(46, 59, 104);
            txtpass.BorderStyle = BorderStyle.FixedSingle;
            txtpass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.ForeColor = Color.White;
            txtpass.Location = new Point(249, 155);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(181, 27);
            txtpass.TabIndex = 8;
            // 
            // lstusuarios
            // 
            lstusuarios.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstusuarios.FormattingEnabled = true;
            lstusuarios.ItemHeight = 20;
            lstusuarios.Location = new Point(39, 237);
            lstusuarios.Name = "lstusuarios";
            lstusuarios.Size = new Size(391, 104);
            lstusuarios.TabIndex = 9;
            // 
            // cmbnivel
            // 
            cmbnivel.BackColor = Color.FromArgb(46, 59, 104);
            cmbnivel.FlatStyle = FlatStyle.Flat;
            cmbnivel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbnivel.ForeColor = Color.White;
            cmbnivel.FormattingEnabled = true;
            cmbnivel.Items.AddRange(new object[] { "ADMINISTRADOR", "USUARIO" });
            cmbnivel.Location = new Point(38, 101);
            cmbnivel.Name = "cmbnivel";
            cmbnivel.Size = new Size(112, 28);
            cmbnivel.TabIndex = 10;
            cmbnivel.SelectedIndexChanged += cmbnivel_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(38, 83);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 11;
            label2.Text = "Nivel";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(39, 137);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 12;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(249, 137);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 13;
            label5.Text = "Contraseña";
            // 
            // frminicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 104);
            ClientSize = new Size(468, 411);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(cmbnivel);
            Controls.Add(lstusuarios);
            Controls.Add(txtpass);
            Controls.Add(txtemail);
            Controls.Add(btncargar);
            Controls.Add(lblmostrarlista);
            Controls.Add(txtusernue);
            Controls.Add(label3);
            Controls.Add(btnvolver2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frminicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += frminicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnvolver2;
        private Label label3;
        private TextBox txtusernue;
        private Label lblmostrarlista;
        private Button btncargar;
        private TextBox txtemail;
        private TextBox txtpass;
        private ListBox lstusuarios;
        private ComboBox cmbnivel;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}
namespace WinFormsApp3
{
    partial class frmUsuario
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
            txtpass = new TextBox();
            txtemail = new TextBox();
            btnmodificar = new Button();
            txtusernue = new TextBox();
            btnvolver2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(46, 59, 104);
            txtpass.BorderStyle = BorderStyle.FixedSingle;
            txtpass.Font = new Font("Segoe UI", 11.25F);
            txtpass.ForeColor = Color.White;
            txtpass.Location = new Point(33, 206);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(260, 27);
            txtpass.TabIndex = 24;
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.FromArgb(46, 59, 104);
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Font = new Font("Segoe UI", 11.25F);
            txtemail.ForeColor = Color.White;
            txtemail.Location = new Point(33, 149);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(260, 27);
            txtemail.TabIndex = 23;
            // 
            // btnmodificar
            // 
            btnmodificar.BackColor = Color.FromArgb(46, 59, 170);
            btnmodificar.FlatAppearance.BorderSize = 0;
            btnmodificar.FlatStyle = FlatStyle.Flat;
            btnmodificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnmodificar.ForeColor = Color.White;
            btnmodificar.Location = new Point(33, 255);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(260, 37);
            btnmodificar.TabIndex = 22;
            btnmodificar.Text = "&Modificar";
            btnmodificar.UseVisualStyleBackColor = false;
            btnmodificar.Click += btnmodificar_Click_1;
            // 
            // txtusernue
            // 
            txtusernue.BackColor = Color.FromArgb(46, 59, 104);
            txtusernue.BorderStyle = BorderStyle.FixedSingle;
            txtusernue.Font = new Font("Segoe UI", 11.25F);
            txtusernue.ForeColor = Color.White;
            txtusernue.Location = new Point(33, 88);
            txtusernue.Name = "txtusernue";
            txtusernue.Size = new Size(260, 27);
            txtusernue.TabIndex = 21;
            // 
            // btnvolver2
            // 
            btnvolver2.BackColor = Color.FromArgb(46, 59, 170);
            btnvolver2.FlatAppearance.BorderSize = 0;
            btnvolver2.FlatStyle = FlatStyle.Flat;
            btnvolver2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnvolver2.ForeColor = Color.White;
            btnvolver2.Location = new Point(33, 313);
            btnvolver2.Name = "btnvolver2";
            btnvolver2.Size = new Size(260, 33);
            btnvolver2.TabIndex = 20;
            btnvolver2.Text = "&Volver";
            btnvolver2.UseVisualStyleBackColor = false;
            btnvolver2.Click += btnvolver2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 70);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 25;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 131);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 26;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(33, 188);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 27;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(107, 19);
            label4.Name = "label4";
            label4.Size = new Size(116, 37);
            label4.TabIndex = 28;
            label4.Text = "Usuario";
            label4.Click += label4_Click;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 104);
            ClientSize = new Size(321, 371);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtpass);
            Controls.Add(txtemail);
            Controls.Add(btnmodificar);
            Controls.Add(txtusernue);
            Controls.Add(btnvolver2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUsuario";
            Load += frmUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtpass;
        private TextBox txtemail;
        private Button btnmodificar;
        private TextBox txtusernue;
        private Button btnvolver2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
namespace WinFormsApp3
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            btnacceder = new Button();
            lnkolvi = new LinkLabel();
            txtuser = new TextBox();
            txtcon = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnacceder
            // 
            btnacceder.BackColor = Color.FromArgb(46, 59, 170);
            btnacceder.FlatAppearance.BorderColor = Color.DimGray;
            btnacceder.FlatAppearance.BorderSize = 0;
            btnacceder.FlatStyle = FlatStyle.Flat;
            btnacceder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnacceder.ForeColor = Color.White;
            btnacceder.Location = new Point(30, 258);
            btnacceder.Name = "btnacceder";
            btnacceder.Size = new Size(271, 24);
            btnacceder.TabIndex = 0;
            btnacceder.Text = "&Acceder";
            btnacceder.UseVisualStyleBackColor = false;
            btnacceder.Click += btnacceder_Click;
            // 
            // lnkolvi
            // 
            lnkolvi.AutoSize = true;
            lnkolvi.LinkColor = Color.FromArgb(224, 224, 224);
            lnkolvi.Location = new Point(100, 306);
            lnkolvi.Name = "lnkolvi";
            lnkolvi.Size = new Size(136, 15);
            lnkolvi.TabIndex = 1;
            lnkolvi.TabStop = true;
            lnkolvi.Text = "Olvidaste tu contraseña?";
            lnkolvi.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.FromArgb(46, 59, 104);
            txtuser.BorderStyle = BorderStyle.FixedSingle;
            txtuser.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.ForeColor = Color.White;
            txtuser.Location = new Point(30, 143);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(271, 27);
            txtuser.TabIndex = 2;
            txtuser.KeyDown += txtuser_KeyDown;
            // 
            // txtcon
            // 
            txtcon.BackColor = Color.FromArgb(46, 59, 104);
            txtcon.BorderStyle = BorderStyle.FixedSingle;
            txtcon.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcon.ForeColor = Color.White;
            txtcon.Location = new Point(30, 203);
            txtcon.Name = "txtcon";
            txtcon.PasswordChar = '*';
            txtcon.Size = new Size(271, 27);
            txtcon.TabIndex = 3;
            txtcon.KeyDown += txtcon_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 125);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 5;
            label2.Text = "Usuario/Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 185);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(298, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 104);
            ClientSize = new Size(325, 342);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtcon);
            Controls.Add(txtuser);
            Controls.Add(lnkolvi);
            Controls.Add(btnacceder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnacceder;
        private LinkLabel lnkolvi;
        private TextBox txtuser;
        private TextBox txtcon;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
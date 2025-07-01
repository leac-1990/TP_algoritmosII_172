namespace WinFormsApp3
{
    partial class frmrecupero
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
            btnvolver = new Button();
            txtcorreo = new TextBox();
            btnenviar = new Button();
            btnvalidar = new Button();
            txtcontraseña2 = new TextBox();
            txtcontraseña = new TextBox();
            txtcodigo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 45);
            label1.Name = "label1";
            label1.Size = new Size(423, 30);
            label1.TabIndex = 0;
            label1.Text = "Ingrese su correo electronico para recibir un codigo y restablecer su contraseña\r\n\r\n";
            label1.Click += label1_Click;
            // 
            // btnvolver
            // 
            btnvolver.BackColor = Color.FromArgb(46, 59, 170);
            btnvolver.FlatAppearance.BorderSize = 0;
            btnvolver.FlatStyle = FlatStyle.Flat;
            btnvolver.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnvolver.ForeColor = Color.White;
            btnvolver.Location = new Point(12, 445);
            btnvolver.Margin = new Padding(3, 4, 3, 4);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(428, 31);
            btnvolver.TabIndex = 1;
            btnvolver.Text = "&Volver";
            btnvolver.UseVisualStyleBackColor = false;
            btnvolver.Click += button1_Click;
            // 
            // txtcorreo
            // 
            txtcorreo.BackColor = Color.FromArgb(46, 59, 104);
            txtcorreo.BorderStyle = BorderStyle.FixedSingle;
            txtcorreo.Font = new Font("Segoe UI", 11.25F);
            txtcorreo.ForeColor = Color.White;
            txtcorreo.Location = new Point(12, 79);
            txtcorreo.Margin = new Padding(3, 4, 3, 4);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(428, 27);
            txtcorreo.TabIndex = 2;
            txtcorreo.TextChanged += txtcorreo_TextChanged;
            // 
            // btnenviar
            // 
            btnenviar.BackColor = Color.FromArgb(46, 59, 170);
            btnenviar.FlatAppearance.BorderSize = 0;
            btnenviar.FlatStyle = FlatStyle.Flat;
            btnenviar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnenviar.ForeColor = Color.White;
            btnenviar.Location = new Point(12, 123);
            btnenviar.Margin = new Padding(3, 4, 3, 4);
            btnenviar.Name = "btnenviar";
            btnenviar.Size = new Size(428, 31);
            btnenviar.TabIndex = 3;
            btnenviar.Text = "E&nviar";
            btnenviar.UseVisualStyleBackColor = false;
            btnenviar.Click += btnenviar_Click;
            // 
            // btnvalidar
            // 
            btnvalidar.BackColor = Color.FromArgb(46, 59, 170);
            btnvalidar.FlatAppearance.BorderSize = 0;
            btnvalidar.FlatStyle = FlatStyle.Flat;
            btnvalidar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnvalidar.ForeColor = Color.White;
            btnvalidar.Location = new Point(12, 383);
            btnvalidar.Margin = new Padding(3, 4, 3, 4);
            btnvalidar.Name = "btnvalidar";
            btnvalidar.Size = new Size(428, 31);
            btnvalidar.TabIndex = 9;
            btnvalidar.Text = "&Cambiar";
            btnvalidar.UseVisualStyleBackColor = false;
            btnvalidar.Click += btnvalidar_Click_1;
            // 
            // txtcontraseña2
            // 
            txtcontraseña2.BackColor = Color.FromArgb(46, 59, 104);
            txtcontraseña2.BorderStyle = BorderStyle.FixedSingle;
            txtcontraseña2.Font = new Font("Segoe UI", 11.25F);
            txtcontraseña2.ForeColor = Color.White;
            txtcontraseña2.Location = new Point(12, 334);
            txtcontraseña2.Margin = new Padding(3, 4, 3, 4);
            txtcontraseña2.Name = "txtcontraseña2";
            txtcontraseña2.PasswordChar = '*';
            txtcontraseña2.Size = new Size(428, 27);
            txtcontraseña2.TabIndex = 8;
            // 
            // txtcontraseña
            // 
            txtcontraseña.BackColor = Color.FromArgb(46, 59, 104);
            txtcontraseña.BorderStyle = BorderStyle.FixedSingle;
            txtcontraseña.Font = new Font("Segoe UI", 11.25F);
            txtcontraseña.ForeColor = Color.White;
            txtcontraseña.Location = new Point(12, 256);
            txtcontraseña.Margin = new Padding(3, 4, 3, 4);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.PasswordChar = '*';
            txtcontraseña.Size = new Size(428, 27);
            txtcontraseña.TabIndex = 7;
            // 
            // txtcodigo
            // 
            txtcodigo.BackColor = Color.FromArgb(46, 59, 104);
            txtcodigo.BorderStyle = BorderStyle.FixedSingle;
            txtcodigo.Font = new Font("Segoe UI", 11.25F);
            txtcodigo.ForeColor = Color.White;
            txtcodigo.Location = new Point(12, 197);
            txtcodigo.Margin = new Padding(3, 4, 3, 4);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(428, 27);
            txtcodigo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 178);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 10;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 237);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 11;
            label3.Text = "Nueva contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 304);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 12;
            label4.Text = "Confirma contraseña";
            // 
            // frmrecupero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 104);
            ClientSize = new Size(459, 513);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnvalidar);
            Controls.Add(txtcontraseña2);
            Controls.Add(txtcontraseña);
            Controls.Add(txtcodigo);
            Controls.Add(btnenviar);
            Controls.Add(txtcorreo);
            Controls.Add(btnvolver);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmrecupero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "recupero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnvolver;
        private Button btnenviar;
        private Button btnvalidar;
        private TextBox txtcontraseña2;
        private TextBox txtcontraseña;
        private TextBox txtcodigo;
        private TextBox txtcorreo;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
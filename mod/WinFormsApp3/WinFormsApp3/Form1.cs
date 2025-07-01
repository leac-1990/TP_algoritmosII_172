using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp3;


namespace WinFormsApp3
{
    public partial class frmlogin : Form
    {
        private List<Usuario> listaUsuarios = new List<Usuario>();

        public frmlogin()
        {

            InitializeComponent();
            CargarUsuarios();
            txtuser.KeyDown += txtuser_KeyDown;
            txtcon.KeyDown += txtcon_KeyDown;

        }

        private void CargarUsuarios()
        {
            string ruta = "usuarios.json";
            if (File.Exists(ruta))
            {
                string json = File.ReadAllText(ruta);
                listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(json);
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmrecupero frmrecupero = new frmrecupero();
            this.Hide();
            frmrecupero.Show();
            //frmAdminPrin admin = new frmAdminPrin();
            //admin.Show();
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtuser.Text.Trim();
            string contrasenaIngresada = txtcon.Text;

            Usuario usuarioValido = listaUsuarios.Find(u =>
                (u.Nombre.Equals(usuarioIngresado, StringComparison.OrdinalIgnoreCase) ||
                 u.Email.Equals(usuarioIngresado, StringComparison.OrdinalIgnoreCase)) &&
                u.Contraseña == contrasenaIngresada);

            if (usuarioValido != null)
            {

                Form siguienteForm;

                if (usuarioValido.Nivel == "Administrador")
                {
                    siguienteForm = new frmAdminPrin();
                }
                else
                {
                    siguienteForm = new frmUsuario(usuarioValido);
                }

                siguienteForm.FormClosed += (s, args) => this.Close();

                siguienteForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario/mail o contraseña incorrectos",
                                "Error de inicio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtcon.Focus();
            }
        }

        private void txtcon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnacceder.PerformClick();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmhechopor frmhechopor = new frmhechopor();
            frmhechopor.FormClosed += (s, args) => this.Close(); 
            frmhechopor.Show(); 
            this.Hide(); 
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using WinFormsApp3;

namespace WinFormsApp3
{
    public partial class frminicio : Form
    {
        List<Usuario> listaUsuarios = new List<Usuario>();
        int contadorUsuarios = 1;


        private void frminicio_Load(object sender, EventArgs e)
        {
            cmbnivel.Items.Clear();
            cmbnivel.Items.Add("Usuario");
            cmbnivel.Items.Add("Administrador");
            cmbnivel.SelectedIndex = 0;

            if (File.Exists("usuarios.json"))
            {
                string json = File.ReadAllText("usuarios.json");
                listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(json);

                if (listaUsuarios.Count > 0)
                    contadorUsuarios = listaUsuarios.Max(u => u.Codigo) + 1;

                lstusuarios.Items.Clear();
                foreach (Usuario u in listaUsuarios)
                {
                    string contraseñaOculta = new string('*', u.Contraseña.Length);
                    lstusuarios.Items.Add($"{u.Codigo} - {u.Nombre} - {u.Email} - {contraseñaOculta}");

                }
            }
        }

        public frminicio()
        {
            InitializeComponent();
            txtusernue.KeyDown += TextBox_KeyDown;
            txtemail.KeyDown += TextBox_KeyDown;
            txtpass.KeyDown += TextBox_KeyDown;
        }

        private void btnvolver2_Click(object sender, EventArgs e)
        {
            frmAdminPrin frmAdminPrin = new frmAdminPrin();


            frmAdminPrin.FormClosed += (s, args) => this.Close();
            frmAdminPrin.Show();
            this.Hide();
        }



        private void GuardarUsuariosEnArchivo()
        {
            string json = JsonSerializer.Serialize(listaUsuarios);
            File.WriteAllText("usuarios.json", json);
        }


        private void btncargar_Click(object sender, EventArgs e)
        {
            if (txtusernue.Text == "" || txtemail.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            string nuevoNombre = txtusernue.Text.Trim();
            string nuevoEmail = txtemail.Text.Trim();

            
            if (txtpass.Text.Length < 4)
            {
                MessageBox.Show("La contraseña debe tener al menos 4 caracteres.",
                                "Contraseña inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!nuevoEmail.Contains("@") || !nuevoEmail.EndsWith(".com", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Ingrese un correo válido (debe contener '@' y terminar en '.com').",
                                "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            bool yaExiste = listaUsuarios.Any(u =>
                u.Nombre.Equals(nuevoNombre, StringComparison.OrdinalIgnoreCase) ||
                u.Email.Equals(nuevoEmail, StringComparison.OrdinalIgnoreCase));

            if (yaExiste)
            {
                MessageBox.Show("Ya existe un usuario con ese nombre o correo electrónico.",
                                "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            Usuario nuevoUsuario = new Usuario()
            {
                Codigo = contadorUsuarios,
                Nombre = nuevoNombre,
                Email = nuevoEmail,
                Contraseña = txtpass.Text,
                Nivel = cmbnivel.SelectedItem?.ToString() ?? "Usuario"
            };

            contadorUsuarios++;
            listaUsuarios.Add(nuevoUsuario);
            GuardarUsuariosEnArchivo();
            MessageBox.Show("Usuario agregado correctamente");

            
            lstusuarios.Items.Clear();
            foreach (Usuario u in listaUsuarios)
            {
                string contraseñaOculta = new string('*', u.Contraseña.Length);
                lstusuarios.Items.Add($"{u.Codigo} - {u.Nombre} - {u.Email} - {contraseñaOculta} - {u.Nivel}");
            }

            
            txtusernue.Text = "";
            txtemail.Text = "";
            txtpass.Text = "";
            cmbnivel.SelectedIndex = 0;

        }

        private void cmbnivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtusernue_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (sender == txtusernue)
                {
                    txtemail.Focus();
                }
                else if (sender == txtemail)
                {
                    txtpass.Focus();
                }
                else if (sender == txtpass)
                {
                    btncargar.Focus();  
                }
            }
        }
    }
}

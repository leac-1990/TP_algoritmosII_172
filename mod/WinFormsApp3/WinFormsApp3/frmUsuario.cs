using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using WinFormsApp3;

namespace WinFormsApp3
{
    public partial class frmUsuario : Form
    {
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private Usuario usuarioActual;

        private const string RutaArchivo = "usuarios.json";

        JsonSerializerOptions opciones = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        public frmUsuario(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            txtusernue.KeyDown += TextBox_KeyDown;
            txtemail.KeyDown += TextBox_KeyDown;
            txtpass.KeyDown += TextBox_KeyDown;

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            if (File.Exists(RutaArchivo))
            {
                try
                {
                    string json = File.ReadAllText(RutaArchivo);
                    listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(json, opciones)
                                    ?? new List<Usuario>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer datos: {ex.Message}");
                    listaUsuarios = new List<Usuario>();
                }
            }

            txtusernue.Text = usuarioActual.Nombre;
            txtemail.Text = usuarioActual.Email;
            txtpass.Text = usuarioActual.Contraseña;
        }

        private void btnmodificar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtusernue.Text) ||
         string.IsNullOrWhiteSpace(txtemail.Text) ||
         string.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            var usuarioExistente = listaUsuarios.FirstOrDefault(u => u.Codigo == usuarioActual.Codigo);

            if (usuarioExistente != null)
            {
                usuarioExistente.Nombre = txtusernue.Text.Trim();
                usuarioExistente.Email = txtemail.Text.Trim();
                usuarioExistente.Contraseña = txtpass.Text;

                GuardarUsuariosEnArchivo();

                MessageBox.Show("Datos actualizados correctamente.");
            }
            else
            {
                MessageBox.Show("Error: usuario no encontrado.");
            }
        }

        private void GuardarUsuariosEnArchivo()
        {
            try
            {
                string json = JsonSerializer.Serialize(listaUsuarios, opciones);
                File.WriteAllText(RutaArchivo, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar datos: {ex.Message}");
            }
        }

        private void btnvolver2_Click(object sender, EventArgs e)
        {
            frmlogin frmlogin = new frmlogin();
            this.Hide();
            frmlogin.Show();
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
                    btnmodificar.Focus();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using WinFormsApp3;

namespace WinFormsApp3
{
    public partial class Frmmodificar : Form
    {
        List<Usuario> listaUsuarios = new List<Usuario>();

        public Frmmodificar()
        {
            InitializeComponent();
            lstusuarios.SelectedIndexChanged += lstusuarios_SelectedIndexChanged;
            txtusernue.KeyDown += TextBox_KeyDown;
            txtemail.KeyDown += TextBox_KeyDown;
            txtpass.KeyDown += TextBox_KeyDown;
        }

        private void Frmmodificar_Load(object sender, EventArgs e)
        {
            if (File.Exists("usuarios.json"))
            {
                string json = File.ReadAllText("usuarios.json");
                listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(json);

                RefrescarListaUsuarios();
            }
        }

        private void RefrescarListaUsuarios()
        {
            lstusuarios.Items.Clear();
            foreach (Usuario u in listaUsuarios)
            {
                string contraseñaOculta = new string('*', u.Contraseña?.Length ?? 0);
                string nivel = string.IsNullOrEmpty(u.Nivel) ? "Sin nivel" : u.Nivel;
                lstusuarios.Items.Add($"{u.Codigo} - {u.Nombre} - {u.Email} - {contraseñaOculta} - {nivel}");
            }
        }

        private void lstusuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = lstusuarios.SelectedIndex;
            if (indice >= 0)
            {
                Usuario usuario = listaUsuarios[indice];
                txtusernue.Text = usuario.Nombre;
                txtemail.Text = usuario.Email;
                txtpass.Text = usuario.Contraseña;
                cmbnivel.SelectedItem = usuario.Nivel;
            }
        }

        

        private void GuardarUsuariosEnArchivo()
        {
            string json = JsonSerializer.Serialize(listaUsuarios);
            File.WriteAllText("usuarios.json", json);
        }

       

        private void btnvolver2_Click(object sender, EventArgs e)
        {
            frmAdminPrin frmAdminPrin = new frmAdminPrin();

            
            frmAdminPrin.FormClosed += (s, args) => this.Close();

            frmAdminPrin.Show();
            this.Hide(); 
        }

        private void btnmodificar_Click_1(object sender, EventArgs e)
        {
            int indice = lstusuarios.SelectedIndex;
            if (indice == -1)
            {
                MessageBox.Show("Seleccione un usuario para modificar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtusernue.Text) ||
                string.IsNullOrWhiteSpace(txtemail.Text) ||
                string.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (cmbnivel.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un nivel de permisos.");
                return;
            }

            Usuario usuario = listaUsuarios[indice];
            usuario.Nombre = txtusernue.Text;
            usuario.Email = txtemail.Text;
            usuario.Contraseña = txtpass.Text;
            usuario.Nivel = cmbnivel.SelectedItem.ToString(); 

            GuardarUsuariosEnArchivo();
            RefrescarListaUsuarios();

            MessageBox.Show("Usuario modificado correctamente.");

            lstusuarios.ClearSelected();
            txtusernue.Clear();
            txtemail.Clear();
            txtpass.Clear();
            cmbnivel.SelectedIndex = -1;
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

    }
}

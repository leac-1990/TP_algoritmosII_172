using System.Text.Json;
using WinFormsApp3;

namespace WinFormsApp3
{
    public partial class Frmeliminar : Form
    {
        List<Usuario> listaUsuarios = new List<Usuario>();

        public Frmeliminar()
        {
            InitializeComponent();
            lstusuarios.SelectedIndexChanged += lstusuarios_SelectedIndexChanged;
        }

        private void Frmeliminar_Load_1(object sender, EventArgs e)
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

        private void GuardarUsuariosEnArchivo()
        {
            string json = JsonSerializer.Serialize(listaUsuarios);
            File.WriteAllText("usuarios.json", json);
        }

       

        private void btneliminar_Click1(object sender, EventArgs e)
        {
            int indice = lstusuarios.SelectedIndex;
            if (indice == -1)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea eliminar este usuario?",
                                                        "Confirmar eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                listaUsuarios.RemoveAt(indice);
                GuardarUsuariosEnArchivo();
                RefrescarListaUsuarios();
                MessageBox.Show("Usuario eliminado correctamente.");
            }
        }

        private void lstusuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnvolver2_Click_1(object sender, EventArgs e)
        {
            frmAdminPrin frmAdminPrin = new frmAdminPrin();

            
            frmAdminPrin.FormClosed += (s, args) => this.Close();

            frmAdminPrin.Show();
            this.Hide(); 
        }




    }
}
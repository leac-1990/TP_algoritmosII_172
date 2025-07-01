using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp3;


namespace WinFormsApp3
{
    public partial class frmrecupero : Form
    {
        public frmrecupero()
        {
            InitializeComponent();
            txtcodigo.KeyDown += TextBox_KeyDown;
            txtcontraseña.KeyDown += TextBox_KeyDown;
            txtcontraseña2.KeyDown += TextBox_KeyDown;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmlogin frmlogin = new frmlogin();
            this.Hide();
            frmlogin.Show();
        }


        private List<Usuario> listaUsuarios = new List<Usuario>();
        private Dictionary<string, int> codigosTemporales = new Dictionary<string, int>();
        private void btnenviar_Click(object sender, EventArgs e)
        {
            string correoIngresado = txtcorreo.Text.Trim();
            CargarUsuarios();

            Usuario usuario = listaUsuarios.FirstOrDefault(u => u.Email.Equals(correoIngresado, StringComparison.OrdinalIgnoreCase));

            if (usuario != null)
            {
                int codigoRecupero = new Random().Next(100000, 999999); 

                
                codigosTemporales[usuario.Email] = codigoRecupero;

                EnviarCorreo(usuario.Email, codigoRecupero.ToString());

                MessageBox.Show("Se envió un código a tu correo.");
            }
            else
            {
                MessageBox.Show("Correo no encontrado.");
            }
        }

        private void EnviarCorreo(string destinatario, string codigo)
        {
            try
            {
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress("tp172.2025@gmail.com");
                mensaje.To.Add(destinatario);
                mensaje.Subject = "Código de recuperación";
                mensaje.Body = $"Tu código para recuperar la contraseña es: {codigo}";

                SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                cliente.Credentials = new NetworkCredential("tp172.2025@gmail.com", "bbqy vnee hmin pubm");
                cliente.EnableSsl = true;

                cliente.Send(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }
        }

        private void CargarUsuarios()
        {
            if (File.Exists("usuarios.json"))
            {
                string json = File.ReadAllText("usuarios.json");
                listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(json);
            }
        }

        private void GuardarUsuarios()
        {
            string json = JsonSerializer.Serialize(listaUsuarios, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("usuarios.json", json);
        }

        private void btnvalidar_Click_1(object sender, EventArgs e)
        {
            string correo = txtcorreo.Text.Trim();
            string codigoIngresado = txtcodigo.Text.Trim();
            string nueva = txtcontraseña.Text;
            string repetir = txtcontraseña2.Text;

            CargarUsuarios();

            if (int.TryParse(codigoIngresado, out int codigoInt))
            {
                
                if (codigosTemporales.ContainsKey(correo) && codigosTemporales[correo] == codigoInt)
                {
                    Usuario usuario = listaUsuarios.FirstOrDefault(u => u.Email == correo);

                    if (usuario != null)
                    {
                        if (nueva == repetir && nueva.Length >= 4)
                        {
                            usuario.Contraseña = nueva;
                            codigosTemporales.Remove(correo);
                            GuardarUsuarios();

                            MessageBox.Show("Contraseña cambiada correctamente.");
                            this.Hide();
                            new frmlogin().Show();
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas no coinciden o son muy cortas.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Código incorrecto o correo no válido.");
                }
            }
            else
            {
                MessageBox.Show("El código debe ser un número.");
            }

            txtcorreo.Clear();
            txtcodigo.Clear();
            txtcontraseña.Clear();
            txtcontraseña2.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (sender == txtcodigo)
                {
                    txtcontraseña.Focus();
                }
                else if (sender == txtcontraseña)
                {
                    txtcontraseña2.Focus();
                }
                else if (sender == txtcontraseña2)
                {
                    btnvalidar.Focus(); 
                }
            }
        }
    }
}

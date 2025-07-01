using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp3;

namespace WinFormsApp3
{
    public partial class frmAdminPrin : Form
    {
        public frmAdminPrin()
        {
            InitializeComponent();
        }

        private void btnvolver3_Click(object sender, EventArgs e)
        {
            frmlogin frmlogin = new frmlogin();
            frmlogin.FormClosed += (s, args) => this.Close();
            frmlogin.Show();
            this.Hide();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            frminicio frminicio = new frminicio();
            frminicio.FormClosed += (s, args) => this.Close();
            frminicio.Show();
            this.Hide();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Frmmodificar frmmodificar = new Frmmodificar();
            frmmodificar.FormClosed += (s, args) => this.Close();
            frmmodificar.Show();
            this.Hide();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Frmeliminar frmeliminar = new Frmeliminar();
            frmeliminar.FormClosed += (s, args) => this.Close();
            frmeliminar.Show();
            this.Hide();
        }

        private void frmAdminPrin_Load(object sender, EventArgs e)
        {

        }
    }
}

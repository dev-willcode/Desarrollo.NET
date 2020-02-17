using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Seguridad;
using Lógica.Seguridad;

namespace Presentación.Seguridad
{
    public partial class Login : Form
    {
        UsuarioLN UsuarioLN = new UsuarioLN();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pwd = txtContrasenia.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Ingrese su usuario y contraseña!");
            }
            else
            {
                try
                {
                    Usuario usuario = UsuarioLN.IniciarSesion(user, pwd);
                    if (usuario != null)
                    {
                        Hide();
                        frmPrincipal principal = new frmPrincipal();
                        principal.Show();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al iniciar sesión", ex.Message);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://F:\\Desarrollo Escritorio\\.NET\\Desarrollo.NET\\Proyectos de Ejemplo\\SistemaInventario\\Presentación\\Ayuda\\ayuda.chm");
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.F1))
            {
                Help.ShowHelp(this, "file://F:\\Desarrollo Escritorio\\.NET\\Desarrollo.NET\\Proyectos de Ejemplo\\SistemaInventario\\Presentación\\Ayuda\\ayuda.chm");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicación_ETL
{
    public class Usuario {

        public Usuario (string nombre, string clave)
        {
            Nombre = nombre;
            Clave = clave;
        }
        public string Nombre { get; private set; }
        public string Clave { get; private set; }
    }
    public partial class Form1 : Form
    {
        public List<Font> EstilosFuentes { get; set; }
        public List<Usuario> usuarios;
        public string Usuario { get; private set; }
        public string Clave { get; private set; }
        public Form1()
        {
            InitializeComponent();
            usuarios = new List<Usuario>() { new Usuario("patrick", "12345678") };
            txtUsuario.Text = "Ingrese su usuario";
            txtClave.Text = "Ingrese su clave";
            txtUsuario.Font = new Font("Arial", 16.5f, FontStyle.Italic);
            txtClave.Font = new Font("Arial", 16.5f, FontStyle.Italic);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.Font = new Font("Arial", 16.5f, FontStyle.Bold);
            Usuario = txtUsuario.Text.ToLower();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            txtClave.Font = new Font("Arial", 16.5f, FontStyle.Bold);
            Clave = txtClave.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           if(Usuario == string.Empty && Clave == string.Empty)
           {
               MessageBox.Show("Ingrese un usuario o contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
            else
            {
                foreach (Usuario us in usuarios)
                {
                    if (Usuario == us.Nombre && Clave == us.Clave)
                    {
                        MessageBox.Show("Inicio de sesión correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Usuario o clave incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

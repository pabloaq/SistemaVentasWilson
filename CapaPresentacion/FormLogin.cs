using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormLogin : Form
    {
        private string usuario = "admin";
        private string contrasenia = "admin";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "CONTRASEÑA")
            {
                txtContrasenia.Text = "";
                txtContrasenia.ForeColor = Color.White;
                txtContrasenia.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "")
            {
                txtContrasenia.Text = "CONTRASEÑA";
                txtContrasenia.ForeColor = Color.White;
                txtContrasenia.UseSystemPasswordChar = false;
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == usuario && txtContrasenia.Text == contrasenia)
            {

            } 
            else
            {
                if(txtUsuario.Text != usuario && txtContrasenia.Text != contrasenia)
                {
                    MessageBox.Show("Usuario y Contraseña incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtUsuario.Text != usuario)
                        MessageBox.Show("Usuario incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Contraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumexamples
{
    public partial class formularioprincipal : Form
    {
        public formularioprincipal()
        {
            InitializeComponent();
        }
        
        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (txtusuario.Text != "USUARIO" && txtusuario.TextLength > 2)
            {
                if (txtcontrasena.Text != "PASSWORD")
                {
                        Dominio dom = new Dominio();
                        var validologin = dom.loginusuario(txtusuario.Text, txtcontrasena.Text);
                        if (validologin == true)
                        {
                        if ( Clasecache.Iniciodesessioncache.Estatususuario == Roles.Estadousuario.Activo)
                        {
                            Formviembenida D = new Formviembenida();
                            D.Show();
                            D.FormClosed += Cerrarsesion;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("  Al parecer no tiene permiso para entrar");
                        }
                        }
                        else Msgerror("Usuario o contraseña incorrectos.\n por favor intente de nuevo");
                        txtcontrasena.Text = "PASSWORD";
                        txtusuario.Focus();
                   
                }
                else Msgerror("porfavor introdusca la contraseña.");
            }
            else Msgerror("Por favor introdusca su nombre de usuario. ");

            
        }

        private void Msgerror(string msg)
        {
            lblmsg.Text = "   " + msg;
            lblmsg.Visible = true;
        }

        private void Cerrarsesion(object sender, FormClosedEventArgs e)
        {
            txtcontrasena.Clear();
            txtusuario.Clear();
            lblmsg.Visible = false;
            this.Show();
            txtusuario.Focus();
        }

    }


  


}

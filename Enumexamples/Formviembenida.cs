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
    public partial class Formviembenida : Form
    {
        Permisos per = new Permisos();
        public Formviembenida()
        {
            InitializeComponent();
        }

        private void Formviembenida_Load(object sender, EventArgs e)
        {
            Metodoseguro();
            cargardatosuser();
            Dominio dom = new Dominio();
            dom.obtenerrol();

        }

        private void cargardatosuser()
        {
            lblrol.Text = Clasecache.Iniciodesessioncache.Estatusmod.ToString();
            lblnombrecom.Text = Clasecache.Iniciodesessioncache.nombrecompleto;
            lblnombreusu.Text = Clasecache.Iniciodesessioncache.nombreusuario;
            lblstatususu.Text = Clasecache.Iniciodesessioncache.Idrol.ToString();

        }


        public void Metodoseguro()
        {
            if (Clasecache.Iniciodesessioncache.Idrol == Roles.cargos.Administrador )
            {
                tsbinventario.Enabled = false;
              
             
            }

            if (Clasecache.Iniciodesessioncache.Estatusmod == Roles.Estadousuario.Inactivo)
            {

                per.Permisosadmin(tsbusuarios);
                tsbAdministrar.Enabled = false;
                tsbconsulta.Enabled = false;

            }

            if (Clasecache.Iniciodesessioncache.Idrol == Roles.cargos.DB)
            {

                //per.Permisosadmin(tsbusuarios);
                /// tsbAdministrar.Enabled = false;
                //tsbconsulta.Enabled = false;

            }


        }




    }

   
}

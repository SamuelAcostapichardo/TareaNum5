using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            // Metodoseguro();
            cargardatosuser();
            Dominio dom = new Dominio();
            dom.obtenerrol();
            //pruebaTool();

            claseroles n = new claseroles();
            List<ToolStripMenuItem> MyItems = ObtenerOPciones(this.menuStrip1);
            foreach (var item in MyItems)
            {

                //item.Enabled = false;
                item.Enabled = n.validarOpcion(Clasecache.Iniciodesessioncache.Idrol, item.Name);

            }


        }

        private void cargardatosuser()
        {
            lblrol.Text = Clasecache.Iniciodesessioncache.Idrol.ToString();
            lblnombrecom.Text = Clasecache.Iniciodesessioncache.nombrecompleto;
            lblnombreusu.Text = Clasecache.Iniciodesessioncache.nombreusuario;
            lblstatususu.Text = Clasecache.Iniciodesessioncache.codigousuario.ToString();

        }

        public static List<ToolStripMenuItem> ObtenerOPciones(MenuStrip menuStrip)
        {
            List<ToolStripMenuItem> MyItem = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem i in menuStrip.Items)
            {
                 //MessageBox.Show(i.Name);

                //claseroles n = new claseroles();
                //foreach (ToolStripMenuItem item in i.DropDownItems)
                //{



                //}
                obteneritemtol(i,MyItem);

            }

            return MyItem;


        }


        private static void obteneritemtol(ToolStripMenuItem item, List<ToolStripMenuItem> items)
        {

            items.Add(item);
            foreach (ToolStripMenuItem i in item.DropDownItems)
            {

                if (i is ToolStripMenuItem)
                {
                    obteneritemtol((ToolStripMenuItem)i, items);
                }

            }
        }



        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //claseroles n = new claseroles();
            //List<ToolStripMenuItem> MyItems = ObtenerOPciones(this.menuStrip1);
            //foreach (var item in MyItems)
            //{

            //    //item.Enabled = false;
            //    item.Enabled = n.validarOpcion(Clasecache.Iniciodesessioncache.Idrol,item.Name );
               
            //}


        }



        //public void Metodoseguro()
        //{
        //    if (Clasecache.Iniciodesessioncache.Idrol == Roles.cargos.Administrador )
        //    {
        //        mnuinventario.Enabled = false;


        //    }

        //    if (Clasecache.Iniciodesessioncache.Estatusmod == Roles.Estadousuario.Inactivo)
        //    {

        //        per.Permisosadmin(mnuusuarios);
        //        tsbAdministrar.Enabled = false;
        //        mnuconsulta.Enabled = false;

        //    }

        //    if (Clasecache.Iniciodesessioncache.Idrol == Roles.cargos.DB)
        //    {

        //        //per.Permisosadmin(tsbusuarios);
        //        /// tsbAdministrar.Enabled = false;
        //        //tsbconsulta.Enabled = false;

        //    }


        //}







        /* List<ToolStripMenuItem> menuItem = new List<ToolStripMenuItem>();
             foreach (ToolStripMenuItem I in menuStrip.Items)
             {
                 MessageBox.Show(menuItem.name);

             }*/

    }


}

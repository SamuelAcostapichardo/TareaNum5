using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Enumexamples
{
    class claseroles : conexion
    {
        private Clasecache poo = new Clasecache();



        public void obtenerrol()
        {
            using (var conection = Getconection())
            {
                conection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = conection;
                    command.CommandText = (" select * from Roles_usuarios where codigousuario = @codigousuario ");
                    command.Parameters.AddWithValue("@codigousuario", Clasecache.Iniciodesessioncache.codigousuario);
                    command.CommandType = CommandType.Text;
                    SqlDataReader Reader = command.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                            Clasecache.Iniciodesessioncache.Idrol = Reader.GetInt32(0);

                    }

                }

            }

        }

        public bool login(string usuario, string contrasena)
        {
            using (var conection = Getconection())
            {
                conection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conection;
                    command.CommandText = "select * from usuarios where nombreusuario = @nombreusuario and claveusuario = @claveusuario";
                    command.Parameters.AddWithValue("@nombreusuario", usuario);
                    command.Parameters.AddWithValue("@claveusuario", contrasena);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            Clasecache.Iniciodesessioncache.codigousuario = reader.GetInt32(0);
                            Clasecache.Iniciodesessioncache.nombreusuario = reader.GetString(1);
                            Clasecache.Iniciodesessioncache.Estatususuario = reader.GetString(3);
                            Clasecache.Iniciodesessioncache.nombrecompleto = reader.GetString(4);

                            //obtenerrol();
                            obtenermodul();
                            Accesoamodulo();

                        }
                        return true;

                    }
                    else

                        return false;
                }

            }
        }


        public bool logear(string usuario, string contrasena)
        {
            using (var conection = Getconection())
            {


                string Command = "select * from usuarios where nombreusuario = '" + usuario + "' and claveusuario = '" + contrasena + "'";
                DataTable reader = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(Command, conection);
                da.Fill(reader);

                if (reader.Rows.Count > 0)
                {

                    Clasecache.Iniciodesessioncache.codigousuario = int.Parse(reader.Rows[0]["codigousuario"].ToString());
                    Clasecache.Iniciodesessioncache.nombreusuario = reader.Rows[0]["nombreusuario"].ToString();
                    Clasecache.Iniciodesessioncache.Estatususuario = reader.Rows[0]["estatususuario"].ToString();

                    Clasecache.Iniciodesessioncache.nombrecompleto = reader.Rows[0]["nombrecompleto"].ToString();


                    obtenerrol();
                    obtenermodul();
                    Accesoamodulo();

                    

                    return true;
                }
                else
                    return false;


            }
        }


       /* List<ToolStripMenuItem> MyItem = ObtenerOPciones(this.menuStrip1);*/


        public static List<ToolStripMenuItem> ObtenerOPciones(MenuStrip menuStrip)
        {

            List<ToolStripMenuItem> MyItem = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem i in menuStrip.Items)
            {
                MessageBox.Show(i.Name);
                    
            }

            return MyItem;


        }





             

        public void Accesoamodulo()
        {
            using (var conection = Getconection())
            {
                conection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = conection;
                    command.CommandText = (" select * from Detalle_modulos where codigomod = @codigomod ");
                    command.Parameters.AddWithValue("@codigomod", Clasecache.Iniciodesessioncache.Codigomod);
                    command.CommandType = CommandType.Text;

                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                            Clasecache.Iniciodesessioncache.Accesoamod = Reader.GetBoolean(3);

                    }
                    
                }

            }

        }

        public void obtenermodul()
        {
            using (var conection = Getconection())
            {



                string coman = (" select * from Modulos_Roles where codigorol = '" + Clasecache.Iniciodesessioncache.Idrol + "' ");
                DataTable dt = new DataTable();
                SqlDataAdapter dr = new SqlDataAdapter(coman, conection);
                dr.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Clasecache.Iniciodesessioncache.Codigomod = int.Parse(dt.Rows[0]["codigomod"].ToString());
                   // Clasecache.Iniciodesessioncache.Estatusmod = dt.Rows[0]["estatumd"].ToString();

                }
                


            }

        }

        public bool validarOpcion( int codigorol, string nombreopcion)
        {
            using (var conection = Getconection())
            {
                conection.Open();
                string strsql = "select * from vistapermisos where codigorol = '" + codigorol + "' and subopcion like  '" + nombreopcion + "' ";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(strsql, conection);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    return bool.Parse(dt.Rows[0]["acceder"].ToString());

                }
                else
                {
                    return true;
                }
            }
        }


        public bool Verificar_Accesos(int codigorol, string nombreopcion)
        {

            using (var conection = Getconection())
            {
                String buscar = "SP_Consulta_Acceso_Opciones";
                SqlDataAdapter da = new SqlDataAdapter(buscar, conection);
                conection.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@codigorol", SqlDbType.Int).Value = codigorol;
                da.SelectCommand.Parameters.Add("@nombreopcion", SqlDbType.VarChar).Value = nombreopcion;

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    return bool.Parse(dt.Rows[0]["acceder"].ToString());
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

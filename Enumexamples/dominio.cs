using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumexamples
{
    public class Dominio
    {
        claseroles Rl = new claseroles();
        public bool loginusuario(string usuario, string contrasena)
        {
            return Rl.logear(usuario, contrasena);

        }

        claseroles R2 = new claseroles();
        public void obtenerrol ()
        {
            R2.obtenerrol();
        }

        claseroles R3 = new claseroles();
        public void obtenermodulo()
        {
            R3.obtenermodul();
        }





    }
}

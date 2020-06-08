using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumexamples
{
  public  class Permisos
    {

        public void Permisosadmin(ToolStripItem mnu)
        {

            mnu.Visible = Clasecache.Iniciodesessioncache.Accesoamod;


        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Enumexamples
{
    class conexion
    {

        private readonly string conection = ConfigurationManager.ConnectionStrings["Enumexamples.Properties.Settings.Setting"].ConnectionString;



        public SqlConnection Getconection()
        {
            return new SqlConnection(conection);
        }


    



    }
}

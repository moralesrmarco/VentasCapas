using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasCapas.Connection
{
    internal class UConnection
    {
        private static SqlConnection con = null;    

        public static SqlConnection getConnection()
        {
            try
            {
                if (con == null)
                {
                    con = new SqlConnection(ConfigurationManager.ConnectionStrings["VentasCapasConnectionString"].ConnectionString);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return con;
        }
    }
}

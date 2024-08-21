using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CiclismoDesktopPorCodigo.utils
{
    public class Helper
    {
        public static SqlConnection CrearConexion()
        {
            string connectionString = "server=.\\SQLEXPRESS; database=Ciclismo; user id=sa; password=123; multipleactiveresultsets=true; Encrypt=false";
            SqlConnection conex = new SqlConnection(connectionString);
            conex.Open();
            return conex;
        }
    }
}

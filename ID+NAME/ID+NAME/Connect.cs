using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ID_NAME
{
    class Connect
    {
        static string connectstring = "server=.; database=TableName;integrated security=true";
        public static SqlConnection connect;
        public static SqlConnection myconnect()
        {
            connect = new SqlConnection(connectstring);
            try
            {
                connect = new SqlConnection(connectstring);
                connect.Open();
            }

            catch (Exception ex)
            {

            }
            return connect;
        }
    }
}

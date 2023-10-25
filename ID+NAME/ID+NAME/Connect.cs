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
        public SqlConnection connect;
        public Connect()
        {
            
                connect = new SqlConnection(connectstring);
        }
        public Connect(string strcm)
        {
            connect = new SqlConnection(strcm);
        }
    }
}

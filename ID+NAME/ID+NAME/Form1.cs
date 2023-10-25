using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ID_NAME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sql = "select * from TableName";
            var command = new SqlCommand(sql, Connect.myconnect());
            SqlDataReader data = command.ExecuteReader();
            var Name = "";
            var ID = "";
            while (data.Read())
            {
                Name = data["name"].ToString();
                ID = data["id"].ToString();
            }
        }
    }
}

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
            connsql = kn.connect;
        }
        class Connect
        {
            static string connectstring = "server=A209PC26; database=huhu;integrated security=true";
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
        Connect kn = new Connect();
        SqlConnection connsql;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(connsql.State == ConnectionState.Closed)
                {
                    connsql.Open();
                }
                if (connsql.State == ConnectionState.Closed)
                {
                    connsql.Close();
                }
                MessageBox.Show("thanh cong");
            }
            catch(Exception ex)
            {
                MessageBox.Show("that bai");
            }
        }
    }
}

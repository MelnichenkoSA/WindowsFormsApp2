using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void getUser()
        {
            List<string> listuser = new List<string>();
            string connString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BaseData;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand usergetcmd = new SqlCommand("select * from [users]", sqlConnection);
            SqlDataReader reader = usergetcmd.ExecuteReader();
            while (reader.Read())
            {
                listuser.Add(reader.GetString(1));
            }
            listBox1.DataSource = listuser;
        }
        public void setUser()
        {
            string connString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BaseData;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand usersetcmd = new SqlCommand("insert into [users] values ('l5', 'p5')", sqlConnection);
            usersetcmd.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getUser();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            setUser();
        }
    }
}

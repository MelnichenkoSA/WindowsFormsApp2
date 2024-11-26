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
        public string sort = "ASC";
        public string filter;
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
            SqlCommand usergetcmd = new SqlCommand("select * from [users] order by login " + sort + " " , sqlConnection);
            SqlDataReader reader = usergetcmd.ExecuteReader();
            while (reader.Read())
            {
                listuser.Add(reader.GetString(1));
            }
            listBox1.DataSource = listuser;
        }
        public void getUserWithFilter()
        {
            List<string> listuser = new List<string>();
            string connString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BaseData;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand usergetcmd = new SqlCommand("select * from [users] where " + filter , sqlConnection);
            SqlDataReader reader = usergetcmd.ExecuteReader();
            while (reader.Read())
            {
                listuser.Add(reader.GetString(1));
            }
            listBox1.DataSource = listuser;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            getUser();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ToCrreateFormButton_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            createForm.Show();
        }

        private void radioButtonAscSort_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAscSort.Checked)
            {
                sort = "ASC";
            }

        }

        private void radioButtonDescSort_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDescSort.Checked)
            {
                sort = "DESC";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedIndex == 0)
            {
                filter = "login = 'l1'";
                getUserWithFilter();
            }
            else if (comboBoxFilter.SelectedIndex == 1)
            {
                filter = "pass = 'p2'";
                getUserWithFilter();
            }
            else if (comboBoxFilter.SelectedIndex == 2)
            {
                getUser();
            }      
            else
                MessageBox.Show("Ошибка");
        }
    }
}

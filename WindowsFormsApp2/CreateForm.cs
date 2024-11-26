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
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }
        public void setUser()
        {
            string connString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BaseData;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand usersetcmd = new SqlCommand("insert into [users] values ('" + textBox2.Text + "', '" + textBox1.Text + "')", sqlConnection);
            usersetcmd.ExecuteNonQuery();
        }
        public void deleteUser()
        {
            string connString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BaseData;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand usersetcmd = new SqlCommand("delete from [users] where login = '" + textBox6.Text + "'", sqlConnection);
            usersetcmd.ExecuteNonQuery();
        }
        public void updateUser()
        {
            string connString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BaseData;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand usersetcmd = new SqlCommand("update [users] set login = '" + textBox4.Text + "', pass = '" + textBox3.Text + "' where login = '" + textBox5.Text + "'", sqlConnection);
            usersetcmd.ExecuteNonQuery();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            setUser();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateUser();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Имя создаваемого юзера
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Пароль создаваемого юзера
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //имя кого редактировать
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //новое имя
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //новый пароль
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //имя на удаление
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}

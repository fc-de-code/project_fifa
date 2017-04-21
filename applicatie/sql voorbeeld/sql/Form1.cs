using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection connection;
            string server = "84.26.202.94";
            string database = "niewsletter_app";
            string uid = "root";
            string password = "anime";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    DisplayMessage.Text = "Data entered succesfully.";
                }
                else
                {
                    DisplayMessage.Text = "Database connection failed.";
                }


            }
            catch (Exception ex)
            {
                DisplayMessage.Text = "Error occured. Please try again later.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

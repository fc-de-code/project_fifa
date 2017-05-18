using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ProjectFifaV2
{
    public partial class frmLogin : Form
    {
        private DatabaseHandler dbh;
        private Form frmAdmin;
        private Form frmPlayer;
        private Form frmRanking;

        private Form test;

        public frmLogin()
        {
            InitializeComponent();
            dbh = new DatabaseHandler();
            frmAdmin = new frmAdmin();
            frmRanking = new frmRanking();
            //frmPlayer = new frmPlayer(frmRanking);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Both fields are required");
            }
            else
            {
                dbh.TestConnection();
                dbh.OpenConnectionToDB();
                bool exist = false;

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [tblUsers] WHERE Username = @Username", dbh.GetCon()))
                {
                    cmd.Parameters.AddWithValue("Username", txtUsername.Text);
                    exist = (int)cmd.ExecuteScalar() > 0;
                }

                if (exist)
                {
                    MessageHandler.ShowMessage("This user already exists.");
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO [tblUsers] ([Username], [Password], [IsAdmin]) VALUES (@Username, @Password, @IsAdmin)"))
                    {
                        cmd.Parameters.AddWithValue("Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("IsAdmin", 0);
                        cmd.Connection = dbh.GetCon();
                        cmd.ExecuteNonQuery();
                    }
                }

                dbh.CloseConnectionToDB();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                if (dbh.GetCon().State == ConnectionState.Open)
                {
                    dbh.CloseConnectionToDB();
                }
                Application.Exit();
            }
        }

        private void btnShowRanking_Click(object sender, EventArgs e)
        {
            frmRanking.Show(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dbh.TestConnection();
            dbh.OpenConnectionToDB();

            bool exist = false;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            txtUsername.Text = "";
            txtPassword.Text = "";
            try
            {
                
                if (dbh.IsConnect())
                {

                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_users WHERE Username = @Username AND Password = @Password", dbh.Connection))
                    {
                        cmd.Parameters.AddWithValue("Username", username);
                        cmd.Parameters.AddWithValue("Password", password);
                        //exist = (int)cmd.ExecuteScalar() > 0;


                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("The username and/or password is invalid.");

                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            exist = false;
                        }

                        else
                        {
                            exist = true;
                            reader.Close();
                        }


                    }
                    if (exist)
                    {
                        bool admin = false;
                        using (MySqlCommand cmd = new MySqlCommand("SELECT * from tbl_users WHERE username = @username AND isAdmin = 1", dbh.Connection))
                        {
                            cmd.Parameters.AddWithValue("username", username);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            if (!reader.HasRows)
                            {
                                admin = false;
                            }
                            else
                            {
                                admin = true;
                            }
                            reader.Close();
                            if (admin)
                            {
                                frmAdmin.Show();
                            }
                            else
                            {
                                frmPlayer = new frmPlayer(frmRanking, username);
                                frmPlayer.Show();
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            /*
            if (exist)
         {
                bool admin;
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) from [tblUsers] WHERE Username = @Username AND IsAdmin = 1", dbh.Connection))
                {
                    cmd.Parameters.AddWithValue("Username", username);
                    admin = (int)cmd.ExecuteScalar() > 0;
                }
                dbh.CloseConnectionToDB();

                if (admin)
                {
                    frmAdmin.Show();
                }
                else
                {
                    
                    test = new btnClear(frmRanking,username);
                    test.Show();

                    //caution broken
                   // frmPlayer = new frmPlayer(frmRanking, username);
                   // frmPlayer.Show();
                    //frmPlayer.Show();
                }
            }
            else
            {
                dbh.CloseConnectionToDB();
                MessageHandler.ShowMessage("Wrong username and/or password.");
            }*/
        }
    }
}

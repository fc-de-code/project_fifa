using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProjectFifaV2
{
    class DatabaseHandler
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private SqlConnection con;

        public MySqlConnection Connection
        {
            get { return connection; }
        }
        public DatabaseHandler()
        {
            //SqlCeEngine engine = new SqlCeEngine(@"Data Source=.\DB.mdf");
            //engine.Upgrade(@"Data Source=.\DB2.sf");


            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\db.mdf';Integrated Security=True;Connect Timeout=30");

            server = "jpslimmen.ddns.net";
            database = "project_fifa";
            uid = "root";
            password = "welkom1";
          
        }
        private static DatabaseHandler _instance = null;
        public static DatabaseHandler Instance()
        {
            if (_instance == null)
        
                _instance = new DatabaseHandler();
             return _instance;
           
        }

        public string GetConfig()
        {
            System.Net.WebClient client = new System.Net.WebClient();
            string htmlCode = client.DownloadString("http://jtechgame.alwaysdata.net/download/item1/upload/upload/hidden/configuration.html");
            string conn = htmlCode.Substring(105, 111);
            return conn;
        }

        public bool IsConnect()
        {
            bool result = true;
            if (connection == null || connection.State == ConnectionState.Closed)
            {
                //if (string.IsNullOrEmpty(database))
                //    result = false;
                string constring = string.Format("Server=localhost; database=project_fifa; UID=root; password=");
                connection = new MySqlConnection(constring);
                connection.Open();
                result = true;
            }
            return result;
        }
        public void Close()
        {
            connection.Close();
        }

        public DataTable select(string query,string name)
        {
            if (this.IsConnect())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable(name);
                returnVal.Fill(dt);
                return dt;

            }
            else
            {
                this.Close();
                DataTable dt = new DataTable(name);
                return dt;
            }

        }

      






































        // JP ZIJN CODE 

        public void TestConnection()
        {
            bool open = false;
            
            try
            {
                IsConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    open = true;
                }
                Close();
            }

            if (!open)
            {
                Application.Exit();
            }
        }

        public void OpenConnectionToDB()
        {
            if (connection.State == ConnectionState.Closed || connection == null)
            {
                IsConnect();
            }
        }

        public void CloseConnectionToDB()
        {
            if (connection.State == ConnectionState.Open)
                Close();
        }

        public System.Data.DataTable FillDT(string query)
        {
            TestConnection();
            OpenConnectionToDB();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, GetCon());
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            
            CloseConnectionToDB();

            return dt;
        }

        public SqlConnection GetCon()
        {
            return con;
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }




    }
}

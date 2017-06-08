using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectFifaV2
{
    public partial class frmRanking : Form
    {
        DatabaseHandler dbh;

        public frmRanking()
        {
            this.ControlBox = false;
            dbh = new DatabaseHandler();
            InitializeComponent();
            SetListColumnWidth();
            ShowResults();
            ShowRanking();
        }

        private void btnRankingBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void SetListColumnWidth()
        {
            clmRank.Width = 45;
            clmNaam.Width = 300;
            clmScore.Width = 80;
        }

        //private void ShowScore()
        //{
        //    dbh.TestConnection();
        //    dbh.OpenConnectionToDB();
        //
        //   DataTable table = dbh.FillDT("SELECT Username, Score FROM tblUsers WHERE (IsAdmin = 0) ORDER BY Score DESC");
        //
        //    for (int i = 0; i < table.Rows.Count; i++)
        //    {
        //        DataRow dataRow = table.Rows[i];
        //        ListViewItem lstItem = new ListViewItem((i + 1).ToString());
        //        lstItem.SubItems.Add(dataRow["Username"].ToString());
        //        lstItem.SubItems.Add(dataRow["Score"].ToString());
        //        lvRankingUser.Items.Add(lstItem);
        //    }
        //    dbh.CloseConnectionToDB();
        //}

        private void ShowResults()
        {
            dbh.TestConnection();
            dbh.OpenConnectionToDB();

            string qwrie = "Select Id,username,score FROM tbl_users order by score desc";

            DataTable Points = dbh.select(qwrie, "");

            for (int i = 0; i < Points.Rows.Count; i++)
            {
                DataRow dataRowHome = Points.Rows[i];

               
                ListViewItem lstItem = new ListViewItem((i+1).ToString());
                lstItem.SubItems.Add(dataRowHome["username"].ToString());
                lstItem.SubItems.Add(dataRowHome["Score"].ToString());

                lvRankingUser.Items.Add(lstItem);

                 dbh.CloseConnectionToDB();

            }
        }

        private void ShowRanking()
        {
            dbh.TestConnection();
            dbh.OpenConnectionToDB();

            //string qwrie2 = "Select * FROM tbl_teams";

            string qwrie = "Select * FROM tbl_matches order by scoren desc";

            DataTable Points = dbh.select(qwrie, "");

            for (int i = 0; i < Points.Rows.Count; i++)
            {
                DataRow dataRowHome = Points.Rows[i];


                ListViewItem lstItem = new ListViewItem((i + 2).ToString());

                lstItem.SubItems.Add(dataRowHome["id"].ToString());
                lstItem.SubItems.Add(dataRowHome["scoren"].ToString());
                lstItem.SubItems.Add(dataRowHome["saldo"].ToString());
                lstItem.SubItems.Add(dataRowHome["ranking"].ToString());


                lvRankingTeam.Items.Add(lstItem);

                dbh.CloseConnectionToDB();

            }

            

           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        

        private void lvRanking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRanking_Load(object sender, EventArgs e)
        {

        }
    }
}

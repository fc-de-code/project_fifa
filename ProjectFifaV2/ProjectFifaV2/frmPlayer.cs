using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjectFifaV2
{
    public partial class frmPlayer : Form
    {
        private Form frmRanking;
        private DatabaseHandler dbh;
        private string userName;
        private SqlConnection con;
        private DatabaseHandler database;

        List<string> combo;
        List<TextBox> txtBoxList;
        public string un;

        public frmPlayer(Form frm, string un)
        {
            this.ControlBox = false;
            frmRanking = frm;
            dbh = new DatabaseHandler();

            InitializeComponent();
            if (DisableEditButton())
            {
                btnUpdate.Enabled = false;
            }
            ShowResults();
            //ShowScoreCard();
            this.Text = "Welcome " + un;
            lblname.Text = un;
            // sql hier ophalen teamnames uit database voor
            int teamId = 0;
            this.un = un;

           


            string query = "SELECT * FROM tbl_teams";
            string teams = "teams";


            string jurriaan = "SELECT * FROM tbl_teams";

            DataTable dt = dbh.select(jurriaan,teams);
            for (int i = 0; i < dt.Rows.Count; i ++)
            {
                DataRow team = dt.Rows[i];
                comboTeam1.Items.Add(team["name"].ToString());

            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow team = dt.Rows[i];
                comboTeam2.Items.Add(team["name"].ToString());

            }












            // comboteam1
            //comboteam2
            //ophalen uit database teams tegen andere teams 
            // in lvoverview






        }
       
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnShowRanking_Click(object sender, EventArgs e)
        {
            frmRanking.Show();
        }

        private void btnClearPrediction_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear your prediction?", "Clear Predictions", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                // Clear predections
                // Update DB
            }
        }

        private bool DisableEditButton()
        {
            bool hasPassed;
            //This is the deadline for filling in the predictions
            DateTime deadline = new DateTime(2018, 06, 12);
            DateTime curTime = DateTime.Now;
            int result = DateTime.Compare(deadline, curTime);

            if (result < 0)
            {
                hasPassed = true;
            }
            else
            {
                hasPassed = false;
            }

            return hasPassed;
        }

        private void ShowResults()
        {
            dbh.TestConnection();
            dbh.OpenConnectionToDB();

            DataTable hometable = dbh.FillDT("SELECT tblTeams.TeamName, tblGames.HomeTeamScore FROM tblGames INNER JOIN tblTeams ON tblGames.HomeTeam = tblTeams.Team_ID");
            DataTable awayTable = dbh.FillDT("SELECT tblTeams.TeamName, tblGames.AwayTeamScore FROM tblGames INNER JOIN tblTeams ON tblGames.AwayTeam = tblTeams.Team_ID");

            dbh.CloseConnectionToDB();

            for (int i = 0; i < hometable.Rows.Count; i++)
            {
                DataRow dataRowHome = hometable.Rows[i];
                DataRow dataRowAway = awayTable.Rows[i];
                ListViewItem lstItem = new ListViewItem(dataRowHome["TeamName"].ToString());
                lstItem.SubItems.Add(dataRowHome["HomeTeamScore"].ToString());
                lstItem.SubItems.Add(dataRowAway["AwayTeamScore"].ToString());
                lstItem.SubItems.Add(dataRowAway["TeamName"].ToString());
                lvOverview.Items.Add(lstItem);
            }
        }

        private void ShowScoreCard()
        {
            dbh.TestConnection();
            dbh.OpenConnectionToDB();

            DataTable hometable = dbh.FillDT("SELECT tblTeams.TeamName FROM tblGames INNER JOIN tblTeams ON tblGames.HomeTeam = tblTeams.Team_ID");
            DataTable awayTable = dbh.FillDT("SELECT tblTeams.TeamName FROM tblGames INNER JOIN tblTeams ON tblGames.AwayTeam = tblTeams.Team_ID");

            dbh.CloseConnectionToDB();

            for (int i = 0; i < hometable.Rows.Count; i++)
            {
                DataRow dataRowHome = hometable.Rows[i];
                DataRow dataRowAway = awayTable.Rows[i];
                
                Label lblHomeTeam = new Label();
                Label lblAwayTeam = new Label();
                TextBox txtHomePred = new TextBox();
                TextBox txtAwayPred = new TextBox();

                lblHomeTeam.TextAlign = ContentAlignment.BottomRight;
                lblHomeTeam.Text = dataRowHome["TeamName"].ToString();
                lblHomeTeam.Location = new Point(15, txtHomePred.Bottom + (i * 30));
                lblHomeTeam.AutoSize = true;

                txtHomePred.Text = "0";
                txtHomePred.Location = new Point(lblHomeTeam.Width, lblHomeTeam.Top - 3);
                txtHomePred.Width = 40;

                txtAwayPred.Text = "0";
                txtAwayPred.Location = new Point(txtHomePred.Width + lblHomeTeam.Width, txtHomePred.Top);
                txtAwayPred.Width = 40;

                lblAwayTeam.Text = dataRowAway["TeamName"].ToString();
                lblAwayTeam.Location = new Point(txtHomePred.Width + lblHomeTeam.Width + txtAwayPred.Width, txtHomePred.Top + 3);
                lblAwayTeam.AutoSize = true;

                pnlPredCard.Controls.Add(lblHomeTeam);
                pnlPredCard.Controls.Add(txtHomePred);
                pnlPredCard.Controls.Add(txtAwayPred);
                pnlPredCard.Controls.Add(lblAwayTeam);
                //ListViewItem lstItem = new ListViewItem(dataRowHome["TeamName"].ToString());
                //lstItem.SubItems.Add(dataRowHome["HomeTeamScore"].ToString());
                //lstItem.SubItems.Add(dataRowAway["AwayTeamScore"].ToString());
                //lstItem.SubItems.Add(dataRowAway["TeamName"].ToString());
                //lvOverview.Items.Add(lstItem);
            }
        }

        internal void GetUsername(string un)
        {
            userName = un;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPlayer_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

          //int betPoint =  Convert.ToInt32(txtBet.Text);

            //join maken.

             //string query = "SELECT team1.name AS Home, team2.name AS Away, matches.score_team_a AS HomeScore, matches.score_team_b AS AwayScore FROM ((tbl_matches AS matches INNER JOIN tbl_teams AS team1 ON matches.team_id_a = team1.id) INNER JOIN tbl_teams AS team2 ON matches.team_id_b = team2.id) ORDER BY matches.id ASC";

            //DataTable dt_matchesShow;

           





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvOverview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            //sql insert bet into prediction 

            // 4 varible

            string teamName1 = comboTeam1.SelectedItem.ToString();
            string teamNaam2 = comboTeam2.SelectedItem.ToString();


            int bet1 = Convert.ToInt32(txtScoreTeam1.Text);
            int bet2 = Convert.ToInt32(txtScoreTeam2.Text);

            lbltest.Text = bet1.ToString() + bet2.ToString() ;

            /// Insuert van de test gebruiken
            
            MySqlCommand command = dbh.Connection.CreateCommand();

            command.CommandText = "INSERT INTO tbl_predictions (User_id, Game_id, PredictedTeam1Score,PredictedTeam2Score) values (1, 1, " + bet1 + ", " +bet2 + ")";

            command.ExecuteNonQuery();
        }

        private void comboTeam2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ///join van predictions en matches
            string query2 = "SELECT pred.PredictedTeam1Score AS pred1, pred.PredictedTeam2Score AS pred2 ,matches.score_team_a As scoreA, matches.score_team_b AS scoreB FROM ((tbl_predictions AS pred INNER JOIN tbl_users AS user ON user.id=pred.User_id)  INNER JOIN tbl_matches AS matches ON pred.Game_id=matches.id )";

            DataTable dt_Calculation = dbh.select(query2, "Calculation");

            ///for loop
            int score = 0;


            for (int i = 0; i < dt_Calculation.Rows.Count; i++)
            {

                DataRow dr_Calulation = dt_Calculation.Rows[i];

                ///de int van de scorens van de matches en de scorens van teams uit de matches

                int predTeam1 = Convert.ToInt32(dr_Calulation["pred1"].ToString());
                int predTeam2 = Convert.ToInt32(dr_Calulation["pred2"].ToString());
                int Team1 = Convert.ToInt32(dr_Calulation["scoreA"].ToString());
                int Team2 = Convert.ToInt32(dr_Calulation["scoreB"].ToString());




                //Dan vergelijken met if else

                if (Team1 > Team2)
                {
                    if (predTeam1 == Team1 && predTeam2 == Team2)
                    {
                        score += 2;
                    }
                    else if (predTeam1 > predTeam2)
                    {
                        score += 1;
                    }
                }
                else if (Team2 > Team1)
                {
                    if (predTeam2 == Team2 && predTeam1 == Team1)
                    {
                        score += 2;
                    }
                    else if (predTeam2 > predTeam1)
                    {
                        score += 1;
                    }
                }
                else
                {
                    if (predTeam1 == Team1 && predTeam2 == Team2)
                    {
                        score += 2;
                    }
                }
            }





            MySqlCommand command = dbh.Connection.CreateCommand();

            command.CommandText = "Update tbl_Users set score = " + score + " Where (username = '" + this.un + "')";

            command.ExecuteNonQuery();

        }

        private void pnlPredCard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

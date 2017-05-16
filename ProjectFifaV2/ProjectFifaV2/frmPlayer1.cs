using System.Windows.Forms;

namespace ProjectFifaV2
{
    internal class frmPlayer : Form
    {
        private Form frmRanking;
        private string username;

        public frmPlayer(Form frmRanking, string username)
        {
            this.frmRanking = frmRanking;
            this.username = username;
           
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPlayer
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "frmPlayer";
            this.Text = "TEEEEST";
            this.ResumeLayout(false);
            

        }
    }
}
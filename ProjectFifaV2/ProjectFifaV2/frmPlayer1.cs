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
    }
}
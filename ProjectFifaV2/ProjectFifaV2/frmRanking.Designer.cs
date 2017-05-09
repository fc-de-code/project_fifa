namespace ProjectFifaV2
{
    partial class frmRanking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoguit = new System.Windows.Forms.Button();
            this.lvRanking = new System.Windows.Forms.ListView();
            this.clmRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmTeam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmScoren = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRanking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnWedstrijd = new System.Windows.Forms.Button();
            this.btnAdmins = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoguit
            // 
            this.btnLoguit.Location = new System.Drawing.Point(476, 442);
            this.btnLoguit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoguit.Name = "btnLoguit";
            this.btnLoguit.Size = new System.Drawing.Size(112, 36);
            this.btnLoguit.TabIndex = 1;
            this.btnLoguit.Text = "Loguit";
            this.btnLoguit.UseVisualStyleBackColor = true;
            this.btnLoguit.Click += new System.EventHandler(this.btnRankingBack_Click);
            // 
            // lvRanking
            // 
            this.lvRanking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmRank,
            this.clmNaam,
            this.clmScore});
            this.lvRanking.Location = new System.Drawing.Point(669, 76);
            this.lvRanking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvRanking.Name = "lvRanking";
            this.lvRanking.Size = new System.Drawing.Size(427, 696);
            this.lvRanking.TabIndex = 2;
            this.lvRanking.UseCompatibleStateImageBehavior = false;
            this.lvRanking.View = System.Windows.Forms.View.Details;
            // 
            // clmRank
            // 
            this.clmRank.Text = "Rank";
            this.clmRank.Width = 108;
            // 
            // clmNaam
            // 
            this.clmNaam.Text = "Naam";
            this.clmNaam.Width = 137;
            // 
            // clmScore
            // 
            this.clmScore.Text = "Score";
            this.clmScore.Width = 177;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTeam,
            this.clmScoren,
            this.clmSaldo,
            this.clmRanking});
            this.listView1.Location = new System.Drawing.Point(38, 76);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 696);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmTeam
            // 
            this.clmTeam.Text = "Team";
            this.clmTeam.Width = 108;
            // 
            // clmScoren
            // 
            this.clmScoren.Text = "Scoren";
            this.clmScoren.Width = 96;
            // 
            // clmSaldo
            // 
            this.clmSaldo.Text = "Saldo";
            this.clmSaldo.Width = 99;
            // 
            // clmRanking
            // 
            this.clmRanking.Text = "Ranking";
            this.clmRanking.Width = 77;
            // 
            // btnWedstrijd
            // 
            this.btnWedstrijd.Location = new System.Drawing.Point(476, 186);
            this.btnWedstrijd.Margin = new System.Windows.Forms.Padding(4);
            this.btnWedstrijd.Name = "btnWedstrijd";
            this.btnWedstrijd.Size = new System.Drawing.Size(112, 36);
            this.btnWedstrijd.TabIndex = 4;
            this.btnWedstrijd.Text = "Wedstrijd";
            this.btnWedstrijd.UseVisualStyleBackColor = true;
            // 
            // btnAdmins
            // 
            this.btnAdmins.Location = new System.Drawing.Point(476, 319);
            this.btnAdmins.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(112, 36);
            this.btnAdmins.TabIndex = 5;
            this.btnAdmins.Text = "Admins";
            this.btnAdmins.UseVisualStyleBackColor = true;
            // 
            // frmRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 796);
            this.Controls.Add(this.btnAdmins);
            this.Controls.Add(this.btnWedstrijd);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lvRanking);
            this.Controls.Add(this.btnLoguit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRanking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoguit;
        private System.Windows.Forms.ListView lvRanking;
        private System.Windows.Forms.ColumnHeader clmRank;
        private System.Windows.Forms.ColumnHeader clmNaam;
        private System.Windows.Forms.ColumnHeader clmScore;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmTeam;
        private System.Windows.Forms.ColumnHeader clmScoren;
        private System.Windows.Forms.ColumnHeader clmSaldo;
        private System.Windows.Forms.ColumnHeader clmRanking;
        private System.Windows.Forms.Button btnWedstrijd;
        private System.Windows.Forms.Button btnAdmins;
    }
}
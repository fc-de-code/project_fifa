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
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnAdmins = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoguit
            // 
            this.btnLoguit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.btnLoguit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoguit.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoguit.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLoguit.Location = new System.Drawing.Point(535, 580);
            this.btnLoguit.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoguit.Name = "btnLoguit";
            this.btnLoguit.Size = new System.Drawing.Size(126, 47);
            this.btnLoguit.TabIndex = 1;
            this.btnLoguit.Text = "Logout";
            this.btnLoguit.UseVisualStyleBackColor = false;
            this.btnLoguit.Click += new System.EventHandler(this.btnRankingBack_Click);
            // 
            // lvRanking
            // 
            this.lvRanking.BackColor = System.Drawing.Color.Gray;
            this.lvRanking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvRanking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmRank,
            this.clmNaam,
            this.clmScore});
            this.lvRanking.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lvRanking.Location = new System.Drawing.Point(47, 78);
            this.lvRanking.Margin = new System.Windows.Forms.Padding(5);
            this.lvRanking.Name = "lvRanking";
            this.lvRanking.Size = new System.Drawing.Size(429, 912);
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
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.Gray;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTeam,
            this.clmScoren,
            this.clmSaldo,
            this.clmRanking});
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(734, 78);
            this.listView1.Margin = new System.Windows.Forms.Padding(5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(433, 912);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // btnMatch
            // 
            this.btnMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.btnMatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatch.ForeColor = System.Drawing.Color.DarkGray;
            this.btnMatch.Location = new System.Drawing.Point(535, 244);
            this.btnMatch.Margin = new System.Windows.Forms.Padding(5);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(126, 47);
            this.btnMatch.TabIndex = 4;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = false;
            // 
            // btnAdmins
            // 
            this.btnAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.btnAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmins.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmins.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAdmins.Location = new System.Drawing.Point(535, 419);
            this.btnAdmins.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(126, 47);
            this.btnAdmins.TabIndex = 5;
            this.btnAdmins.Text = "Admins";
            this.btnAdmins.UseVisualStyleBackColor = false;
            // 
            // frmRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1248, 1037);
            this.Controls.Add(this.btnAdmins);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lvRanking);
            this.Controls.Add(this.btnLoguit);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnAdmins;
    }
}
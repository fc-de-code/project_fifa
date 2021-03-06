﻿namespace ProjectFifaV2
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
            this.lvRankingUser = new System.Windows.Forms.ListView();
            this.clmRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRankingTeam = new System.Windows.Forms.ListView();
            this.clmTeam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmScoren = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRanking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnAdmins = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // lvRankingUser
            // 
            this.lvRankingUser.BackColor = System.Drawing.Color.Gray;
            this.lvRankingUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvRankingUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmRank,
            this.clmNaam,
            this.clmScore});
            this.lvRankingUser.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lvRankingUser.Location = new System.Drawing.Point(47, 78);
            this.lvRankingUser.Margin = new System.Windows.Forms.Padding(5);
            this.lvRankingUser.Name = "lvRankingUser";
            this.lvRankingUser.Size = new System.Drawing.Size(429, 912);
            this.lvRankingUser.TabIndex = 2;
            this.lvRankingUser.UseCompatibleStateImageBehavior = false;
            this.lvRankingUser.View = System.Windows.Forms.View.Details;
            this.lvRankingUser.SelectedIndexChanged += new System.EventHandler(this.lvRanking_SelectedIndexChanged);
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
            // lvRankingTeam
            // 
            this.lvRankingTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvRankingTeam.BackColor = System.Drawing.Color.Gray;
            this.lvRankingTeam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.clmTeam,
            this.clmScoren,
            this.clmSaldo,
            this.clmRanking});
            this.lvRankingTeam.ForeColor = System.Drawing.Color.White;
            this.lvRankingTeam.FullRowSelect = true;
            this.lvRankingTeam.Location = new System.Drawing.Point(734, 78);
            this.lvRankingTeam.Margin = new System.Windows.Forms.Padding(5);
            this.lvRankingTeam.Name = "lvRankingTeam";
            this.lvRankingTeam.Size = new System.Drawing.Size(433, 912);
            this.lvRankingTeam.TabIndex = 3;
            this.lvRankingTeam.UseCompatibleStateImageBehavior = false;
            this.lvRankingTeam.View = System.Windows.Forms.View.Details;
            this.lvRankingTeam.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // frmRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1248, 1037);
            this.Controls.Add(this.btnAdmins);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.lvRankingTeam);
            this.Controls.Add(this.lvRankingUser);
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
            this.Load += new System.EventHandler(this.frmRanking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoguit;
        private System.Windows.Forms.ListView lvRankingUser;
        private System.Windows.Forms.ColumnHeader clmRank;
        private System.Windows.Forms.ColumnHeader clmNaam;
        private System.Windows.Forms.ColumnHeader clmScore;
        private System.Windows.Forms.ListView lvRankingTeam;
        private System.Windows.Forms.ColumnHeader clmTeam;
        private System.Windows.Forms.ColumnHeader clmScoren;
        private System.Windows.Forms.ColumnHeader clmSaldo;
        private System.Windows.Forms.ColumnHeader clmRanking;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnAdmins;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
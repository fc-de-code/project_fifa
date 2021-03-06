﻿namespace ProjectFifaV2
{
    partial class frmPlayer
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblResultsOverview = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.comboTeam1 = new System.Windows.Forms.ComboBox();
            this.comboTeam2 = new System.Windows.Forms.ComboBox();
            this.txtScoreTeam1 = new System.Windows.Forms.TextBox();
            this.txtScoreTeam2 = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lvOverview = new System.Windows.Forms.ListView();
            this.clmTeam1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHomeTeamScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTeamSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lvPoints = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Gray;
            this.btnUpdate.Location = new System.Drawing.Point(391, 261);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 46);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.Location = new System.Drawing.Point(991, 750);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(186, 46);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblResultsOverview
            // 
            this.lblResultsOverview.AutoSize = true;
            this.lblResultsOverview.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.lblResultsOverview.ForeColor = System.Drawing.Color.White;
            this.lblResultsOverview.Location = new System.Drawing.Point(789, 17);
            this.lblResultsOverview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultsOverview.Name = "lblResultsOverview";
            this.lblResultsOverview.Size = new System.Drawing.Size(241, 41);
            this.lblResultsOverview.TabIndex = 5;
            this.lblResultsOverview.Text = "Match schedule";
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.Location = new System.Drawing.Point(394, 750);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(186, 46);
            this.btnAdmin.TabIndex = 9;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnRanking
            // 
            this.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanking.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRanking.Location = new System.Drawing.Point(31, 750);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(4);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(186, 46);
            this.btnRanking.TabIndex = 28;
            this.btnRanking.Text = "Ranking";
            // 
            // comboTeam1
            // 
            this.comboTeam1.BackColor = System.Drawing.Color.Silver;
            this.comboTeam1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTeam1.FormattingEnabled = true;
            this.comboTeam1.Location = new System.Drawing.Point(128, 138);
            this.comboTeam1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboTeam1.Name = "comboTeam1";
            this.comboTeam1.Size = new System.Drawing.Size(160, 23);
            this.comboTeam1.TabIndex = 12;
            this.comboTeam1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboTeam2
            // 
            this.comboTeam2.BackColor = System.Drawing.Color.DarkGray;
            this.comboTeam2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTeam2.FormattingEnabled = true;
            this.comboTeam2.Location = new System.Drawing.Point(129, 191);
            this.comboTeam2.Margin = new System.Windows.Forms.Padding(4);
            this.comboTeam2.Name = "comboTeam2";
            this.comboTeam2.Size = new System.Drawing.Size(160, 23);
            this.comboTeam2.TabIndex = 12;
            this.comboTeam2.SelectedIndexChanged += new System.EventHandler(this.comboTeam2_SelectedIndexChanged);
            // 
            // txtScoreTeam1
            // 
            this.txtScoreTeam1.BackColor = System.Drawing.Color.DimGray;
            this.txtScoreTeam1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScoreTeam1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoreTeam1.Location = new System.Drawing.Point(446, 139);
            this.txtScoreTeam1.Margin = new System.Windows.Forms.Padding(4);
            this.txtScoreTeam1.Name = "txtScoreTeam1";
            this.txtScoreTeam1.Size = new System.Drawing.Size(133, 23);
            this.txtScoreTeam1.TabIndex = 14;
            // 
            // txtScoreTeam2
            // 
            this.txtScoreTeam2.BackColor = System.Drawing.Color.DimGray;
            this.txtScoreTeam2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScoreTeam2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoreTeam2.Location = new System.Drawing.Point(447, 190);
            this.txtScoreTeam2.Margin = new System.Windows.Forms.Padding(4);
            this.txtScoreTeam2.Name = "txtScoreTeam2";
            this.txtScoreTeam2.Size = new System.Drawing.Size(133, 23);
            this.txtScoreTeam2.TabIndex = 15;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblNaam.ForeColor = System.Drawing.Color.White;
            this.lblNaam.Location = new System.Drawing.Point(22, 30);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(121, 33);
            this.lblNaam.TabIndex = 26;
            this.lblNaam.Text = "Welcome";
            // 
            // btnBet
            // 
            this.btnBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBet.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.btnBet.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBet.Location = new System.Drawing.Point(31, 261);
            this.btnBet.Margin = new System.Windows.Forms.Padding(5);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(188, 46);
            this.btnBet.TabIndex = 20;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Match:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.2F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "Team:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(345, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Scoren:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(346, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Scoren:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.2F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 27);
            this.label9.TabIndex = 27;
            this.label9.Text = "Team:";
            // 
            // lvOverview
            // 
            this.lvOverview.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.lvOverview.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvOverview.BackColor = System.Drawing.Color.Gray;
            this.lvOverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTeam1,
            this.clmTeamSaldo,
            this.clmHomeTeamScore});
            this.lvOverview.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOverview.ForeColor = System.Drawing.Color.White;
            this.lvOverview.HoverSelection = true;
            this.lvOverview.Location = new System.Drawing.Point(796, 77);
            this.lvOverview.Margin = new System.Windows.Forms.Padding(5);
            this.lvOverview.Name = "lvOverview";
            this.lvOverview.Size = new System.Drawing.Size(381, 645);
            this.lvOverview.TabIndex = 7;
            this.lvOverview.UseCompatibleStateImageBehavior = false;
            this.lvOverview.View = System.Windows.Forms.View.Details;
            this.lvOverview.SelectedIndexChanged += new System.EventHandler(this.lvOverview_SelectedIndexChanged);
            // 
            // clmTeam1
            // 
            this.clmTeam1.Text = "Team 1";
            this.clmTeam1.Width = 100;
            // 
            // clmHomeTeamScore
            // 
            this.clmHomeTeamScore.Text = "VS";
            this.clmHomeTeamScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmHomeTeamScore.Width = 50;
            // 
            // clmTeamSaldo
            // 
            this.clmTeamSaldo.Text = "Team2";
            this.clmTeamSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmTeamSaldo.Width = 100;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblPoints.ForeColor = System.Drawing.Color.White;
            this.lblPoints.Location = new System.Drawing.Point(25, 355);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(224, 33);
            this.lblPoints.TabIndex = 29;
            this.lblPoints.Text = "Your point amount";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Silver;
            this.lblname.Location = new System.Drawing.Point(145, 32);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 29);
            this.lblname.TabIndex = 30;
            // 
            // lvPoints
            // 
            this.lvPoints.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.lvPoints.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvPoints.BackColor = System.Drawing.Color.Gray;
            this.lvPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvPoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvPoints.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPoints.ForeColor = System.Drawing.Color.White;
            this.lvPoints.HoverSelection = true;
            this.lvPoints.Location = new System.Drawing.Point(36, 422);
            this.lvPoints.Margin = new System.Windows.Forms.Padding(5);
            this.lvPoints.Name = "lvPoints";
            this.lvPoints.Size = new System.Drawing.Size(543, 300);
            this.lvPoints.TabIndex = 32;
            this.lvPoints.UseCompatibleStateImageBehavior = false;
            this.lvPoints.View = System.Windows.Forms.View.Details;
            this.lvPoints.SelectedIndexChanged += new System.EventHandler(this.lvPoints_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "naam";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "punten";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1216, 824);
            this.Controls.Add(this.lvPoints);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.txtScoreTeam2);
            this.Controls.Add(this.txtScoreTeam1);
            this.Controls.Add(this.comboTeam2);
            this.Controls.Add(this.comboTeam1);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lvOverview);
            this.Controls.Add(this.lblResultsOverview);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnUpdate);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPlayer";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PlayerName";
            this.Load += new System.EventHandler(this.frmPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblResultsOverview;
        private System.Windows.Forms.ListView lvOverview;
        private System.Windows.Forms.ColumnHeader clmTeam1;
        private System.Windows.Forms.ColumnHeader clmHomeTeamScore;
        private System.Windows.Forms.ColumnHeader clmTeamSaldo;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.ComboBox comboTeam1;
        private System.Windows.Forms.ComboBox comboTeam2;
        private System.Windows.Forms.TextBox txtScoreTeam1;
        private System.Windows.Forms.TextBox txtScoreTeam2;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ListView lvPoints;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

//            this.btnEditPrediction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

//<<<<<<< HEAD
//            this.btnEditPrediction.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);

//            this.btnEditPrediction.ForeColor = System.Drawing.Color.Gray;

//            this.btnEditPrediction.Location = new System.Drawing.Point(27, 303);

//            this.btnEditPrediction.Margin = new System.Windows.Forms.Padding(4);

//=======
            //this.btnEditPrediction.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //this.btnEditPrediction.ForeColor = System.Drawing.Color.White;

            //this.btnEditPrediction.Location = new System.Drawing.Point(20, 249);

//>>>>>>> master
//            this.btnEditPrediction.Name = "btnEditPrediction";

//            this.btnEditPrediction.Size = new System.Drawing.Size(106, 30);

//            this.btnEditPrediction.TabIndex = 1;

//            this.btnEditPrediction.Text = "btnEdit";

//            this.btnEditPrediction.UseVisualStyleBackColor = true;

//            this.Controls.Add(this.btnEditPrediction);

//<<<<<<< HEAD
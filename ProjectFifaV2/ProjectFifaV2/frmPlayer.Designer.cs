namespace ProjectFifaV2
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
            this.btnEditPrediction = new System.Windows.Forms.Button();
            this.btnClearPrediction = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblResultsOverview = new System.Windows.Forms.Label();
            this.lvOverview = new System.Windows.Forms.ListView();
            this.clmTeam1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHomeTeamScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTeamSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlPredCard = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblDocent = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditPrediction
            // 
            this.btnEditPrediction.Location = new System.Drawing.Point(13, 467);
            this.btnEditPrediction.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditPrediction.Name = "btnEditPrediction";
            this.btnEditPrediction.Size = new System.Drawing.Size(141, 37);
            this.btnEditPrediction.TabIndex = 1;
            this.btnEditPrediction.Text = "Edit Prediction";
            this.btnEditPrediction.UseVisualStyleBackColor = true;
            // 
            // btnClearPrediction
            // 
            this.btnClearPrediction.Location = new System.Drawing.Point(218, 467);
            this.btnClearPrediction.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearPrediction.Name = "btnClearPrediction";
            this.btnClearPrediction.Size = new System.Drawing.Size(141, 37);
            this.btnClearPrediction.TabIndex = 2;
            this.btnClearPrediction.Text = "Clear Prediction";
            this.btnClearPrediction.UseVisualStyleBackColor = true;
            this.btnClearPrediction.Click += new System.EventHandler(this.btnClearPrediction_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(13, 848);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(141, 37);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblResultsOverview
            // 
            this.lblResultsOverview.AutoSize = true;
            this.lblResultsOverview.Location = new System.Drawing.Point(848, 24);
            this.lblResultsOverview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultsOverview.Name = "lblResultsOverview";
            this.lblResultsOverview.Size = new System.Drawing.Size(112, 17);
            this.lblResultsOverview.TabIndex = 5;
            this.lblResultsOverview.Text = "wedstrijdschema";
            // 
            // lvOverview
            // 
            this.lvOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTeam1,
            this.clmHomeTeamScore,
            this.clmTeamSaldo});
            this.lvOverview.Location = new System.Drawing.Point(851, 55);
            this.lvOverview.Margin = new System.Windows.Forms.Padding(4);
            this.lvOverview.Name = "lvOverview";
            this.lvOverview.Size = new System.Drawing.Size(323, 738);
            this.lvOverview.TabIndex = 7;
            this.lvOverview.UseCompatibleStateImageBehavior = false;
            this.lvOverview.View = System.Windows.Forms.View.Details;
            // 
            // clmTeam1
            // 
            this.clmTeam1.Text = "Team 1";
            this.clmTeam1.Width = 136;
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
            this.clmTeamSaldo.Width = 132;
            // 
            // pnlPredCard
            // 
            this.pnlPredCard.Location = new System.Drawing.Point(16, 540);
            this.pnlPredCard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPredCard.Name = "pnlPredCard";
            this.pnlPredCard.Size = new System.Drawing.Size(502, 259);
            this.pnlPredCard.TabIndex = 8;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(377, 848);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(141, 37);
            this.btnAdmin.TabIndex = 9;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnRanking
            // 
            this.btnRanking.Location = new System.Drawing.Point(194, 848);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(4);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(141, 37);
            this.btnRanking.TabIndex = 10;
            this.btnRanking.Text = "Rangking";
            this.btnRanking.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(73, 305);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // lblDocent
            // 
            this.lblDocent.AutoSize = true;
            this.lblDocent.Location = new System.Drawing.Point(11, 121);
            this.lblDocent.Name = "lblDocent";
            this.lblDocent.Size = new System.Drawing.Size(93, 17);
            this.lblDocent.TabIndex = 13;
            this.lblDocent.Text = "welkom aapje";
            this.lblDocent.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(350, 305);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(426, 122);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Hoe veel punten wil je inzeten?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Weddenschap";
            // 
            // btnWet
            // 
            this.btnWet.Location = new System.Drawing.Point(179, 360);
            this.btnWet.Margin = new System.Windows.Forms.Padding(4);
            this.btnWet.Name = "btnWet";
            this.btnWet.Size = new System.Drawing.Size(141, 37);
            this.btnWet.TabIndex = 20;
            this.btnWet.Text = "Wet";
            this.btnWet.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Wetstrijd:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Team:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Team:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Scoren:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Scoren:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1047, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ronden Nummer";
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 898);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnWet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDocent);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.pnlPredCard);
            this.Controls.Add(this.lvOverview);
            this.Controls.Add(this.lblResultsOverview);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnClearPrediction);
            this.Controls.Add(this.btnEditPrediction);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditPrediction;
        private System.Windows.Forms.Button btnClearPrediction;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblResultsOverview;
        private System.Windows.Forms.ListView lvOverview;
        private System.Windows.Forms.ColumnHeader clmTeam1;
        private System.Windows.Forms.ColumnHeader clmHomeTeamScore;
        private System.Windows.Forms.ColumnHeader clmTeamSaldo;
        private System.Windows.Forms.Panel pnlPredCard;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblDocent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnWet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

            this.lblNaam = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lvPoints = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.btnLogOut.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.Location = new System.Drawing.Point(991, 750);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.lblResultsOverview.Location = new System.Drawing.Point(789, 17);
            this.btnAdmin.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.Location = new System.Drawing.Point(394, 750);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnRanking.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRanking.Location = new System.Drawing.Point(31, 750);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(4);
            this.comboTeam1.Location = new System.Drawing.Point(128, 138);
            this.comboTeam2.Location = new System.Drawing.Point(129, 191);
            this.comboTeam2.Margin = new System.Windows.Forms.Padding(4);
            this.txtScoreTeam1.Location = new System.Drawing.Point(446, 139);
            this.txtScoreTeam1.Margin = new System.Windows.Forms.Padding(4);
            this.txtScoreTeam2.Location = new System.Drawing.Point(447, 190);
            this.txtScoreTeam2.Margin = new System.Windows.Forms.Padding(4);
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
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label4.Location = new System.Drawing.Point(30, 187);
            this.label6.Location = new System.Drawing.Point(345, 134);
            this.label7.Location = new System.Drawing.Point(346, 186);
            this.label9.Location = new System.Drawing.Point(26, 134);
            this.lvOverview.Location = new System.Drawing.Point(796, 77);
            this.lvOverview.Margin = new System.Windows.Forms.Padding(5);
            this.lvOverview.Size = new System.Drawing.Size(381, 645);
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
            this.ClientSize = new System.Drawing.Size(1216, 824);
            this.Controls.Add(this.lvPoints);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.btnUpdate);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPlayer";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ListView lvPoints;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
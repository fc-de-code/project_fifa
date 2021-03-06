﻿namespace ProjectFifaV2
{
    partial class frmAdmin
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
            this.btnLoadData = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.dgvAdminData = new System.Windows.Forms.DataGridView();
            this.btnAdminLogOut = new System.Windows.Forms.Button();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadData
            // 
            this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLoadData.Location = new System.Drawing.Point(766, 41);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(108, 32);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.DimGray;
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Location = new System.Drawing.Point(132, 41);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath.MaxLength = 256;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(569, 22);
            this.txtPath.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSelectFile.Location = new System.Drawing.Point(16, 34);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(108, 32);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.BackColor = System.Drawing.Color.Gainsboro;
            this.txtQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuery.Location = new System.Drawing.Point(16, 114);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuery.MaxLength = 150;
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(685, 102);
            this.txtQuery.TabIndex = 4;
            // 
            // btnExecute
            // 
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecute.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.Color.DarkGray;
            this.btnExecute.Location = new System.Drawing.Point(766, 148);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(4);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(108, 32);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // dgvAdminData
            // 
            this.dgvAdminData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminData.Location = new System.Drawing.Point(16, 250);
            this.dgvAdminData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAdminData.Name = "dgvAdminData";
            this.dgvAdminData.Size = new System.Drawing.Size(858, 285);
            this.dgvAdminData.TabIndex = 6;
            // 
            // btnAdminLogOut
            // 
            this.btnAdminLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogOut.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogOut.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAdminLogOut.Location = new System.Drawing.Point(947, 34);
            this.btnAdminLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminLogOut.Name = "btnAdminLogOut";
            this.btnAdminLogOut.Size = new System.Drawing.Size(141, 49);
            this.btnAdminLogOut.TabIndex = 7;
            this.btnAdminLogOut.Text = "Log Out";
            this.btnAdminLogOut.UseVisualStyleBackColor = true;
            this.btnAdminLogOut.Click += new System.EventHandler(this.btnAdminLogOut_Click);
            // 
            // btnPlayer
            // 
            this.btnPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayer.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer.ForeColor = System.Drawing.Color.DarkGray;
            this.btnPlayer.Location = new System.Drawing.Point(947, 233);
            this.btnPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(141, 49);
            this.btnPlayer.TabIndex = 9;
            this.btnPlayer.Text = "Player";
            this.btnPlayer.UseVisualStyleBackColor = true;
            // 
            // btnRanking
            // 
            this.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanking.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRanking.Location = new System.Drawing.Point(947, 137);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(4);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(141, 43);
            this.btnRanking.TabIndex = 8;
            this.btnRanking.Text = "Rangking";
            this.btnRanking.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1101, 571);
            this.Controls.Add(this.btnPlayer);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnAdminLogOut);
            this.Controls.Add(this.dgvAdminData);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnLoadData);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.DataGridView dgvAdminData;
        private System.Windows.Forms.Button btnAdminLogOut;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button btnPlayer;
    }
}
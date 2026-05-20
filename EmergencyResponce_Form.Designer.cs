namespace OOP2ProjectTest
{
    partial class EmergencyResponce_Form
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
            this.dgvMyReports = new System.Windows.Forms.DataGridView();
            this.lblReportDate = new System.Windows.Forms.Label();
            this.lblEmergencyType = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.reportemergency = new System.Windows.Forms.Button();
            this.emergencycontacts = new System.Windows.Forms.Button();
            this.emergencyresponce = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblReportCount = new System.Windows.Forms.Label();
            this.lblstatu = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnViewOnMap = new System.Windows.Forms.Button();
            this.lblPendingCount = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyReports)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMyReports
            // 
            this.dgvMyReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyReports.Location = new System.Drawing.Point(453, 140);
            this.dgvMyReports.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMyReports.Name = "dgvMyReports";
            this.dgvMyReports.RowHeadersWidth = 62;
            this.dgvMyReports.RowTemplate.Height = 28;
            this.dgvMyReports.Size = new System.Drawing.Size(851, 265);
            this.dgvMyReports.TabIndex = 0;
            this.dgvMyReports.SelectionChanged += new System.EventHandler(this.dgvMyReports_SelectionChanged_1);
            // 
            // lblReportDate
            // 
            this.lblReportDate.AutoSize = true;
            this.lblReportDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReportDate.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblReportDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.lblReportDate.Location = new System.Drawing.Point(449, 683);
            this.lblReportDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReportDate.Name = "lblReportDate";
            this.lblReportDate.Size = new System.Drawing.Size(88, 21);
            this.lblReportDate.TabIndex = 2;
            this.lblReportDate.Text = "Reported:";
            // 
            // lblEmergencyType
            // 
            this.lblEmergencyType.AutoSize = true;
            this.lblEmergencyType.BackColor = System.Drawing.Color.Transparent;
            this.lblEmergencyType.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblEmergencyType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.lblEmergencyType.Location = new System.Drawing.Point(449, 658);
            this.lblEmergencyType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmergencyType.Name = "lblEmergencyType";
            this.lblEmergencyType.Size = new System.Drawing.Size(102, 21);
            this.lblEmergencyType.TabIndex = 5;
            this.lblEmergencyType.Text = "Emergency:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(268, 729);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 23);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.reportemergency);
            this.panel1.Controls.Add(this.emergencycontacts);
            this.panel1.Controls.Add(this.emergencyresponce);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 806);
            this.panel1.TabIndex = 11;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exit.Image = global::OOP2ProjectTest.Properties.Resources.logout;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(15, 746);
            this.exit.Name = "exit";
            this.exit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.exit.Size = new System.Drawing.Size(313, 60);
            this.exit.TabIndex = 7;
            this.exit.Text = "    Exit";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // reportemergency
            // 
            this.reportemergency.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportemergency.FlatAppearance.BorderSize = 0;
            this.reportemergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportemergency.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.reportemergency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reportemergency.Image = global::OOP2ProjectTest.Properties.Resources.emergency;
            this.reportemergency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportemergency.Location = new System.Drawing.Point(15, 317);
            this.reportemergency.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reportemergency.Name = "reportemergency";
            this.reportemergency.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.reportemergency.Size = new System.Drawing.Size(313, 60);
            this.reportemergency.TabIndex = 5;
            this.reportemergency.Text = "    Report Emergency";
            this.reportemergency.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportemergency.UseVisualStyleBackColor = true;
            this.reportemergency.Click += new System.EventHandler(this.reportemergency_Click);
            // 
            // emergencycontacts
            // 
            this.emergencycontacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.emergencycontacts.FlatAppearance.BorderSize = 0;
            this.emergencycontacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emergencycontacts.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.emergencycontacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emergencycontacts.Image = global::OOP2ProjectTest.Properties.Resources.phone;
            this.emergencycontacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emergencycontacts.Location = new System.Drawing.Point(15, 257);
            this.emergencycontacts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emergencycontacts.Name = "emergencycontacts";
            this.emergencycontacts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.emergencycontacts.Size = new System.Drawing.Size(313, 60);
            this.emergencycontacts.TabIndex = 4;
            this.emergencycontacts.Text = "    Emergency Contacts";
            this.emergencycontacts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.emergencycontacts.UseVisualStyleBackColor = true;
            this.emergencycontacts.Click += new System.EventHandler(this.emergencycontacts_Click);
            // 
            // emergencyresponce
            // 
            this.emergencyresponce.Dock = System.Windows.Forms.DockStyle.Top;
            this.emergencyresponce.FlatAppearance.BorderSize = 0;
            this.emergencyresponce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emergencyresponce.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.emergencyresponce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emergencyresponce.Image = global::OOP2ProjectTest.Properties.Resources.responce__1_;
            this.emergencyresponce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emergencyresponce.Location = new System.Drawing.Point(15, 197);
            this.emergencyresponce.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emergencyresponce.Name = "emergencyresponce";
            this.emergencyresponce.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.emergencyresponce.Size = new System.Drawing.Size(313, 60);
            this.emergencyresponce.TabIndex = 6;
            this.emergencyresponce.Text = "    Emergency Response";
            this.emergencyresponce.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.emergencyresponce.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.Dock = System.Windows.Forms.DockStyle.Top;
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.home.Image = global::OOP2ProjectTest.Properties.Resources.home__4_;
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(15, 137);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.home.Size = new System.Drawing.Size(313, 60);
            this.home.TabIndex = 9;
            this.home.Text = "    Home";
            this.home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(328, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 669);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 669);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 137);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(82, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Barangay Emergency Response \r\nSystem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(82, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "BERS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP2ProjectTest.Properties.Resources.Untitled_design__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblReportCount
            // 
            this.lblReportCount.AutoSize = true;
            this.lblReportCount.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblReportCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.lblReportCount.Location = new System.Drawing.Point(449, 116);
            this.lblReportCount.Name = "lblReportCount";
            this.lblReportCount.Size = new System.Drawing.Size(116, 21);
            this.lblReportCount.TabIndex = 13;
            this.lblReportCount.Text = "Total Reports:";
            // 
            // lblstatu
            // 
            this.lblstatu.AutoSize = true;
            this.lblstatu.BackColor = System.Drawing.Color.Transparent;
            this.lblstatu.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblstatu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.lblstatu.Location = new System.Drawing.Point(449, 704);
            this.lblstatu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstatu.Name = "lblstatu";
            this.lblstatu.Size = new System.Drawing.Size(63, 21);
            this.lblstatu.TabIndex = 15;
            this.lblstatu.Text = "Status:";
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(125)))));
            this.panel25.Controls.Add(this.label11);
            this.panel25.Controls.Add(this.pictureBox2);
            this.panel25.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel25.Location = new System.Drawing.Point(343, 0);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(1062, 104);
            this.panel25.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(75, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(270, 30);
            this.label11.TabIndex = 1;
            this.label11.Text = "Emergency Response";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOP2ProjectTest.Properties.Resources.responce__2_;
            this.pictureBox2.Location = new System.Drawing.Point(8, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnViewOnMap
            // 
            this.btnViewOnMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.btnViewOnMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewOnMap.FlatAppearance.BorderSize = 0;
            this.btnViewOnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOnMap.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnViewOnMap.ForeColor = System.Drawing.Color.White;
            this.btnViewOnMap.Location = new System.Drawing.Point(1137, 693);
            this.btnViewOnMap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViewOnMap.Name = "btnViewOnMap";
            this.btnViewOnMap.Size = new System.Drawing.Size(167, 53);
            this.btnViewOnMap.TabIndex = 8;
            this.btnViewOnMap.Text = "Location";
            this.btnViewOnMap.UseVisualStyleBackColor = false;
            this.btnViewOnMap.Click += new System.EventHandler(this.btnNewReport_Click);
            // 
            // lblPendingCount
            // 
            this.lblPendingCount.AutoSize = true;
            this.lblPendingCount.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblPendingCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.lblPendingCount.Location = new System.Drawing.Point(449, 725);
            this.lblPendingCount.Name = "lblPendingCount";
            this.lblPendingCount.Size = new System.Drawing.Size(116, 21);
            this.lblPendingCount.TabIndex = 19;
            this.lblPendingCount.Text = "Total Reports:";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.BackColor = System.Drawing.Color.Transparent;
            this.lblResponse.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.lblResponse.Location = new System.Drawing.Point(942, 416);
            this.lblResponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(91, 21);
            this.lblResponse.TabIndex = 20;
            this.lblResponse.Text = "Responce:";
            // 
            // EmergencyResponce_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1405, 806);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblPendingCount);
            this.Controls.Add(this.panel25);
            this.Controls.Add(this.lblstatu);
            this.Controls.Add(this.lblEmergencyType);
            this.Controls.Add(this.lblReportCount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnViewOnMap);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblReportDate);
            this.Controls.Add(this.dgvMyReports);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EmergencyResponce_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmergencyResponce_Form";
            this.Load += new System.EventHandler(this.EmergencyResponce_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyReports)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMyReports;
        private System.Windows.Forms.Label lblReportDate;
        private System.Windows.Forms.Label lblEmergencyType;
        private System.Windows.Forms.Button btnViewOnMap;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reportemergency;
        private System.Windows.Forms.Button emergencycontacts;
        private System.Windows.Forms.Button emergencyresponce;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblReportCount;
        private System.Windows.Forms.Label lblstatu;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPendingCount;
        private System.Windows.Forms.Label lblResponse;
    }
}
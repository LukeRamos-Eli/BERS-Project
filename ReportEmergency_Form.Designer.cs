namespace OOP2ProjectTest
{
    partial class ReportEmergency_Form
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmergencyType = new System.Windows.Forms.ComboBox();
            this.Barangay = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportemergency = new System.Windows.Forms.Button();
            this.emergencycontacts = new System.Windows.Forms.Button();
            this.emergencyresponce = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Submit = new System.Windows.Forms.Button();
            this.btnSelectLocation = new System.Windows.Forms.Button();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLocationStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(762, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Barangay:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(500, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Emergency Type:";
            // 
            // EmergencyType
            // 
            this.EmergencyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmergencyType.FormattingEnabled = true;
            this.EmergencyType.Location = new System.Drawing.Point(504, 260);
            this.EmergencyType.Name = "EmergencyType";
            this.EmergencyType.Size = new System.Drawing.Size(167, 28);
            this.EmergencyType.TabIndex = 1;
            // 
            // Barangay
            // 
            this.Barangay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Barangay.FormattingEnabled = true;
            this.Barangay.Location = new System.Drawing.Point(766, 260);
            this.Barangay.Name = "Barangay";
            this.Barangay.Size = new System.Drawing.Size(167, 28);
            this.Barangay.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.reportemergency);
            this.panel1.Controls.Add(this.emergencycontacts);
            this.panel1.Controls.Add(this.emergencyresponce);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 806);
            this.panel1.TabIndex = 10;
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
            this.emergencyresponce.Click += new System.EventHandler(this.emergencyresponce_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.Dock = System.Windows.Forms.DockStyle.Top;
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Century Gothic", 10F);
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
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 10F);
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
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 137);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(82, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 42);
            this.label6.TabIndex = 3;
            this.label6.Text = "Barangay Emergency Response \r\nSystem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(82, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "BERS";
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.panel5.Location = new System.Drawing.Point(504, 666);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(739, 1);
            this.panel5.TabIndex = 11;
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
            this.label11.Size = new System.Drawing.Size(234, 30);
            this.label11.TabIndex = 1;
            this.label11.Text = "Report Emergency";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOP2ProjectTest.Properties.Resources.emergency__1_;
            this.pictureBox2.Location = new System.Drawing.Point(8, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.panel6.Location = new System.Drawing.Point(504, 216);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(739, 1);
            this.panel6.TabIndex = 12;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Image = global::OOP2ProjectTest.Properties.Resources.sent;
            this.Submit.Location = new System.Drawing.Point(1145, 683);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(98, 37);
            this.Submit.TabIndex = 1;
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // btnSelectLocation
            // 
            this.btnSelectLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.btnSelectLocation.FlatAppearance.BorderSize = 0;
            this.btnSelectLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectLocation.ForeColor = System.Drawing.Color.White;
            this.btnSelectLocation.Location = new System.Drawing.Point(504, 510);
            this.btnSelectLocation.Name = "btnSelectLocation";
            this.btnSelectLocation.Size = new System.Drawing.Size(167, 37);
            this.btnSelectLocation.TabIndex = 19;
            this.btnSelectLocation.Text = "Choose Location";
            this.btnSelectLocation.UseVisualStyleBackColor = false;
            this.btnSelectLocation.Click += new System.EventHandler(this.btnSelectLocation_Click);
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(500, 399);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(71, 20);
            this.lblLatitude.TabIndex = 20;
            this.lblLatitude.Text = "Latitude:";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(500, 435);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(89, 20);
            this.lblLongitude.TabIndex = 21;
            this.lblLongitude.Text = "Longtitude:";
            // 
            // lblLocationStatus
            // 
            this.lblLocationStatus.AutoSize = true;
            this.lblLocationStatus.Location = new System.Drawing.Point(500, 471);
            this.lblLocationStatus.Name = "lblLocationStatus";
            this.lblLocationStatus.Size = new System.Drawing.Size(0, 20);
            this.lblLocationStatus.TabIndex = 22;
            // 
            // ReportEmergency_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1405, 806);
            this.Controls.Add(this.lblLocationStatus);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.btnSelectLocation);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel25);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Barangay);
            this.Controls.Add(this.EmergencyType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportEmergency_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportEmergency_Form";
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
        private System.Windows.Forms.ComboBox EmergencyType;
        private System.Windows.Forms.ComboBox Barangay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reportemergency;
        private System.Windows.Forms.Button emergencycontacts;
        private System.Windows.Forms.Button emergencyresponce;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSelectLocation;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLocationStatus;
    }
}
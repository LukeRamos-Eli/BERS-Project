namespace OOP2ProjectTest
{
    partial class SendResponce_Form
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
            this.dgvPendingReports = new System.Windows.Forms.DataGridView();
            this.lblPendingCount = new System.Windows.Forms.Label();
            this.txtResponseMessage = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewallreports = new System.Windows.Forms.Button();
            this.sendresponce = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSendResponse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingReports)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPendingReports
            // 
            this.dgvPendingReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingReports.Location = new System.Drawing.Point(729, 218);
            this.dgvPendingReports.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvPendingReports.Name = "dgvPendingReports";
            this.dgvPendingReports.RowHeadersWidth = 62;
            this.dgvPendingReports.RowTemplate.Height = 28;
            this.dgvPendingReports.Size = new System.Drawing.Size(653, 549);
            this.dgvPendingReports.TabIndex = 0;
            // 
            // lblPendingCount
            // 
            this.lblPendingCount.AutoSize = true;
            this.lblPendingCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPendingCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPendingCount.Location = new System.Drawing.Point(16, 570);
            this.lblPendingCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPendingCount.Name = "lblPendingCount";
            this.lblPendingCount.Size = new System.Drawing.Size(72, 23);
            this.lblPendingCount.TabIndex = 1;
            this.lblPendingCount.Text = "label1";
            // 
            // txtResponseMessage
            // 
            this.txtResponseMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResponseMessage.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponseMessage.Location = new System.Drawing.Point(383, 246);
            this.txtResponseMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtResponseMessage.Name = "txtResponseMessage";
            this.txtResponseMessage.Size = new System.Drawing.Size(328, 185);
            this.txtResponseMessage.TabIndex = 2;
            this.txtResponseMessage.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.viewallreports);
            this.panel1.Controls.Add(this.sendresponce);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 806);
            this.panel1.TabIndex = 6;
            // 
            // viewallreports
            // 
            this.viewallreports.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewallreports.FlatAppearance.BorderSize = 0;
            this.viewallreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewallreports.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.viewallreports.ForeColor = System.Drawing.Color.White;
            this.viewallreports.Image = global::OOP2ProjectTest.Properties.Resources.report;
            this.viewallreports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewallreports.Location = new System.Drawing.Point(15, 257);
            this.viewallreports.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.viewallreports.Name = "viewallreports";
            this.viewallreports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.viewallreports.Size = new System.Drawing.Size(313, 60);
            this.viewallreports.TabIndex = 1;
            this.viewallreports.Text = "    View All Reports";
            this.viewallreports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewallreports.UseVisualStyleBackColor = true;
            this.viewallreports.Click += new System.EventHandler(this.viewallreports_Click);
            // 
            // sendresponce
            // 
            this.sendresponce.Dock = System.Windows.Forms.DockStyle.Top;
            this.sendresponce.FlatAppearance.BorderSize = 0;
            this.sendresponce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendresponce.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.sendresponce.ForeColor = System.Drawing.Color.White;
            this.sendresponce.Image = global::OOP2ProjectTest.Properties.Resources.responce;
            this.sendresponce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendresponce.Location = new System.Drawing.Point(15, 197);
            this.sendresponce.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sendresponce.Name = "sendresponce";
            this.sendresponce.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sendresponce.Size = new System.Drawing.Size(313, 60);
            this.sendresponce.TabIndex = 3;
            this.sendresponce.Text = "    Send Response";
            this.sendresponce.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sendresponce.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Image = global::OOP2ProjectTest.Properties.Resources.home__4_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 137);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(313, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "    Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(328, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 669);
            this.panel4.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Image = global::OOP2ProjectTest.Properties.Resources.logout;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(15, 746);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(313, 60);
            this.button2.TabIndex = 7;
            this.button2.Text = "    Exit";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(379, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Responce:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.panel5.Location = new System.Drawing.Point(383, 433);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(328, 1);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.panel6.Location = new System.Drawing.Point(383, 244);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(328, 1);
            this.panel6.TabIndex = 9;
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
            this.label11.Size = new System.Drawing.Size(193, 30);
            this.label11.TabIndex = 1;
            this.label11.Text = "Send Response";
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
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::OOP2ProjectTest.Properties.Resources.sync;
            this.btnRefresh.Location = new System.Drawing.Point(1268, 168);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 44);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSendResponse
            // 
            this.btnSendResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.btnSendResponse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSendResponse.FlatAppearance.BorderSize = 0;
            this.btnSendResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendResponse.Image = global::OOP2ProjectTest.Properties.Resources.sent;
            this.btnSendResponse.Location = new System.Drawing.Point(622, 440);
            this.btnSendResponse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSendResponse.Name = "btnSendResponse";
            this.btnSendResponse.Size = new System.Drawing.Size(89, 38);
            this.btnSendResponse.TabIndex = 4;
            this.btnSendResponse.UseVisualStyleBackColor = false;
            this.btnSendResponse.Click += new System.EventHandler(this.btnSendResponse_Click);
            // 
            // SendResponce_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1405, 806);
            this.Controls.Add(this.panel25);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSendResponse);
            this.Controls.Add(this.txtResponseMessage);
            this.Controls.Add(this.lblPendingCount);
            this.Controls.Add(this.dgvPendingReports);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SendResponce_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendResponce_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingReports)).EndInit();
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

        private System.Windows.Forms.DataGridView dgvPendingReports;
        private System.Windows.Forms.Label lblPendingCount;
        private System.Windows.Forms.RichTextBox txtResponseMessage;
        private System.Windows.Forms.Button btnSendResponse;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button viewallreports;
        private System.Windows.Forms.Button sendresponce;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
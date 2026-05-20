namespace OOP2ProjectTest
{
    partial class MapViewer_Form
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
            this.webViewMap = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.bckbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webViewMap)).BeginInit();
            this.SuspendLayout();
            // 
            // webViewMap
            // 
            this.webViewMap.AllowExternalDrop = true;
            this.webViewMap.CreationProperties = null;
            this.webViewMap.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewMap.Location = new System.Drawing.Point(0, 0);
            this.webViewMap.Name = "webViewMap";
            this.webViewMap.Size = new System.Drawing.Size(1405, 806);
            this.webViewMap.TabIndex = 0;
            this.webViewMap.ZoomFactor = 1D;
            // 
            // bckbutton
            // 
            this.bckbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(125)))));
            this.bckbutton.FlatAppearance.BorderSize = 0;
            this.bckbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bckbutton.ForeColor = System.Drawing.Color.White;
            this.bckbutton.Location = new System.Drawing.Point(1265, 24);
            this.bckbutton.Name = "bckbutton";
            this.bckbutton.Size = new System.Drawing.Size(116, 41);
            this.bckbutton.TabIndex = 1;
            this.bckbutton.Text = "Back";
            this.bckbutton.UseVisualStyleBackColor = false;
            this.bckbutton.Click += new System.EventHandler(this.bckbutton_Click);
            // 
            // MapViewer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 806);
            this.Controls.Add(this.bckbutton);
            this.Controls.Add(this.webViewMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MapViewer_Form";
            this.Text = "MapViewer_Form";
            ((System.ComponentModel.ISupportInitialize)(this.webViewMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewMap;
        private System.Windows.Forms.Button bckbutton;
    }
}
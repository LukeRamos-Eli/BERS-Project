using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP2ProjectTest
{
    public partial class Mapping : Form
    {
        public double SelectedLatitude { get; private set; }
        public double SelectedLongitude { get; private set; }
        public bool LocationSelected { get; private set; }

        public Mapping()
        {
            InitializeComponent();
            LoadMap();
        }

        private async void LoadMap()
        {
            try
            {
                await webViewMap.EnsureCoreWebView2Async(null);
                string htmlPath = Path.Combine(Application.StartupPath, "map.html");

                if (!File.Exists(htmlPath))
                {
                    MessageBox.Show($"Map file not found: {htmlPath}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                webViewMap.CoreWebView2.Navigate(htmlPath);

                
                webViewMap.CoreWebView2.WebMessageReceived += WebView_WebMessageReceived;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading map: " + ex.Message);
            }
        }

        private void WebView_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            try
            {
                string message = e.TryGetWebMessageAsString();

        
                MessageBox.Show($"Received: {message}");

                if (!string.IsNullOrEmpty(message))
                {
                    var data = JsonSerializer.Deserialize<Dictionary<string, object>>(message);
                    if (data != null && data.ContainsKey("type") && data["type"].ToString() == "location")
                    {
                        if (data.ContainsKey("latitude") && data.ContainsKey("longitude"))
                        {
       
                            if (data["latitude"] is JsonElement latElement && data["longitude"] is JsonElement lngElement)
                            {
                                SelectedLatitude = latElement.GetDouble();
                                SelectedLongitude = lngElement.GetDouble();
                                LocationSelected = true;

                                MessageBox.Show($"Location saved!\nLat: {SelectedLatitude}\nLng: {SelectedLongitude}");

                                UpdateLocationLabels();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void UpdateLocationLabels()
        {
            if (lblLatitude != null)
                lblLatitude.Text = $"Latitude: {SelectedLatitude}";
            if (lblLongitude != null)
                lblLongitude.Text = $"Longitude: {SelectedLongitude}";
            if (lblStatus != null)
            {
                lblStatus.Text = "✓ Location selected!";
                lblStatus.ForeColor = Color.Green;
            }
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnGetCurrentLocation_Click(object sender, EventArgs e)
        {
            string script = "getCurrentLocation();";
            await webViewMap.CoreWebView2.ExecuteScriptAsync(script);
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (LocationSelected)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a location on the map first.", "No Location",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
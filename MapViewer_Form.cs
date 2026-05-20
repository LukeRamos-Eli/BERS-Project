using System;
using System.Windows.Forms;

namespace OOP2ProjectTest
{
    public partial class MapViewer_Form : Form
    {
        public MapViewer_Form(double lat, double lng, string barangay, string location)
        {
            InitializeComponent();
            LoadMap(lat, lng, barangay, location);
        }

        private async void LoadMap(double lat, double lng, string barangay, string location)
        {
            try
            {
                await webViewMap.EnsureCoreWebView2Async(null);

                string latStr = lat.ToString(System.Globalization.CultureInfo.InvariantCulture);
                string lngStr = lng.ToString(System.Globalization.CultureInfo.InvariantCulture);

                string html = $@"
                <!DOCTYPE html>
                <html>
                <head>
                    <title>Emergency Location</title>
                    <meta charset='utf-8' />
                    <link rel='stylesheet' href='https://unpkg.com/leaflet@1.9.4/dist/leaflet.css' />
                    <script src='https://unpkg.com/leaflet@1.9.4/dist/leaflet.js'></script>
                    <style>
                        body {{ margin: 0; padding: 0; }}
                        #map {{ position: absolute; top: 0; bottom: 0; width: 100%; height: 100%; }}
                    </style>
                </head>
                <body>
                    <div id='map'></div>
                    <script>
                        var lat = {latStr};
                        var lng = {lngStr};
                        var map = L.map('map').setView([lat, lng], 16);
                        L.tileLayer('https://{{s}}.basemaps.cartocdn.com/light_all/{{z}}/{{x}}/{{y}}.png', {{
                            attribution: '© OpenStreetMap © CARTO'
                        }}).addTo(map);
                        var marker = L.marker([lat, lng]).addTo(map);
                        marker.bindPopup('<b>Emergency Location</b><br>Barangay: {barangay}<br>Location: {location}').openPopup();
                    </script>
                </body>
                </html>";

                webViewMap.NavigateToString(html);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading map: " + ex.Message);
            }
        }

        private void bckbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
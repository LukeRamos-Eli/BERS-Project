using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2ProjectTest
{
    public partial class ReportEmergency_Form : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Luke Jayden M. Ramos\Desktop\LukeCodeProject\OOP2ProjectTest\DataBase\Agency.accdb""";
        OleDbConnection myConn;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;


        private double selectedLatitude = 0;
        private double selectedLongitude = 0;
        private bool locationSelected = false;

        public ReportEmergency_Form()
        {
            InitializeComponent();
            LoadEmergencyTypes();
            LoadBarangays();
        }

        private void LoadEmergencyTypes()
        {
            EmergencyType.Items.AddRange(new string[]
            {
                "Theft", "Robbery", "Assault", "Violence", "Murder", "Rape",
                "Fire", "Burning", "Explosion",
                "Medical Emergency", "Accident", "Heart Attack", "Stroke", "Injury", "Childbirth",
                "Flood", "Earthquake", "Typhoon", "Landslide", "Volcanic Eruption", "Tsunami"
            });
        }

        private void LoadBarangays()
        {
            try
            {
                using (myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();
                    string query = "SELECT BarangayName FROM Barangay ORDER BY BarangayName";
                    cmd = new OleDbCommand(query, myConn);
                    da = new OleDbDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "Barangay");

                    Barangay.DisplayMember = "BarangayName";
                    Barangay.DataSource = ds.Tables["Barangay"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading barangays: " + ex.Message);
            }
        }

        private int GetBarangayID(string barangayName)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT BarangayID FROM Barangay WHERE BarangayName = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", barangayName);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show($"Barangay '{barangayName}' not found!");
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting BarangayID: " + ex.Message);
                return 0;
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            User_Form homeForm = new User_Form();
            homeForm.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

      

        private void emergencyresponce_Click(object sender, EventArgs e)
        {
            EmergencyResponce_Form emergency = new EmergencyResponce_Form();
            emergency.Show();
            this.Hide();
        }

        private void emergencycontacts_Click(object sender, EventArgs e)
        {
            EmergencyContact_Form emergency = new EmergencyContact_Form();
            emergency.Show();
            this.Hide();
        }

        private void btnSelectLocation_Click(object sender, EventArgs e)
        {
            using (Mapping mapForm = new Mapping())
            {
                if (mapForm.ShowDialog() == DialogResult.OK)
                {
                    selectedLatitude = mapForm.SelectedLatitude;
                    selectedLongitude = mapForm.SelectedLongitude;
                    locationSelected = true;

                    lblLatitude.Text = $"Latitude: {selectedLatitude}";
                    lblLongitude.Text = $"Longitude: {selectedLongitude}";
                    lblLocationStatus.Text = "✓ Location selected!";
                    lblLocationStatus.ForeColor = Color.Green;
                }
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (!locationSelected)
            {
                MessageBox.Show("Please select your location on the map first.", "Location Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if emergency type is selected
            if (string.IsNullOrEmpty(EmergencyType.Text))
            {
                MessageBox.Show("Please select Emergency Type.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmergencyType.Focus();
                return;
            }

            // Check if barangay is selected
            if (Barangay.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Barangay.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Barangay.Focus();
                return;
            }

            SubmitEmergencyReport();
        }

        private void SubmitEmergencyReport()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // Use invariant culture to preserve decimal points
                    string formattedLat = selectedLatitude.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    string formattedLng = selectedLongitude.ToString(System.Globalization.CultureInfo.InvariantCulture);

                    string query = @"INSERT INTO [Reports] 
                            ([ResidentID], [EmergencyType], [BarangayID], [ReportDateTime], 
                             [Status], [Latitude], [Longitude]) 
                            VALUES 
                            (?, ?, ?, NOW(), ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", Session.ResidentID);
                        cmd.Parameters.AddWithValue("?", EmergencyType.Text);
                        cmd.Parameters.AddWithValue("?", GetBarangayID(Barangay.Text));
                        cmd.Parameters.AddWithValue("?", "Pending");
                        cmd.Parameters.AddWithValue("?", selectedLatitude);  // Should be like 10.300885
                        cmd.Parameters.AddWithValue("?", selectedLongitude); // Should be like 123.898155

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Report Submitted Successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string GetAssignedAgency(string emergencyType)
        {
            switch (emergencyType.ToLower())
            {
                case "theft":
                case "robbery":
                case "assault":
                case "violence":
                case "murder":
                case "rape":
                    return "Police";
                case "fire":
                case "burning":
                case "explosion":
                    return "Fire";
                case "medical emergency":
                case "accident":
                case "heart attack":
                case "stroke":
                case "injury":
                case "childbirth":
                    return "Ambulance";
                case "flood":
                case "earthquake":
                case "typhoon":
                case "landslide":
                case "volcanic eruption":
                case "tsunami":
                    return "Disaster";
                default:
                    return "Police";
            }
        }

        private void ClearForm()
        {
            EmergencyType.SelectedIndex = -1;
            Barangay.SelectedIndex = -1;
            selectedLatitude = 0;
            selectedLongitude = 0;
            locationSelected = false;
            lblLatitude.Text = "Latitude: Not selected";
            lblLongitude.Text = "Longitude: Not selected";
            lblLocationStatus.Text = "⚠️ Please select your location";
            lblLocationStatus.ForeColor = Color.Red;
        }



    }
}
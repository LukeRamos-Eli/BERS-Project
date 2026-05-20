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
    public partial class ViewReports_Form : Form
    {
        private string agencyName;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Luke Jayden M. Ramos\Desktop\LukeCodeProject\OOP2ProjectTest\DataBase\Agency.accdb""";
        private OleDbConnection myConn;
        private OleDbCommand cmd;
        private OleDbDataAdapter da;
        private DataSet ds;

        public ViewReports_Form(string agency)
        {
            InitializeComponent();
            agencyName = agency;
            
            LoadReports();
        }

        private void LoadReports()
        {
            try
            {
                using (myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();

                    string query = "SELECT * FROM qryResidentReports";

                    if (agencyName == "Police")
                    {
                        query += " WHERE EmergencyType IN ('Theft', 'Robbery', 'Assault', 'Violence', 'Murder', 'Rape')";
                    }
                    else if (agencyName == "Fire")
                    {
                        query += " WHERE EmergencyType IN ('Fire', 'Burning', 'Explosion')";
                    }
                    else if (agencyName == "Ambulance")
                    {
                        query += " WHERE EmergencyType IN ('Medical Emergency', 'Accident', 'Heart Attack', 'Stroke', 'Injury', 'Childbirth')";
                    }
                    else if (agencyName == "Disaster")
                    {
                        query += " WHERE EmergencyType IN ('Flood', 'Earthquake', 'Typhoon', 'Landslide', 'Volcanic Eruption', 'Tsunami')";
                    }

                    query += " ORDER BY ReportDateTime DESC";

                    using (cmd = new OleDbCommand(query, myConn))
                    {
                        da = new OleDbDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds, "Reports");
                        dgvReports.DataSource = ds.Tables["Reports"];
                        lblReportCount.Text = $"Total Reports: {ds.Tables["Reports"].Rows.Count}";

                        // Set column widths 
                        dgvReports.Columns["ReportID"].Width = 80;
                        dgvReports.Columns["ResidentID"].Width = 100;
                        dgvReports.Columns["EmergencyType"].Width = 150;
                        dgvReports.Columns["Barangay"].Width = 150;
                        dgvReports.Columns["ReportDateTime"].Width = 150;
                        dgvReports.Columns["Status"].Width = 120;
                        dgvReports.Columns["Response"].Width = 200;
                        dgvReports.Columns["Latitude"].Width = 120;
                        dgvReports.Columns["Longitude"].Width = 120;
                        dgvReports.Columns["FullName"].Width = 150;
                        dgvReports.Columns["Address"].Width = 150;
                        dgvReports.Columns["ContactNumber"].Width = 120;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvReports.CurrentRow != null)
            {
                int reportID = Convert.ToInt32(dgvReports.CurrentRow.Cells["ReportID"].Value);
                string currentStatus = dgvReports.CurrentRow.Cells["Status"].Value.ToString();

                using (var statusDialog = new Form())
                {
                    statusDialog.Text = "Update Status";
                    statusDialog.Size = new Size(300, 150);
                    statusDialog.StartPosition = FormStartPosition.CenterParent;

                    Label lbl = new Label() { Left = 20, Top = 20, Text = "Select Status:" };
                    ComboBox cbo = new ComboBox() { Left = 0, Top = 45, Width = 240 };
                    cbo.Items.AddRange(new string[] { "Pending", "Responding", "Resolved", "Cancelled" });
                    cbo.SelectedItem = currentStatus;

                    Button btnOK = new Button() { Text = "OK", Left = 150, Top = 80, Width = 60 };
                    Button btnCancel = new Button() { Text = "Cancel", Left = 220, Top = 80, Width = 60 };

                    string newStatus = "";
                    btnOK.Click += (s, ev) => { newStatus = cbo.SelectedItem.ToString(); statusDialog.Close(); };
                    btnCancel.Click += (s, ev) => { statusDialog.Close(); };

                    statusDialog.Controls.Add(lbl);
                    statusDialog.Controls.Add(cbo);
                    statusDialog.Controls.Add(btnOK);
                    statusDialog.Controls.Add(btnCancel);

                    statusDialog.ShowDialog();

                    if (!string.IsNullOrEmpty(newStatus))
                    {
                        UpdateReportStatus(reportID, newStatus);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a report to update.", "No Selection");
            }
        }

        private void UpdateReportStatus(int reportID, string status)
        {
            try
            {
                using (myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();
                    string query = "UPDATE Reports SET Status = @Status WHERE ReportID = @ReportID";
                    using (cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@ReportID", reportID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Status updated to '{status}' successfully!");
                LoadReports();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void sendresponce_Click(object sender, EventArgs e)
        {
            SendResponce_Form sendResponce_Form = new SendResponce_Form(agencyName);
            sendResponce_Form.Show();
            this.Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Agency_Form agency = new Agency_Form();
            agency.Show();
            this.Hide();
        }

        private void btnViewOnMap_Click(object sender, EventArgs e)
        {
            if (dgvReports.CurrentRow != null)
            {
                object latValue = dgvReports.CurrentRow.Cells["Latitude"].Value;
                object lngValue = dgvReports.CurrentRow.Cells["Longitude"].Value;

                if (latValue != DBNull.Value && lngValue != DBNull.Value && latValue != null && lngValue != null)
                {
                    double lat = Convert.ToDouble(latValue);
                    double lng = Convert.ToDouble(lngValue);

              
                    string barangay = dgvReports.CurrentRow.Cells["Barangay"].Value.ToString();

                    string location = $"Emergency at {lat}, {lng}";
                    MapViewer_Form mapViewer = new MapViewer_Form(lat, lng, barangay, location);
                    
                    mapViewer.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No location coordinates found for this report.", "No Location",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a report first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
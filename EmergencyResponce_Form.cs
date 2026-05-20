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
    public partial class EmergencyResponce_Form : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Luke Jayden M. Ramos\Desktop\LukeCodeProject\OOP2ProjectTest\DataBase\Agency.accdb""";
        private OleDbConnection myConn;
        private OleDbCommand cmd;
        private OleDbDataAdapter da;
        private DataSet ds;

        public EmergencyResponce_Form()
        {
            InitializeComponent();
            LoadMyReports();
        }


       

        private void LoadMyReports()
        {
            try
            {
                using (myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();

                    // Fixed query - use proper column names that exist
                    string query = @"SELECT r.ReportID, r.EmergencyType, r.ReportDateTime, r.Status, r.Response, r.Latitude, r.Longitude, b.BarangayName as Barangay
                                    FROM Reports r
                                    INNER JOIN Barangay b ON r.BarangayID = b.BarangayID
                                    WHERE r.ResidentID = ?
                                    ORDER BY r.ReportDateTime DESC";

                    using (cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("?", Session.ResidentID);
                        da = new OleDbDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds, "Reports");
                        dgvMyReports.DataSource = ds.Tables["Reports"];

                        // Check if there are columns before setting widths
                        if (dgvMyReports.Columns.Count > 0)
                        {
                            if (dgvMyReports.Columns.Contains("ReportID"))
                                dgvMyReports.Columns["ReportID"].Width = 80;
                            if (dgvMyReports.Columns.Contains("EmergencyType"))
                                dgvMyReports.Columns["EmergencyType"].Width = 150;
                            if (dgvMyReports.Columns.Contains("Barangay"))
                                dgvMyReports.Columns["Barangay"].Width = 150;
                            if (dgvMyReports.Columns.Contains("ReportDateTime"))
                                dgvMyReports.Columns["ReportDateTime"].Width = 150;
                            if (dgvMyReports.Columns.Contains("Status"))
                                dgvMyReports.Columns["Status"].Width = 120;
                            if (dgvMyReports.Columns.Contains("Response"))
                                dgvMyReports.Columns["Response"].Width = 250;
                            if (dgvMyReports.Columns.Contains("Latitude"))
                                dgvMyReports.Columns["Latitude"].Width = 100;
                            if (dgvMyReports.Columns.Contains("Longitude"))
                                dgvMyReports.Columns["Longitude"].Width = 100;
                        }

                        lblReportCount.Text = $"Total Reports: {ds.Tables["Reports"].Rows.Count}";

                        // Count statuses
                        int pending = 0, responding = 0, resolved = 0;
                        foreach (DataRow row in ds.Tables["Reports"].Rows)
                        {
                            string status = row["Status"].ToString();
                            if (status == "Pending") pending++;
                            else if (status == "Responding") responding++;
                            else if (status == "Resolved") resolved++;
                        }
                        lblPendingCount.Text = $"Pending: {pending} | Responding: {responding} | Resolved: {resolved}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message);
            }
        }







        private void btnNewReport_Click(object sender, EventArgs e)
        {
            if (dgvMyReports.CurrentRow != null)
            {
                object latValue = dgvMyReports.CurrentRow.Cells["Latitude"].Value;
                object lngValue = dgvMyReports.CurrentRow.Cells["Longitude"].Value;

                if (latValue != DBNull.Value && lngValue != DBNull.Value && latValue != null && lngValue != null)
                {
                    double lat = Convert.ToDouble(latValue);
                    double lng = Convert.ToDouble(lngValue);
                    string barangay = dgvMyReports.CurrentRow.Cells["Barangay"].Value.ToString();
                    string location = $"Your emergency location";

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

        private void dgvMyReports_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvMyReports.CurrentRow != null && dgvMyReports.CurrentRow.Cells["Status"].Value != null)
            {
                string status = dgvMyReports.CurrentRow.Cells["Status"].Value.ToString();
                string emergencyType = dgvMyReports.CurrentRow.Cells["EmergencyType"].Value.ToString();
                DateTime reportDateTime = Convert.ToDateTime(dgvMyReports.CurrentRow.Cells["ReportDateTime"].Value);
                string response = dgvMyReports.CurrentRow.Cells["Response"].Value?.ToString() ?? "No response yet";

                lblStatus.Text = $"Status: {status}";
                lblEmergencyType.Text = $"Emergency: {emergencyType}";
                lblReportDate.Text = $"Reported: {reportDateTime.ToString("MM/dd/yyyy hh:mm tt")}";
                lblResponse.Text = $"Response: {response}";

                // Change color based on status
                if (status == "Pending")
                {
                    lblstatu.ForeColor = Color.Orange;
                    lblstatu.Text = "⏳ Status: Pending - Waiting for agency response";
                }
                else if (status == "Responding")
                {
                    lblstatu.ForeColor = Color.Blue;
                    lblstatu.Text = "🚑 Status: Responding - Agency is on the way";
                }
                else if (status == "Resolved")
                {
                    lblstatu.ForeColor = Color.Green;
                    lblstatu.Text = "✅ Status: Resolved - Emergency has been addressed";
                }
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            User_Form userForm = new User_Form();
            userForm.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

       

        private void emergencycontacts_Click(object sender, EventArgs e)
        {
            EmergencyContact_Form emergencyContact_Form = new EmergencyContact_Form();
            emergencyContact_Form.Show();
            this.Hide();
        }

        private void reportemergency_Click(object sender, EventArgs e)
        {
            ReportEmergency_Form reportEmergency_Form = new ReportEmergency_Form();
            reportEmergency_Form.Show();
            this.Hide();
        }

        private void EmergencyResponce_Form_Load(object sender, EventArgs e)
        {

        }

      
    }
}
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
    public partial class SendResponce_Form : Form
    {
        private string agencyName;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Luke Jayden M. Ramos\Desktop\lukeCodeProject\OOP2ProjectTest\DataBase\Agency.accdb""";
        private OleDbConnection myConn;
        private OleDbCommand cmd;
        private OleDbDataAdapter da;
        private DataSet ds;

        public SendResponce_Form(string agency)
        {
            InitializeComponent();
            agencyName = agency;
            this.Text = $"{agencyName} - Send Response";
            LoadPendingReports();
        }

        private void LoadPendingReports()
        {
            try
            {
                using (myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();

                    string query = "SELECT * FROM qryResidentReports WHERE Status = 'Pending'";

                    if (agencyName == "Police")
                    {
                        query += " AND EmergencyType IN ('Theft', 'Robbery', 'Assault', 'Violence', 'Murder', 'Rape')";
                    }
                    else if (agencyName == "Fire")
                    {
                        query += " AND EmergencyType IN ('Fire', 'Burning', 'Explosion')";
                    }
                    else if (agencyName == "Ambulance")
                    {
                        query += " AND EmergencyType IN ('Medical Emergency', 'Accident', 'Heart Attack', 'Stroke', 'Injury', 'Childbirth')";
                    }
                    else if (agencyName == "Disaster")
                    {
                        query += " AND EmergencyType IN ('Flood', 'Earthquake', 'Typhoon', 'Landslide', 'Volcanic Eruption', 'Tsunami')";
                    }

                    query += " ORDER BY ReportDateTime DESC";

                    using (cmd = new OleDbCommand(query, myConn))
                    {
                        da = new OleDbDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds, "Reports");
                        dgvPendingReports.DataSource = ds.Tables["Reports"];
                        lblPendingCount.Text = $"Pending Reports: {ds.Tables["Reports"].Rows.Count}";

                        dgvPendingReports.Columns["ReportID"].Width = 80;
                        dgvPendingReports.Columns["ResidentID"].Width = 100;
                        dgvPendingReports.Columns["EmergencyType"].Width = 150;
                        dgvPendingReports.Columns["Barangay"].Width = 150;
                        dgvPendingReports.Columns["ReportDateTime"].Width = 150;
                        dgvPendingReports.Columns["Status"].Width = 100;
                        dgvPendingReports.Columns["Response"].Width = 250;
                        dgvPendingReports.Columns["Latitude"].Width = 100;
                        dgvPendingReports.Columns["Longitude"].Width = 100;
                        dgvPendingReports.Columns["FullName"].Width = 150;
                        dgvPendingReports.Columns["Address"].Width = 150;
                        dgvPendingReports.Columns["ContactNumber"].Width = 120;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message);
            }
        }

        private void dgvPendingReports_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPendingReports.CurrentRow != null)
            {
                
                string residentName = dgvPendingReports.CurrentRow.Cells["FullName"].Value.ToString();
                string emergencyType = dgvPendingReports.CurrentRow.Cells["EmergencyType"].Value.ToString();
                string barangay = dgvPendingReports.CurrentRow.Cells["Barangay"].Value.ToString();

                txtResponseMessage.Text = $"Dear {residentName},\r\n\r\n" +
                                          $"This is the {agencyName} Department responding to your {emergencyType} emergency report in {barangay}.\r\n\r\n" +
                                          $"Our team is on the way to your location. Please stay calm and stay safe.\r\n\r\n" +
                                          $"Thank you,\r\n{agencyName} Emergency Response Team";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPendingReports();
        }

        private void btnSendResponse_Click(object sender, EventArgs e)
        {
            if (dgvPendingReports.CurrentRow != null)
            {
                string residentName = dgvPendingReports.CurrentRow.Cells["FullName"].Value.ToString();
                int reportID = Convert.ToInt32(dgvPendingReports.CurrentRow.Cells["ReportID"].Value);
                string message = txtResponseMessage.Text;

                if (string.IsNullOrWhiteSpace(message))
                {
                    MessageBox.Show("Please enter a response message.", "Validation Error");
                    return;
                }

                DialogResult result = MessageBox.Show($"Send response to {residentName}?\n\nMessage: {message}",
                    "Confirm Send", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    UpdateReportWithResponse(reportID, message);

                    MessageBox.Show($"Response sent to {residentName} successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadPendingReports();
                    txtResponseMessage.Clear();
                }
            }
        }

        private void UpdateReportWithResponse(int reportID, string message)
        {
            try
            {
                using (myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();
                    string query = "UPDATE Reports SET Status = 'Responding', Response = @Response WHERE ReportID = @ReportID";

                    using (cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@Response", message);
                        cmd.Parameters.AddWithValue("@ReportID", reportID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving response: " + ex.Message);
            }
        }

  
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agency_Form agencyForm = new Agency_Form();
            agencyForm.Show();
            this.Hide();
        }

        private void viewallreports_Click(object sender, EventArgs e)
        {
            ViewReports_Form view = new ViewReports_Form(agencyName);
            view.Show();
            this.Hide();
        }
    }
}
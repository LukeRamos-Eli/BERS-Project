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
using System.Windows.Forms.DataVisualization.Charting;

namespace OOP2ProjectTest
{
    public partial class Admins_Form : Form 
    {

        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Luke Jayden M. Ramos\Desktop\lukeCodeProject\OOP2ProjectTest\DataBase\Agency.accdb""";
        public Admins_Form()
        {
            InitializeComponent();
            LoadAllAnalytics();
        }

        private void mngeresident_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void emergencycontacts_Click(object sender, EventArgs e)
        {
            EmergencyContacts_Form frm = new EmergencyContacts_Form();
            frm.Show();
            this.Hide();
        }

        private void emergencyreports_Click(object sender, EventArgs e)
        {
            EmergencyReports_Form frm = new EmergencyReports_Form();
            frm.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }


        private void LoadAllAnalytics()
        {
            try
            {

                DataTable allReports = new DataTable();

                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM [Reports]", conn);
                    adapter.Fill(allReports);
                }

                if (allReports.Rows.Count == 0)
                {
                    MessageBox.Show("No reports found in database. Add some reports first.");
                    return;
                }

  
                int pending = 0, responding = 0, resolved = 0;

                foreach (DataRow row in allReports.Rows)
                {
                    string status = row["Status"].ToString();
                    if (status == "Pending") pending++;
                    else if (status == "Responding") responding++;
                    else if (status == "Resolved") resolved++;
                }

                chart1.Series.Clear();
                Series pieSeries = new Series("Reports by Status");
                pieSeries.ChartType = SeriesChartType.Pie;
                pieSeries.Points.Clear();

                if (pending > 0) pieSeries.Points.AddXY("Pending", pending);
                if (responding > 0) pieSeries.Points.AddXY("Responding", responding);
                if (resolved > 0) pieSeries.Points.AddXY("Resolved", resolved);

                pieSeries.IsValueShownAsLabel = true;
                chart1.Series.Add(pieSeries);
                chart1.Titles.Clear();
                chart1.Titles.Add("Emergency Reports by Status");

                int police = 0, fire = 0, ambulance = 0, disaster = 0;

                foreach (DataRow row in allReports.Rows)
                {
                    string type = row["EmergencyType"].ToString();
                    if (type == "Theft" || type == "Robbery" || type == "Assault" || type == "Violence" || type == "Murder" || type == "Rape")
                        police++;
                    else if (type == "Fire" || type == "Burning" || type == "Explosion")
                        fire++;
                    else if (type == "Medical Emergency" || type == "Accident" || type == "Heart Attack" || type == "Stroke" || type == "Injury" || type == "Childbirth")
                        ambulance++;
                    else if (type == "Flood" || type == "Earthquake" || type == "Typhoon" || type == "Landslide" || type == "Volcanic Eruption" || type == "Tsunami")
                        disaster++;
                }

                chartAgency.Series.Clear();
                Series agencySeries = new Series("Reports by Agency");
                agencySeries.ChartType = SeriesChartType.Bar;
                agencySeries.Points.Clear();

                if (police > 0) agencySeries.Points.AddXY("Police", police);
                if (fire > 0) agencySeries.Points.AddXY("Fire", fire);
                if (ambulance > 0) agencySeries.Points.AddXY("Ambulance", ambulance);
                if (disaster > 0) agencySeries.Points.AddXY("Disaster", disaster);

                agencySeries.IsValueShownAsLabel = true;
                chartAgency.Series.Add(agencySeries);
                chartAgency.Titles.Clear();
                chartAgency.Titles.Add("Emergency Reports by Agency");

                Dictionary<string, int> barangayCounts = new Dictionary<string, int>();
                int nullBarangayCount = 0;


                Dictionary<int, string> barangayNames = new Dictionary<int, string>();
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("SELECT BarangayID, BarangayName FROM [Barangay]", conn);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        barangayNames[Convert.ToInt32(reader["BarangayID"])] = reader["BarangayName"].ToString();
                    }
                    conn.Close();
                }

                foreach (DataRow row in allReports.Rows)
                {
             
                    if (row["BarangayID"] == DBNull.Value)
                    {
                        nullBarangayCount++;
                        continue;
                    }

                    int barangayID = Convert.ToInt32(row["BarangayID"]);
                    string barangayName = barangayNames.ContainsKey(barangayID) ? barangayNames[barangayID] : $"Barangay {barangayID}";

                    if (barangayCounts.ContainsKey(barangayName))
                        barangayCounts[barangayName]++;
                    else
                        barangayCounts[barangayName] = 1;
                }

                chartBarangay.Series.Clear();
                Series barangaySeries = new Series("Reports by Barangay");
                barangaySeries.ChartType = SeriesChartType.Bar;
                barangaySeries.Points.Clear();

 
                foreach (var item in barangayCounts)
                {
                    barangaySeries.Points.AddXY(item.Key, item.Value);
                }

             
                if (nullBarangayCount > 0)
                {
                    barangaySeries.Points.AddXY("Unknown Barangay", nullBarangayCount);
                }

                if (barangayCounts.Count == 0 && nullBarangayCount == 0)
                {
                    barangaySeries.Points.AddXY("No Data", 0);
                }

                barangaySeries.IsValueShownAsLabel = true;
                chartBarangay.Series.Add(barangaySeries);
                chartBarangay.Titles.Clear();
                chartBarangay.Titles.Add("Emergency Reports by Barangay");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading analytics: " + ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2ProjectTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            load();
        }

        OleDbConnection myConn;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;
        int indexRow;

        private void load()
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Luke Jayden M. Ramos\\Desktop\\lukeCodeProject\\OOP2ProjectTest\\DataBase\\Agency.accdb\"");

          
            string query = @"SELECT r.ResidentID, r.FirstName, r.LastName, r.Address, r.ContactNumber, 
                            r.Profession, r.SpecialSkills, r.VulnerabilityCategory, 
                            b.BarangayName, r.BarangayID
                     FROM Resident r 
                     INNER JOIN Barangay b ON r.BarangayID = b.BarangayID";

            da = new OleDbDataAdapter(query, myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Resident");
            dataGridView1.DataSource = ds.Tables["Resident"];

           
            dataGridView1.Columns["ResidentID"].Width = 120;
            dataGridView1.Columns["FirstName"].Width = 150;
            dataGridView1.Columns["LastName"].Width = 150;
            dataGridView1.Columns["Address"].Width = 150;
            dataGridView1.Columns["ContactNumber"].Width = 130;
            dataGridView1.Columns["Profession"].Width = 120;
            dataGridView1.Columns["SpecialSkills"].Width = 150;
            dataGridView1.Columns["VulnerabilityCategory"].Width = 300;
            dataGridView1.Columns["BarangayName"].Width = 300; 
            dataGridView1.Columns["BarangayName"].HeaderText = "Barangay";
            if (dataGridView1.Columns.Contains("BarangayID"))
                dataGridView1.Columns["BarangayID"].Visible = false;

            
            int totalResidents = ds.Tables["Resident"].Rows.Count;
            lblTotalResidents.Text = $"Total Residents: {totalResidents}";

            myConn.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query = "INSERT INTO Resident (FirstName, LastName, Address, ContactNumber, Profession, SpecialSkills, VulnerabilityCategory) VALUES " +
                    "(@FirstName, @LastName, @Address, @ContactNumber, @Profession, @SpecialSkills, @VulnerabilityCategory)";

                myConn.Open();
                cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@FirstName", firstname.Text);
                cmd.Parameters.AddWithValue("@LastName", lastname.Text);
                cmd.Parameters.AddWithValue("@Address", address.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", contactnumber.Text);
                cmd.Parameters.AddWithValue("@Profession", profession.Text);
                cmd.Parameters.AddWithValue("@SpecialSkills", specialskills.Text);
                cmd.Parameters.AddWithValue("@VulnerabilityCategory", vulnerability.Text);

                cmd.ExecuteNonQuery();
                myConn.Close();

                MessageBox.Show("Record added successfully!");
                load();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                myConn.Close();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID.Text))
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            try
            {
               
                int barangayID = GetBarangayIDByName(txtBarangay.Text);

                if (barangayID == 0)
                {
                    MessageBox.Show("Invalid Barangay name selected.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

          
                string query = @"UPDATE Resident SET FirstName = @FirstName, LastName = @LastName, 
                         Address = @Address, ContactNumber = @ContactNumber, 
                         Profession = @Profession, SpecialSkills = @SpecialSkills, 
                         VulnerabilityCategory = @VulnerabilityCategory, 
                         BarangayID = @BarangayID 
                         WHERE ResidentID = @ResidentID";

                myConn.Open();
                cmd = new OleDbCommand(query, myConn);

                cmd.Parameters.AddWithValue("@FirstName", firstname.Text);
                cmd.Parameters.AddWithValue("@LastName", lastname.Text);
                cmd.Parameters.AddWithValue("@Address", address.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", contactnumber.Text);
                cmd.Parameters.AddWithValue("@Profession", profession.Text);
                cmd.Parameters.AddWithValue("@SpecialSkills", specialskills.Text);
                cmd.Parameters.AddWithValue("@VulnerabilityCategory", vulnerability.Text);
                cmd.Parameters.AddWithValue("@BarangayID", barangayID);
                cmd.Parameters.AddWithValue("@ResidentID", Convert.ToInt32(ID.Text));

                cmd.ExecuteNonQuery();
                myConn.Close();

                MessageBox.Show("Record updated successfully!");
                load();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                myConn.Close();
            }
        }

        private int GetBarangayIDByName(string barangayName)
        {
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Luke Jayden M. Ramos\\Desktop\\lukeCodeProject\\OOP2ProjectTest\\DataBase\\Agency.accdb\"");
                myConn.Open();
                string query = "SELECT BarangayID FROM Barangay WHERE BarangayName = @name";
                cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@name", barangayName);
                object result = cmd.ExecuteScalar();
                myConn.Close();

                return result != null ? Convert.ToInt32(result) : 0;
            }
            catch
            {
                return 0;
            }
        }
       
        private void delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID.Text))
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Resident WHERE ResidentID = @ResidentID";
                    myConn.Open();
                    cmd = new OleDbCommand(query, myConn);
                    cmd.Parameters.AddWithValue("@ResidentID", Convert.ToInt32(ID.Text));
                    cmd.ExecuteNonQuery();
                    myConn.Close();

                    MessageBox.Show("Record deleted successfully!");
                    load();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    myConn.Close();
                }
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchs.Text))
                {
                    MessageBox.Show("Please enter search criteria.", "Search Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string searchTerm = searchs.Text.Trim();

                string query = @"SELECT r.ResidentID, r.FirstName, r.LastName, r.Address, r.ContactNumber, 
                                r.Profession, r.SpecialSkills, r.VulnerabilityCategory, b.BarangayName 
                         FROM Resident r 
                         INNER JOIN Barangay b ON r.BarangayID = b.BarangayID
                         WHERE r.FirstName LIKE @search OR 
                               r.LastName LIKE @search OR 
                               r.Address LIKE @search OR 
                               r.ContactNumber LIKE @search OR 
                               r.Profession LIKE @search OR 
                               r.SpecialSkills LIKE @search OR 
                               r.VulnerabilityCategory LIKE @search OR
                               b.BarangayName LIKE @search";

                myConn.Open();
                cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                da = new OleDbDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Resident");

                dataGridView1.DataSource = ds.Tables["Resident"];


                int resultCount = ds.Tables["Resident"].Rows.Count;
                lblTotalResidents.Text = $"Search Results: {resultCount}";

                if (resultCount == 0)
                {
                    MessageBox.Show("No records found matching: " + searchTerm, "Search Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Found {resultCount} record(s).",
                        "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            ID.Clear();
            firstname.Clear();
            lastname.Clear();
            address.Clear();
            contactnumber.Clear();
            profession.Clear();
            specialskills.Clear();
            vulnerability.Clear();
            txtBarangay.Clear();
            hiddenBarangayID.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admins_Form admins_Form = new Admins_Form();
            admins_Form.Show();
            this.Hide();
        }

        private void emergencycontacts_Click(object sender, EventArgs e)
        {
            EmergencyContacts_Form emergencyContacts_Form = new EmergencyContacts_Form();
            emergencyContacts_Form.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Hide();
        }

        private void emergencyreports_Click(object sender, EventArgs e)
        {
            EmergencyReports_Form emergencyReports_Form = new EmergencyReports_Form();
            emergencyReports_Form.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[indexRow];

                ID.Text = row.Cells["ResidentID"].Value.ToString();
                firstname.Text = row.Cells["FirstName"].Value.ToString();
                lastname.Text = row.Cells["LastName"].Value.ToString();
                address.Text = row.Cells["Address"].Value.ToString();
                contactnumber.Text = row.Cells["ContactNumber"].Value.ToString();
                profession.Text = row.Cells["Profession"].Value.ToString();
                specialskills.Text = row.Cells["SpecialSkills"].Value.ToString();
                vulnerability.Text = row.Cells["VulnerabilityCategory"].Value.ToString();


                txtBarangay.Text = row.Cells["BarangayName"].Value.ToString();
                hiddenBarangayID.Text = row.Cells["BarangayID"].Value.ToString();
            }
        }
        private void label12_Click(object sender, EventArgs e){}
    }
}

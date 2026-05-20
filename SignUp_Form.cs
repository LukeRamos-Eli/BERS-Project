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
    public partial class SignUp_Form : Form
    {

        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Luke Jayden M. Ramos\Desktop\lukeCodeProject\OOP2ProjectTest\DataBase\Agency.accdb""";
        private OleDbConnection myConn;
        private OleDbCommand cmd;
        private OleDbDataAdapter da;
        private DataSet ds;


        public SignUp_Form()
        {
            InitializeComponent();
            LoadBarangays();
            LoadVulnerabilityCategories();
        }

        private void LoadBarangays()
        {
            try
            {
                using (myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();
                    string query = "SELECT BarangayID, BarangayName FROM Barangay ORDER BY BarangayName";
                    cmd = new OleDbCommand(query, myConn);
                    da = new OleDbDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "Barangay");

                    cboBarangay.DisplayMember = "BarangayName";
                    cboBarangay.ValueMember = "BarangayID";
                    cboBarangay.DataSource = ds.Tables["Barangay"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading barangays: " + ex.Message);
            }
        }

        private void LoadVulnerabilityCategories()
        {
            cboVulnerability.Items.AddRange(new string[]
            {
                "None",
                "Elderly (Senior Citizen)",
                "PWD (Person with Disability)",
                "Pregnant",
                "Solo Parent",
                "Child",
                "With Medical Condition"
            });
            cboVulnerability.SelectedIndex = 0;
        }

        private bool ValidateInputs()
        {
        
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            if (cboBarangay.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Barangay.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboBarangay.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Please enter Contact Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter Username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            if (txtPassword.Text.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private bool IsUsernameExists(string username)
        {
            try
            {
                using (myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();
                    string query = "SELECT COUNT(*) FROM Resident WHERE Username = @username";
                    using (cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking username: " + ex.Message);
                return true;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            string username = txtUsername.Text.Trim();

          
            if (IsUsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                txtUsername.SelectAll();
                return;
            }

           
            SaveResident();
        }

        private void SaveResident()
        {
            try
            {
                using (myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();

                   
                    string query = @"INSERT INTO Resident 
                            ([FirstName], [LastName], [BarangayID], [Address], [ContactNumber], 
                             [Profession], [SpecialSkills], [VulnerabilityCategory], 
                             [Username], [Password]) 
                            VALUES 
                            (@FirstName, @LastName, @BarangayID, @Address, @ContactNumber, 
                             @Profession, @SpecialSkills, @VulnerabilityCategory, 
                             @Username, @Password)";

                    using (cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@BarangayID", Convert.ToInt32(cboBarangay.SelectedValue));
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@Profession", txtProfession.Text.Trim());
                        cmd.Parameters.AddWithValue("@SpecialSkills", txtSkills.Text.Trim());
                        cmd.Parameters.AddWithValue("@VulnerabilityCategory", cboVulnerability.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration Successful!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("No rows were inserted.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving resident: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            cboBarangay.SelectedIndex = -1;
            txtAddress.Clear();
            txtContact.Clear();
            txtProfession.Clear();
            txtSkills.Clear();
            cboVulnerability.SelectedIndex = 0;
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtFirstName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

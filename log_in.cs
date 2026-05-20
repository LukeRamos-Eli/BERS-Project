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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OOP2ProjectTest
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Luke Jayden M. Ramos\Desktop\lukeCodeProject\OOP2ProjectTest\DataBase\Agency.accdb""";

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;

         
            if (AuthenticateUser(username, password))
            {
                string agencyName = GetAgencyName(username);

                
                if (agencyName == "Admin")
                {
                    MessageBox.Show("Admin login successful!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Admins_Form adminForm = new Admins_Form();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
               
                    MessageBox.Show($"Login successful! Welcome {agencyName} - {username}", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Agency_Form agencyForm = new Agency_Form();
                    agencyForm.SetAgency(agencyName);
                    agencyForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Password.Clear();
                Password.Focus();
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            bool isValid = false;

            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();
                    string query = "SELECT COUNT(*) FROM [Agency] WHERE [Username] = @username AND [Password] = @password";

                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isValid = (count == 1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        private string GetAgencyName(string username)
        {
            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();
                    string query = "SELECT [Agency] FROM [Agency] WHERE [Username] = @username";

                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        return cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting agency name: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
    }
}

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
    public partial class ResidentLogin_Form : Form
    {

        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Luke Jayden M. Ramos\Desktop\lukeCodeProject\OOP2ProjectTest\DataBase\Agency.accdb""";

        public ResidentLogin_Form()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }


        private void SignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp_Form signUp_Form = new SignUp_Form();
            signUp_Form.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username and Password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AuthenticateUser(username, password))
            {
                
                Session.ResidentID = GetResidentID(username);
                Session.ResidentName = GetResidentFullName(username);
                Session.Username = username;
                Session.FullName = GetResidentFullName(username);

                MessageBox.Show($"Welcome {Session.ResidentName}!\nLogin successful.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                User_Form userForm = new User_Form();
                userForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please try again.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();
                    string query = "SELECT COUNT(*) FROM Resident WHERE Username = @username AND Password = @password";
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                return false;
            }
        }

        private int GetResidentID(string username)
        {
            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();
                    string query = "SELECT ResidentID FROM Resident WHERE Username = @username";
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
                return 0;
            }
        }

        private string GetResidentFullName(string username)
        {
            try
            {
                using (OleDbConnection myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();
                    string query = "SELECT FirstName & ' ' & LastName FROM Resident WHERE Username = @username";
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        return cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch
            {
                return "Resident";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }
    }
}

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
    public partial class Agency_Form : Form
    {
        private string loggedInAgency = "";

        public Agency_Form()
        {
            InitializeComponent();
        }

        public void SetAgency(string agencyName)
        {
            loggedInAgency = agencyName;
            this.Text = $"{agencyName} - BERS Dashboard";
        }

       
        private void viewallreports_Click(object sender, EventArgs e)
        {
            ViewReports_Form viewReports = new ViewReports_Form(loggedInAgency);
            viewReports.Show();
            this.Hide();
        }

        private void sendresponce_Click(object sender, EventArgs e)
        {
            SendResponce_Form sendResponse = new SendResponce_Form(loggedInAgency);
            sendResponse.Show   ();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}

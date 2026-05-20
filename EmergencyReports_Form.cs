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
    public partial class EmergencyReports_Form : Form
    {
        public EmergencyReports_Form()
        {
            InitializeComponent();
        }

        OleDbConnection myConn;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;

        private void load_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Luke Jayden M. Ramos\\Desktop\\lukeCodeProject\\OOP2ProjectTest\\DataBase\\Agency.accdb\"");

            
            da = new OleDbDataAdapter("SELECT * FROM qryResidentReports", myConn);

            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "qryResidentReports");
            dataGridView1.DataSource = ds.Tables["qryResidentReports"];

            int totalReports = ds.Tables["qryResidentReports"].Rows.Count;
            reportcount.Text = $"Total Reports: {totalReports}";

            myConn.Close();
        }



        private void mngeresident_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void emergencycontacts_Click(object sender, EventArgs e)
        {
            EmergencyContacts_Form emergency = new EmergencyContacts_Form();
            emergency.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admins_Form adminsForm = new Admins_Form();
            adminsForm.Show();
            this.Hide();
        }

        private void emergencyreports_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}

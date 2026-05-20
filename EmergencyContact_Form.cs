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
    public partial class EmergencyContact_Form : Form
    {
        public EmergencyContact_Form()
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
            da = new OleDbDataAdapter("SELECT * FROM EmergencyContact", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "EmergencyContact");
            dataGridView1.DataSource = ds.Tables["EmergencyContact"];


            dataGridView1.Columns["ID"].Width = 50;
            dataGridView1.Columns["ServiceType"].Width = 200;
            dataGridView1.Columns["OrganizationName"].Width = 300;
            dataGridView1.Columns["ContactNumber"].Width = 200;
            dataGridView1.Columns["Location"].Width = 200;
            dataGridView1.Columns["Notes"].Width = 270;

            myConn.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            User_Form userForm = new User_Form();
            userForm.Show();
            this.Hide();
        }

       

        private void emergencyresponce_Click(object sender, EventArgs e)
        {
            EmergencyResponce_Form emergencyResponce_Form = new EmergencyResponce_Form();
            emergencyResponce_Form.Show();
            this.Hide();
        }

        private void reportemergency_Click(object sender, EventArgs e)
        {
            ReportEmergency_Form reportEmergency_Form = new ReportEmergency_Form();
            reportEmergency_Form.Show();
            this.Hide();
        }

        
    }
}

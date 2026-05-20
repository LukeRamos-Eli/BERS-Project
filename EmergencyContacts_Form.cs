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
    public partial class EmergencyContacts_Form : Form
    {
        public EmergencyContacts_Form()
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

       

        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void mngeresident_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void EmergencyContacts_Form_Load(object sender, EventArgs e)
        {

        }

        private void emergencyreports_Click(object sender, EventArgs e)
        {
            EmergencyReports_Form emergency = new EmergencyReports_Form();
            emergency.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admins_Form ad = new Admins_Form();
            ad.Show();
            this.Hide();
        }

       
    }
}

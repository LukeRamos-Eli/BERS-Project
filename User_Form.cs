using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2ProjectTest
{
    public partial class User_Form : Form
    {

        private int currentResidentID;
        private string currentResidentName;


        public User_Form()
        {
            InitializeComponent();
            
        }

      

        private void emergencycontacts_Click(object sender, EventArgs e)
        {
            EmergencyContact_Form emergencycontacts = new EmergencyContact_Form();
            emergencycontacts.Show();
            this.Hide();
        }

        private void reportemergency_Click(object sender, EventArgs e)
        {
            ReportEmergency_Form reportEmergency_Form = new ReportEmergency_Form();
            reportEmergency_Form.Show();
            this.Hide();
        }

        private void emergencyresponce_Click(object sender, EventArgs e)
        {
            EmergencyResponce_Form emergencyResponce_Form = new EmergencyResponce_Form();
            emergencyResponce_Form.Show();
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

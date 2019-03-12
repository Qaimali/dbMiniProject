using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMiniProject
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            
            if (radioMale.Checked)
            {
                string query = string.Format("insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values('{0}','{1}','{2}','{3}','{4}',(select id from Lookup where Value='Male'))", txtFirstName.Text, txtLastName.Text, txtContact.Text, txtEmail.Text, txtDob.Text);
                DataBaseConnection.getInstance().executeQuery(query);
            }
            else
            {
                string query = string.Format("insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values('{0}','{1}','{2}','{3}','{4}',(select id from Lookup where Value='Female'))", txtFirstName.Text, txtLastName.Text, txtContact.Text, txtEmail.Text, txtDob.Text);
                DataBaseConnection.getInstance().executeQuery(query);
            }
            
            string totalStudent = "select count(*) from Person ";
            var readPersonLen = DataBaseConnection.getInstance().getRowsCount(totalStudent);
            string query2 = string.Format("insert into Student(id,RegistrationNo) values('{0}','{1}')", readPersonLen, txtRegNo.Text);
            DataBaseConnection.getInstance().executeQuery(query2);
            txtRegNo.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtEmail.Text = "";
            txtDob.Text = "";
            txtContact.Text = "";
            radioFemale.Checked = false;
            radioMale.Checked = false;

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            //DataBaseConnection.getInstance().conStr = "Data Source=DESKTOP-3RUJBK3\\SQLEXPRESS;Initial Catalog=deProjectMini;Integrated Security=True";
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePage hom = new HomePage();
            hom.Show();
            this.Hide();
        }

        private void addProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addProject ap = new addProject();
            ap.Show();
            this.Hide();
        }

        private void addAdvisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAdvisor ad = new addAdvisor();
            ad.Show();
            this.Hide();
        }

        private void makeGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeGroup mk = new MakeGroup();
            mk.Show();
            this.Hide();
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group gp = new Group();
            gp.Show();
            this.Hide();
        }
    }
}

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
    public partial class addAdvisor : Form
    {
        public addAdvisor()
        {
            InitializeComponent();
        }

        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into Advisor(Designation,Salary) values((select id from Lookup where Value='"+comboAddesig.Text+"'),'{0}')", txtAdSalary.Text);
            DataBaseConnection.getInstance().executeQuery(query);
            comboAddesig.Text = "";
            txtAdSalary.Text = "";
        }

        private void addAdvisor_Load(object sender, EventArgs e)
        {
            string query = String.Format("select Value from Lookup where Category='DESIGNATION'");
            var des=DataBaseConnection.getInstance().readData(query);
            while (des.Read())
            {
               comboAddesig.Items.Add(des.GetString(0));
            }

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePage hom = new HomePage();
            hom.Show();
            this.Hide();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent adSt = new AddStudent();
            adSt.Show();
            this.Hide();
        }

        private void addProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addProject ap = new addProject();
            ap.Show();
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

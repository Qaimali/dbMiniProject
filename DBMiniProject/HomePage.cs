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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStu= new AddStudent();
            addStu.Show();
            this.Hide();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            addProject addPro = new addProject();
            addPro.Show();
            this.Hide(); 

        }

        private void btnAddAdvisor_Click(object sender, EventArgs e)
        {
            addAdvisor addadvis = new addAdvisor();
            addadvis.Show();
            this.Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            DataBaseConnection.getInstance().conStr = "Data Source=DESKTOP-3RUJBK3\\SQLEXPRESS;Initial Catalog=deProjectMini;Integrated Security=True";

        }

        private void btnMakeGroup_Click(object sender, EventArgs e)
        {
            MakeGroup mak = new MakeGroup();
            mak.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group gp = new Group();
            gp.Show();
            this.Hide();
        }
    }
}

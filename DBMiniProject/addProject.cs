using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DBMiniProject
{
    public partial class addProject : Form
    {
        public addProject()
        {
            InitializeComponent();
        }
       // DataBaseConnection.getInstance().conStr = "Data Source=DESKTOP-3RUJBK3\\SQLEXPRESS;Initial Catalog=deProjectMini;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {

            string query = string.Format("insert into Project(Description,Title) values('{0}','{1}')", textBox2.Text, textBox1.Text);
            DataBaseConnection.getInstance().executeQuery(query);

         
        }

        private void addProject_Load(object sender, EventArgs e)
        {
            //DataBaseConnection.getInstance().conStr= "Data Source=DESKTOP-3RUJBK3\\SQLEXPRESS;Initial Catalog=deProjectMini;Integrated Security=True";

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

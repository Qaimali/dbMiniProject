using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace DBMiniProject
{
    public partial class MakeGroup : Form
    {
        public MakeGroup()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        private void MakeGroup_Load(object sender, EventArgs e)
        {
            Auto();
        }
        public void Auto()

        {
            

            string st = string.Format("select RegistrationNo from Student left join GroupStudent on Student.Id=GroupStudent.StudentId where GroupStudent.StudentId is null ");
            da = DataBaseConnection.getInstance().getAllData(st);
            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)

            {

                for (int i = 0; i < dt.Rows.Count; i++)

                {

                    coll.Add(dt.Rows[i]["RegistrationNo"].ToString());

                }

            }
            else

            {

                MessageBox.Show("No Free Student  found");

            }

            txtRegistrationSearch.AutoCompleteMode = AutoCompleteMode.Suggest;

            txtRegistrationSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtRegistrationSearch.AutoCompleteCustomSource = coll;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        List<int> stud_list = new List<int>();//contain id of searched students
        private void txtRegistrationSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query =string.Format("insert into GroupOne(Created_On) values('{0}')",DateTime.Now);
            DataBaseConnection.getInstance().executeQuery(query);
            string groupQuery = "select * from GroupOne";
           var groupList = DataBaseConnection.getInstance().readData(groupQuery);
           List<int> intList = new List<int>();
            while (groupList.Read())
            {
                intList.Add(groupList.GetInt32(0));
            }
            int count = intList.Count();
            foreach(student ob in st_M) 
            {
                string query2 = string.Format("insert into GroupStudent(GroupId,StudentId,Status,AssignmentDate) values('{0}','{1}',(select id from Lookup where Value='InActive'),'{2}')", intList[count-1], ob.Id, DateTime.Now);
                DataBaseConnection.getInstance().executeQuery(query2);
            }
            txtRegistrationSearch.Text = "";
            dataGridView1.DataSource = null;
         
        }
        List<student> st_M = new List<student>();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = string.Format("select id from Student where RegistrationNo='" + txtRegistrationSearch.Text + "'");

            var getId = DataBaseConnection.getInstance().readData(query);

            while (getId.Read())
            {
                stud_list.Add(getId.GetInt32(0));
            }

            List<student> st_L = new List<student>();

            foreach (int std in stud_list)
            {
                string query2 = string.Format("select Student.RegistrationNo , FirstName,Email from Person join Student on Person.id=Student.id where Person.id='{0}'", std);
                var result = DataBaseConnection.getInstance().readData(query2);
                while (result.Read())
                {
                    if (result.GetString(0) != "" && result.GetString(2) != "" && result.GetString(1) != "")
                    {
                        student s = new student();
                        s.RegistrationNumber = result.GetString(0);
                        s.Name = result.GetString(1);
                        s.Email = result.GetString(2);
                        s.Id = Convert.ToString(std);
                        st_L.Add(s);
                    }
                }
            }
            st_L = st_L.Distinct().ToList();
            BindingSource si = new BindingSource();
            si.DataSource = st_L;
            dataGridView1.DataSource = si;
            st_M = st_L;
            txtRegistrationSearch.Text = "";
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

        private void addAdvisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAdvisor ad = new addAdvisor();
            ad.Show();
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

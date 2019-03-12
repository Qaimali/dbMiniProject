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
    public partial class Group : Form
    {
        public Group()
        {
            InitializeComponent();
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioActive_CheckedChanged(object sender, EventArgs e)
        {
            dgGroups.Visible = false;
            dataGridView1.Visible = true;
        }
        
        private void Group_Load(object sender, EventArgs e)
        {
            dgGroups.Visible = false;
           
        }
        List<student> list_M = new List<student>();
        private void radioInActive_CheckedChanged(object sender, EventArgs e)
        {
            List<student> list_L = new List<student>();
            if (radioInActive.Checked)
            {
                
                string query = "select GroupId,AssignmentDate,Student.RegistrationNo,Person.FirstName from GroupStudent join Student on Student.Id=GroupStudent.StudentId join Person on Student.Id=Person.Id where GroupStudent.Status=4";
                var result = DataBaseConnection.getInstance().readData(query);
                while (result.Read())
                {
                    student s = new student();
                    s.GroupAssignmentDate = result.GetDateTime(1).ToString("dd-MM-yyyy");
                    s.GroupId = Convert.ToString(result.GetInt32(0));
                    s.Name = result.GetString(3);
                    s.GroupStatus = "In Active";
                    s.RegistrationNumber = result.GetString(2);
                    list_L.Add(s);
                }
            }
            list_M = list_L;
            dataGridView1.Visible = false;
            dgGroups.Visible = true;
            BindingSource source = new BindingSource();
            source.DataSource = list_M;
            dgGroups.DataSource = source;
        }

        private void dgGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                MessageBox.Show("hello");
            }
        }
    }
}

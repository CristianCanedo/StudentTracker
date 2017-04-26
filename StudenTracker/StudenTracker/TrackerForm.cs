using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTracker
{
    public partial class ShowTracker : Form
    {
        public ShowTracker()
        {
            InitializeComponent();
        }

        private void ShowTracker_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<Student> studentList;
            try
            {
                studentList = StudentDB.GetStudent();
                if (studentList.Count > 0)
                {
                    Student student = new Student();
                    for (int i = 0; i < studentList.Count; i++)
                    {
                        student = studentList[i];
                        listView1.Items.Add(student.StudentID.ToString());
                        listView1.Items[i].SubItems.Add(student.FirstName);
                        listView1.Items[i].SubItems.Add(student.LastName);
                        listView1.Items[i].SubItems.Add(student.Field);
                        listView1.Items[i].SubItems.Add(student.Date);
                        listView1.Items[i].SubItems.Add(student.Age.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("There are no students in list.", "Alert");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }


        }

        
    }
}

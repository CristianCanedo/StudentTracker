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
    public partial class StudentTracker : Form
    {
        public StudentTracker()
        {
            InitializeComponent();
        }


        private void btn_Tracker_Click(object sender, EventArgs e)
        {
            btn_Tracker.Enabled = false;

            ShowTracker tracker = new ShowTracker();
            tracker.Show();

            btn_Tracker.Enabled = true;
        }


        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            btn_AddStudent.Enabled = false;
            AddStudent addNew = new AddStudent();
            addNew.Show();
            btn_AddStudent.Enabled = true;
        }

        private void StudentTracker_Load(object sender, EventArgs e)
        {

        }
    }
}

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

namespace StudentTracker
{
    public partial class AddStudent : Form
    {
        
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_RetrieveStudent_Click(object sender, EventArgs e)
        {
            StudentDB.AddStudent(txtFirstName.Text, txtLastName.Text, txtField.Text, txtDate.Text, txtAge.Text);
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtField.Text = "";
            txtDate.Text = "";
            txtAge.Text = "";
            this.AddStudent_Load(this, null);

            MessageBox.Show("Saved!");

        }

    }
}

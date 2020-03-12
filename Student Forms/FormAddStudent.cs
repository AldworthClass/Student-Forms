using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Forms
{
    public partial class FormAddStudent : Form
    {
        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Trim().Length > 0 && txtLastName.Text.Trim().Length > 0)
            {
                FormMain.students.Add(new Student(txtFirstName.Text.Trim(), txtLastName.Text.Trim()));
                this.Dispose();
            }
            else
                MessageBox.Show("Please enter a valid first and last name");
        }
    }
}

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
    public partial class FormEdit : Form
    {
        Student student;
        public FormEdit(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            lblOriginaLastlName.Text = "Old Last Name: " + student.LastName;
            lblOriginalFirstName.Text = "Old FirstName: " + student.FirstName;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Trim().Length > 0)
                student.FirstName = txtFirstName.Text.Trim();
            if (txtLastName.Text.Trim().Length > 0)
                student.LastName = txtLastName.Text.Trim();
            this.Dispose();
        }
    }
}

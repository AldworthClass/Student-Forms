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
            this.Close();
        }
    }
}

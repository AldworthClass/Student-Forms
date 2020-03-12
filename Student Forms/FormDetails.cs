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
    public partial class FormDetails : Form
    {
        Student student;
        public FormDetails(Student student)
        {
            this.student = student;
            InitializeComponent();
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            lblEmail.Text = student.Email;
            lblFirst.Text = student.FirstName;
            lblLast.Text = student.LastName;
            lblStudentNum.Text = student.StudentNumber + "";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

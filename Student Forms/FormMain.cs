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
    public partial class FormMain : Form
    {
        
        public static List<Student> students = new List<Student>();
        public static List<string> garbage = new List<string>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students.Add(new Student("Bart", "Simpson"));
            students.Add(new Student("Lisa", "Simpson"));
            students.Add(new Student("Martin", "Prince"));
            students.Add(new Student("Nelson", "Muntz"));
            students.Add(new Student("Ralph", "Wiggum"));
            refreshListBox();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().Length == 0)
            {
                refreshListBox();
            }
            else
            {
                lstStudents.DataSource = null;  //Allows ListBox contents to be cleared
                lstStudents.Items.Clear();      //Clears students from revious searches
                foreach (Student student in students)
                {
                    if (student.ToString().ToUpper().Contains(txtSearch.Text.Trim().ToUpper()))   //Case insensitive seach
                        lstStudents.Items.Add(student);
                }
            }   
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            students.Remove((Student)lstStudents.SelectedItem);
            lstStudents.Items.Remove(lstStudents.SelectedItem);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormAddStudent frmAddStudent = new FormAddStudent();
            frmAddStudent.ShowDialog();
            refreshListBox();
        }
        private void refreshListBox()
        {
            students.Sort();
            lstStudents.DataSource = null;
            lstStudents.DataSource = students;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}

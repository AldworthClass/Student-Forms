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
    public partial class Form1 : Form
    {
        
        public static List<Student> students = new List<Student>();
        public static List<string> garbage = new List<string>();
        public Form1()
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
            lstStudents.DataSource = students;
        }
    }
}

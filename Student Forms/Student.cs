﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Forms
{
    public class Student : IComparable<Student>
    {       
        private static Random generator = new Random();
        private string firstName;
        private string lastName;
        private string email;
        private int studentNumber;
        
        public Student(string firstName, string lastName)
        {
            //Random generator = new Random();
            this.firstName = firstName.Trim();
            this.lastName = lastName.Trim();
            studentNumber = generator.Next(0, 1000) + 555000;
            GenerateEmail();
        }
        public Student(string firstName, string lastName, int studentNumber)
        {
            //Random generator = new Random();
            this.firstName = firstName.Trim();
            this.lastName = lastName.Trim();
            this.studentNumber = studentNumber;
            GenerateEmail();
        }


        public string Email
        {
            get
            {
                return email;
            }
        }

        //Property to provide access to firstName
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                GenerateEmail();
            }
        }

        //Property to provide access to lastName
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
               lastName = value;
               GenerateEmail();
            }
        }

        //Property to provide access to studentNumber
        public int StudentNumber
        {
            get
            {
                return studentNumber;
            }
        }
       
        //Overrides ToString() 
         public override string ToString()
        {
            return firstName + " " + lastName;
        }


        public void ResetStudentNumber()
        {
            this.studentNumber = generator.Next(0, 1000) + 555000;
            GenerateEmail();
        }


        private void GenerateEmail()
        {
            string first, last;

            if (firstName.Length <= 3)
                first = firstName;
            else
                first = firstName.Substring(0, 3);

            if (lastName.Length <= 3)
                last = lastName;
            else
                last = lastName.Substring(0, 3);

            email = first + last + (studentNumber + "").Substring(3) + "@ICS4U.com";
            
        }



        //Comparison Section

        public int CompareTo(Student that)
        {
            if (this.LastName.CompareTo(that.LastName) == 0) //If last names are equal, compares first names
                return this.FirstName.CompareTo(that.FirstName);  

            return this.LastName.CompareTo(that.LastName);  //Otherwise compares last names
        }


        //Overrides Equals
        public override bool Equals(object obj)
        {
            Student student = obj as Student;   //cast object to Student for comparison
            if (student == null)
                return false;
            return this.FirstName == student.FirstName && this.LastName == student.LastName && this.StudentNumber == student.StudentNumber;
        }
        //Overrides hash code
        public override int GetHashCode()
        {
            return (firstName+lastName+studentNumber).GetHashCode();
        }

    }
}

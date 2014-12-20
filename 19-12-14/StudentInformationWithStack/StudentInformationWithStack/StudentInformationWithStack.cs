using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInformationApp;

namespace StudentInformationWithStack
{
    public partial class StudentInformationWithStack : Form
    {
        public StudentInformationWithStack()
        {
            InitializeComponent();
        }
        Stack<Student> students = new Stack<Student>(); 
        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;
            students.Push(aStudent);
            MessageBox.Show("Save Successfully");
            clearAllTextBox();
        }

        private void clearAllTextBox()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
        }
        private void showAllButton_Click(object sender, EventArgs e)
        {
            string allInformation = "";
            foreach (Student student in students)
            {
                allInformation += student.firstName + " " + student.lastName+"\n";
            }
            MessageBox.Show(allInformation + "\n");
        }
    }
}

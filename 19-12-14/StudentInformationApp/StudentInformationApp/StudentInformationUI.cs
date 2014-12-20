using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationApp
{
    public partial class StudentInformationUI : Form
    {
        public StudentInformationUI()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>();  
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;
            aStudent.regNumber = regNoTextBox.Text;
            students.Add(aStudent);
            MessageBox.Show("Succesffully Save");
            clearAllTextBox();
        }

        private void clearAllTextBox()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            regNoTextBox.Text = string.Empty;
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string studentIData = "";
            foreach (Student aStudent in students)
            {
               studentIData += aStudent.regNumber + "\t" + aStudent.GetFullName() + "\n";
            }
            if(students.Count!=0)
            MessageBox.Show("Reg No \t Student Name\n"+studentIData);
            else
            {
                MessageBox.Show("No data Found");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            students.Clear();
            MessageBox.Show("All Are Deleted");
        }
    }
}

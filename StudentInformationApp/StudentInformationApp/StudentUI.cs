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
    public partial class StudentUI : Form
    {
        public StudentUI()
        {
            InitializeComponent();
        }

        List<Student> studentList = new List<Student>(); 
        private void saveButton_Click(object sender, EventArgs e)
        {
           Student aStudent = new Student();

            aStudent.regNo = regNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;

            studentList.Add(aStudent);

            regNoTextBox.Text = String.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;

            MessageBox.Show("student information has been saved");
        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            string msg = "RegNo \tFullName";

            foreach (Student aStudent  in studentList)
            {
                msg += aStudent.GetFullName() + "\n";
               
            }
            MessageBox.Show(msg);


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3._3
{
    public partial class MainForm : Form
    {
        // List to hold student records
        private List<Student> students;

        public MainForm()
        {
            InitializeComponent();

            // Initialize the students list with some sample data
            students = new List<Student> {
                new Student { StudentId = 1, FirstName = "John", LastName = "Doe", Address = "123 Main St", MonthOfAdmission = MonthOfAdmission.January, Grade = Grade.A },
                new Student { StudentId = 2, FirstName = "Jane", LastName = "Smith", Address = "456 Oak Ave", MonthOfAdmission = MonthOfAdmission.March, Grade = Grade.B },
                new Student { StudentId = 3, FirstName = "Sam", LastName = "Johnson", Address = "789 Pine Dr", MonthOfAdmission = MonthOfAdmission.May, Grade = Grade.C }
            };

            // Set data sources for the combo boxes
            comboBoxMonthOfAdmission.DataSource = Enum.GetValues(typeof(MonthOfAdmission));
            comboBoxGrade.DataSource = Enum.GetValues(typeof(Grade));
            // Set the data source for the DataGridView to the students list
            dataGridViewStudents.DataSource = students;

            // Initially hide the groupBox1
            groupBox1.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Show groupBox1 when the Add button is clicked
            groupBox1.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.CurrentRow != null)
            {
                // Show a confirmation dialog before deleting a record
                var result = MessageBox.Show("Are you sure you want to delete the record?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Remove the selected student from the list
                    Student selectedStudent = (Student)dataGridViewStudents.CurrentRow.DataBoundItem;
                    students.Remove(selectedStudent);
                    // Refresh the data in the DataGridView
                    RefreshData();
                }
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Check if all necessary fields are filled
            if (!string.IsNullOrEmpty(textBoxStudId.Text) &&
                !string.IsNullOrEmpty(textBoxFirstName.Text) &&
                !string.IsNullOrEmpty(textBoxLastName.Text) &&
                !string.IsNullOrEmpty(textBoxAddress.Text))
            {
                // Create a new student object with the provided data
                var newStudent = new Student
                {
                    StudentId = int.Parse(textBoxStudId.Text),
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    Address = textBoxAddress.Text,
                    MonthOfAdmission = (MonthOfAdmission)comboBoxMonthOfAdmission.SelectedItem,
                    Grade = (Grade)comboBoxGrade.SelectedItem
                };

                // Add the new student to the list
                students.Add(newStudent);
                MessageBox.Show("New Student's Record Added!");

                // Refresh the data in the DataGridView
                RefreshData();

                // Hide groupBox1 after submission
                groupBox1.Visible = false;
            }
        }

        private void RefreshData()
        {
            // Clear the input fields
            textBoxStudId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxAddress.Clear();
            // Reset the combo boxes
            comboBoxMonthOfAdmission.SelectedIndex = -1;
            comboBoxGrade.SelectedIndex = -1;
            // Refresh the data in the DataGridView by resetting its data source
            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = students;
        }
    }
}

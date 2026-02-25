using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSystemFull
{
	public partial class Form5 : Form
	{
		StudentData student;

		public Form5(StudentData s)
		{
			InitializeComponent();
			student = s;
		}
		private void Form5_Load(object sender, EventArgs e)
		{
			dgvStudents.Columns.Add("StudentNumber", "Student Number");
			dgvStudents.Columns.Add("Name", "Name");
			dgvStudents.Columns.Add("Age", "Age");
			dgvStudents.Columns.Add("Gender", "Gender");
			dgvStudents.Columns.Add("Email", "Email");
			dgvStudents.Columns.Add("Address", "Address");
			dgvStudents.Columns.Add("Family", "Family");
			dgvStudents.Columns.Add("Education", "Education");
			dgvStudents.Columns.Add("Birthdate", "Birthdate");

			DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
			imgCol.HeaderText = "Photo";
			imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

			dgvStudents.Columns.Add(imgCol);

			dgvStudents.Rows.Add(
				student.StudentNumber,
				student.FirstName + " " + student.LastName,
				student.Age,
				student.Gender,
				student.Email,
				student.City + ", " + student.Region,
				student.FatherFirstName + " " + student.FatherLastName,
				student.LastSchool,
				student.BirthDate.ToShortDateString(),
				student.StudentImage
			);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Form4 f4 = new Form4(student);
			f4.Show();
			this.Close();
		}
	}
}

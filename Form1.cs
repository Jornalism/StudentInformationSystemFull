using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace StudentInformationSystemFull
{
	public partial class Form1 : Form
	{
		StudentData student;
		public Form1()
		{
			InitializeComponent();
			student = new StudentData();
		}
		public Form1(StudentData s)
		{
			
			InitializeComponent();
			student = s;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			if (student != null)
			{
				txtFirstName.Text = student.FirstName;
				txtMiddleName.Text = student.MiddleName;
				txtLastName.Text = student.LastName;
				txtStudentNumber.Text = student.StudentNumber;

				cboExtensionName.Text = student.ExtensionName;

				if (student.Age > 0)
					numAge.Value = student.Age;

				cboCivilStatus.Text = student.CivilStatus;

				txtReligion.Text = student.Religion;
				txtPlaceOfBirth.Text = student.PlaceOfBirth;
				txtEmail.Text = student.Email;
				txtMobileNumber.Text = student.MobileNumber;

				if (student.BirthDate >= dtpBirthDate.MinDate &&
					student.BirthDate <= dtpBirthDate.MaxDate)
				{
					dtpBirthDate.Value = student.BirthDate;
				}

				if (student.Gender == "Male")
					rbMale.Checked = true;
				else if (student.Gender == "Female")
					rbFemale.Checked = true;

				picStudent.Image = student.StudentImage;
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{

			if (!ValidateForm())
				return;

			student.FirstName = txtFirstName.Text;
			student.MiddleName = txtMiddleName.Text;
			student.LastName = txtLastName.Text;
			student.StudentNumber = txtStudentNumber.Text;
			student.ExtensionName = cboExtensionName.Text;
			student.Age = (int)numAge.Value;
			student.CivilStatus = cboCivilStatus.Text;
			student.BirthDate = dtpBirthDate.Value;
			student.Religion = txtReligion.Text;
			student.PlaceOfBirth = txtPlaceOfBirth.Text;
			student.Email = txtEmail.Text;
			student.MobileNumber = txtMobileNumber.Text;
			student.StudentImage = picStudent.Image;

			if (rbMale.Checked)
				student.Gender = "Male";
			else
				student.Gender = "Female";

				Form2 f2 = new Form2(student);
				f2.Show();
				this.Hide();
		}

		private void btnUpload_Click(object sender, EventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog();

			op.Filter = "Image Files|*.jpg;*.jpeg;*.png";

			if (op.ShowDialog() == DialogResult.OK)
			{
				picStudent.Image = Image.FromFile(op.FileName);
			}
		}

		// KEYPRESS!!!
		private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtMiddleName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtReligion_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtPlaceOfBirth_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
			if ((e.KeyChar == (char)Keys.Enter))
			{
				e.Handled = true;
				return;
			}
		}
		private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar == (char)Keys.Enter))
			{
				e.Handled = true;
				return;
			}
		}
	
		private void txtMobileNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}
		// EMAIL VALIDATION 
		private bool IsValidEmail(string email)
		{
			return Regex.IsMatch(email,
			@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
		}

		// MOBILE NUMBER VALIDATION
		private bool IsValidMobile(string number)
		{
			return Regex.IsMatch(number,
			@"^[0-9]{11}$");
		}

		// FORM VALIDATION

		private bool ValidateForm()
		{
			bool valid = true;

			errorProvider1.Clear();

			if (txtFirstName.Text.Trim() == "")
			{
				errorProvider1.SetError(txtFirstName, "Required");
				valid = false;
			}

			if (txtMiddleName.Text.Trim() == "")
			{
				errorProvider1.SetError(txtMiddleName, "Required");
				valid = false;
			}

			if (txtLastName.Text.Trim() == "")
			{
				errorProvider1.SetError(txtLastName, "Required");
				valid = false;
			}

			if (txtStudentNumber.Text.Trim() == "")
			{
				errorProvider1.SetError(txtStudentNumber, "Required");
				valid = false;
			}

			if (cboCivilStatus.SelectedIndex == -1)
			{
				errorProvider1.SetError(cboCivilStatus, "Required");
				valid = false;
			}

			if (!rbMale.Checked && !rbFemale.Checked)
			{
				errorProvider1.SetError(rbMale, "Select Gender");
				valid = false;
			}

			if (txtReligion.Text.Trim() == "")
			{
				errorProvider1.SetError(txtReligion, "Required");
				valid = false;
			}

			if (txtPlaceOfBirth.Text.Trim() == "")
			{
				errorProvider1.SetError(txtPlaceOfBirth, "Required");
				valid = false;
			}

			if (!IsValidEmail(txtEmail.Text))
			{
				errorProvider1.SetError(txtEmail, "Invalid Email");
				valid = false;
			}

			if (!IsValidMobile(txtMobileNumber.Text))
			{
				errorProvider1.SetError(txtMobileNumber, "Must be 11 digits");
				valid = false;
			}

			if (picStudent.Image == null)
			{
				errorProvider1.SetError(picStudent, "Upload Image");
				valid = false;
			}

			return valid;
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnBack_Click(object sender, EventArgs e)
		{

		}

	}
}

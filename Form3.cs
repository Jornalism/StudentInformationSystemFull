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

namespace StudentInformationSystemFull
{
	public partial class Form3 : Form
	{
		StudentData student;

		public Form3(StudentData s)
		{
			InitializeComponent();
			student = s;
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			if (student != null)
			{
				txtFatherFirstName.Text = student.FatherFirstName;
				txtFatherMiddleName.Text = student.FatherMiddleName;
				txtFatherLastName.Text = student.FatherLastName;
				cboFatherExtension.Text = student.FatherExtension;

				txtMotherFirstName.Text = student.MotherFirstName;
				txtMotherMiddleName.Text = student.MotherMiddleName;
				txtMotherLastName.Text = student.MotherLastName;

				txtGuardianFirstName.Text = student.GuardianFirstName;
				txtGuardianMiddleName.Text = student.GuardianMiddleName;
				txtGuardianLastName.Text = student.GuardianLastName;

				txtGuardianRelationship.Text = student.GuardianRelationship;
				txtGuardianContact.Text = student.GuardianContact;
				txtGuardianEmail.Text = student.GuardianEmail;
			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{

			if (!ValidateForm3())
				return;
			// Father Information
			student.FatherFirstName = txtFatherFirstName.Text;
			student.FatherMiddleName = txtFatherMiddleName.Text;
			student.FatherLastName = txtFatherLastName.Text;
			student.FatherExtension = cboFatherExtension.Text;

			// Mother Information
			student.MotherFirstName = txtMotherFirstName.Text;
			student.MotherMiddleName = txtMotherMiddleName.Text;
			student.MotherLastName = txtMotherLastName.Text;

			// Guardian Information
			student.GuardianFirstName = txtGuardianFirstName.Text;
			student.GuardianMiddleName = txtGuardianMiddleName.Text;
			student.GuardianLastName = txtGuardianLastName.Text;
			student.GuardianRelationship = txtGuardianRelationship.Text;
			student.GuardianContact = txtGuardianContact.Text;
			student.GuardianEmail = txtGuardianEmail.Text;

			Form4 f4 = new Form4(student);
			f4.Show();
			this.Hide();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2(student);
			f2.Show();
			this.Close();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			//REMOVED
		}

		// KEYPRESS!!!

		private void txtFatherFirstName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtFatherMiddleName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtFatherLastName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtMotherFirstName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtMotherMiddleName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtMotherLastName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtGuardianFirstName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtGuardianMiddleName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtGuardianLastName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}

		}

		private void txtGuardianRelationship_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtGuardianContact_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtGuardianEmail_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar == (char)Keys.Enter))
			{
				e.Handled = true;
				return;
			}
		}

		//VALIDATION

		private bool ValidateForm3()
		{
			bool valid = true;
			errorProvider1.Clear();

			// FATHER
			if (txtFatherFirstName.Text.Trim() == "")
			{
				errorProvider1.SetError(txtFatherFirstName, "Required");
				valid = false;
			}

			if (txtFatherMiddleName.Text.Trim() == "")
			{
				errorProvider1.SetError(txtFatherMiddleName, "Required");
				valid = false;
			}

			if (txtFatherLastName.Text.Trim() == "")
			{
				errorProvider1.SetError(txtFatherLastName, "Required");
				valid = false;
			}

			// MOTHER
			if (txtMotherFirstName.Text.Trim() == "")
			{
				errorProvider1.SetError(txtMotherFirstName, "Required");
				valid = false;
			}

			if (txtMotherMiddleName.Text.Trim() == "")
			{
				errorProvider1.SetError(txtMotherMiddleName, "Required");
				valid = false;
			}

			if (txtMotherLastName.Text.Trim() == "")
			{
				errorProvider1.SetError(txtMotherLastName, "Required");
				valid = false;
			}

			// GUARDIAN
			if (txtGuardianFirstName.Text.Trim() == "")
			{
				errorProvider1.SetError(txtGuardianFirstName, "Required");
				valid = false;
			}

			if (txtGuardianMiddleName.Text.Trim() == "")
			{
				errorProvider1.SetError(txtGuardianMiddleName, "Required");
				valid = false;
			}

			if (txtGuardianLastName.Text.Trim() == "")
			{
				errorProvider1.SetError(txtGuardianLastName, "Required");
				valid = false;
			}

			if (txtGuardianRelationship.Text.Trim() == "")
			{
				errorProvider1.SetError(txtGuardianRelationship, "Required");
				valid = false;
			}

			if (txtGuardianContact.Text.Trim() == "")
			{
				errorProvider1.SetError(txtGuardianContact, "Required");
				valid = false;
			}

			if (txtGuardianEmail.Text.Trim() == "")
			{
				errorProvider1.SetError(txtGuardianEmail, "Required");
				valid = false;
			}
			else if (!IsValidEmail(txtGuardianEmail.Text))
			{
				errorProvider1.SetError(txtGuardianEmail, "Invalid Email");
				valid = false;
			}

			return valid;
		}

		// EMAIL CHECK
		private bool IsValidEmail(string email)
		{
			return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
		}

	}
}

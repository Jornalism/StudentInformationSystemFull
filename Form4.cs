using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSystemFull
{
	public partial class Form4 : Form
	{
		StudentData student;

		public Form4(StudentData s)
		{
			InitializeComponent();
			student = s;
		}

		

		private void Form4_Load(object sender, EventArgs e)
		{

		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{

			if (!ValidateForm4())
				return;

			student.StudentType = cboStudentType.Text;
			student.LearnersRefNo = txtLearnersRefNo.Text;
			student.LastSchool = txtLastSchool.Text;
			student.ProgramFirstChoice = cboProgramFirstChoice.Text;
			student.ProgramSecondChoice = cboProgramSecondChoice.Text;

			DialogResult result = MessageBox.Show(
				"Do you want to view the student information?",
				"Confirmation",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				Form5 f5 = new Form5(student);
				f5.Show();
				this.Hide();
			}
			else
			{
				this.Close();
			}
			
		}
		private void btnBack_Click(object sender, EventArgs e)
		{
			Form3 f3 = new Form3(student); 
			f3.Show();
			this.Close();
		}

		// KEYPRESS!!!
		private void txtLearnersRefNo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtLastSchool_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
			{
				e.Handled = true;
			}
		}

		private void txtYearGraduated_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void txtSchoolStreet_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar == (char)Keys.Enter))
			{
				e.Handled = true;
			}
		}

		private void txtSchoolCity_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
			{
				e.Handled = true;
			}
		}

		private void txtSchoolProvince_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
			{
				e.Handled = true;
			}
		}

		//VALIDATION

		private bool ValidateForm4()
		{
			bool valid = true;
			errorProvider1.Clear();

			if (cboStudentType.SelectedIndex == -1)
			{
				errorProvider1.SetError(cboStudentType, "Required");
				valid = false;
			}

			if (txtLearnersRefNo.Text.Trim() == "")
			{
				errorProvider1.SetError(txtLearnersRefNo, "Required");
				valid = false;
			}

			if (cboSchoolClassification.SelectedIndex == -1)
			{
				errorProvider1.SetError(cboSchoolClassification, "Required");
				valid = false;
			}

			if (txtLastSchool.Text.Trim() == "")
			{
				errorProvider1.SetError(txtLastSchool, "Required");
				valid = false;
			}

			if (txtYearGraduated.Text.Trim() == "")
			{
				errorProvider1.SetError(txtYearGraduated, "Required");
				valid = false;
			}
			else if (!IsValidYear(txtYearGraduated.Text))
			{
				errorProvider1.SetError(txtYearGraduated, "Enter 4-digit year");
				valid = false;
			}

			if (cboStrand.SelectedIndex == -1)
			{
				errorProvider1.SetError(cboStrand, "Required");
				valid = false;
			}

			if (txtSchoolStreet.Text.Trim() == "")
			{
				errorProvider1.SetError(txtSchoolStreet, "Required");
				valid = false;
			}

			if (txtSchoolCity.Text.Trim() == "")
			{
				errorProvider1.SetError(txtSchoolCity, "Required");
				valid = false;
			}

			if (txtSchoolProvince.Text.Trim() == "")
			{
				errorProvider1.SetError(txtSchoolProvince, "Required");
				valid = false;
			}

			if (cboProgramFirstChoice.SelectedIndex == -1)
			{
				errorProvider1.SetError(cboProgramFirstChoice, "Required");
				valid = false;
			}

			if (cboProgramSecondChoice.SelectedIndex == -1)
			{
				errorProvider1.SetError(cboProgramSecondChoice, "Required");
				valid = false;
			}

			return valid;
		}
		private bool IsValidYear(string year)
		{
			if (year.Length != 4)
				return false;
			
			if (!int.TryParse(year, out int yearValue))
				return false;
			
			return yearValue >= 1900 && yearValue <= DateTime.Now.Year + 10;
		}
	}
}

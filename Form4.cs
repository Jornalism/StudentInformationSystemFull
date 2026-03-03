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
			if (student != null)
			{
				cboStudentType.Text = student.StudentType;
				txtLearnersRefNo.Text = student.LearnersRefNo;
				cboSchoolClassification.Text = student.SchoolClassification;

				txtLastSchool.Text = student.LastSchool;
				txtYearGraduated.Text = student.YearGraduated;
				cboStrand.Text = student.Strand;

				txtSchoolStreet.Text = student.SchoolStreet;
				txtSchoolCity.Text = student.SchoolCity;
				txtSchoolProvince.Text = student.SchoolProvince;

				cboProgramFirstChoice.Text = student.ProgramFirstChoice;
				cboProgramSecondChoice.Text = student.ProgramSecondChoice;
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			student.StudentType = cboStudentType.Text;
			student.LearnersRefNo = txtLearnersRefNo.Text;
			student.SchoolClassification = cboSchoolClassification.Text;
			student.LastSchool = txtLastSchool.Text;
			student.YearGraduated = txtYearGraduated.Text;
			student.Strand = cboStrand.Text;
			student.SchoolStreet = txtSchoolStreet.Text;
			student.SchoolCity = txtSchoolCity.Text;
			student.SchoolProvince = txtSchoolProvince.Text;
			student.ProgramFirstChoice = cboProgramFirstChoice.Text;
			student.ProgramSecondChoice = cboProgramSecondChoice.Text;

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
			//Removed
        }

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			student.StudentType = cboStudentType.Text;
			student.LearnersRefNo = txtLearnersRefNo.Text;
			student.SchoolClassification = cboSchoolClassification.Text;
			student.LastSchool = txtLastSchool.Text;
			student.YearGraduated = txtYearGraduated.Text;
			student.Strand = cboStrand.Text;
			student.SchoolStreet = txtSchoolStreet.Text;
			student.SchoolCity = txtSchoolCity.Text;
			student.SchoolProvince = txtSchoolProvince.Text;
			student.ProgramFirstChoice = cboProgramFirstChoice.Text;
			student.ProgramSecondChoice = cboProgramSecondChoice.Text;

			// Mark that the user completed all 4 forms
			student.CompletedAllForms = true;

			Form1 f1 = new Form1(student);
			f1.Show();
			this.Close();
		}
	}
}

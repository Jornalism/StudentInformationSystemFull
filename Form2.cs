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
using static System.Net.Mime.MediaTypeNames;

namespace StudentInformationSystemFull
{
	public partial class Form2 : Form
	{
		StudentData student;

		public Form2(StudentData s)
		{
			InitializeComponent();
			student = s;
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			if (student != null)
			{
				cboRegion.Text = student.Region;
				cboProvince.Text = student.Province;
				cboCity.Text = student.City;
				cboBarangay.Text = student.Barangay;

				txtHouseStreet.Text = student.HouseStreet;
				txtZipCode.Text = student.ZipCode;
			}
		}
		private void btnNext_Click(object sender, EventArgs e)
		{
			// SAVE ADDRESS DATA

			if (!ValidateForm2())
				return;

			student.Region = cboRegion.Text;
			student.Province = cboProvince.Text;
			student.City = cboCity.Text;
			student.Barangay = cboBarangay.Text;
			student.HouseStreet = txtHouseStreet.Text;
			student.ZipCode = txtZipCode.Text;

			Form3 f3 = new Form3(student);
			f3.Show();
			this.Hide();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1(student);
			f1.Show();
			this.Close();
		}

		// KEYPRESS!!!

		private void txtHouseStreet_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar == (char)Keys.Enter))
			{
				e.Handled = true;
			}
		}

		private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
			
		}

		// VALIDATION

		private bool ValidateForm2()
		{
			bool valid = true;
			errorProvider1.Clear();

			if (cboRegion.SelectedIndex == -1)
			{
				errorProvider1.SetError(cboRegion, "Required");
				valid = false;
			}

			if (cboProvince.SelectedIndex == -1)
			{
				errorProvider1.SetError(cboProvince, "Required");
				valid = false;
			}

			if (cboBarangay.SelectedIndex == -1)
			{
				errorProvider1.SetError(cboBarangay, "Required");
				valid = false;
			}

			if (cboCity.SelectedIndex == -1)
			{
				errorProvider1.SetError(cboCity, "Required");
				valid = false;
			}

			if (txtHouseStreet.Text == "")
			{
				errorProvider1.SetError(txtHouseStreet, "Required");
				valid = false;
			}

			if (txtZipCode.Text == "")
			{
				errorProvider1.SetError(txtZipCode, "Required");
				valid = false;
			}

			return valid;
		}

		
	}
}

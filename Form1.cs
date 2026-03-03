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
		int selectedRowIndex = -1;

		// Static list acts as an in-memory database.
		static List<StudentData> studentRecords = new List<StudentData>();

		public Form1()
		{
			InitializeComponent();
			student = new StudentData();
			SetupButtonImages();
		}
		public Form1(StudentData s)
		{
			InitializeComponent();
			student = s;
			SetupButtonImages();
		}

		private void SetupButtonImages()
		{
			btnSave.Image = new Bitmap(Properties.Resources.imgSave, new Size(24, 24));
			btnEdit.Image = new Bitmap(Properties.Resources.imgEdit, new Size(24, 24));
			btnDelete.Image = new Bitmap(Properties.Resources.imgDelete, new Size(24, 24));
			btnClear.Image = new Bitmap(Properties.Resources.imgClear, new Size(24, 24));


			btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Disable copy/paste/right-click for restricted fields
			txtFirstName.ShortcutsEnabled = false;
			txtMiddleName.ShortcutsEnabled = false;
			txtLastName.ShortcutsEnabled = false;
			txtStudentNumber.ShortcutsEnabled = false;
			txtReligion.ShortcutsEnabled = false;
			txtPlaceOfBirth.ShortcutsEnabled = false;
			txtMobileNumber.ShortcutsEnabled = false;

			SetupColumns();
			LoadGrid();

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

			dgvStudents.CellClick += dgvStudents_CellClick;

			// btnSave only enabled after completing all 4 forms
			btnSave.Enabled = student != null && student.CompletedAllForms;

			// btnEdit and btnDelete only enabled when a grid row is selected
			btnEdit.Enabled = false;
			btnDelete.Enabled = false;
		}

		private void SetupColumns()
		{
			dgvStudents.Columns.Add("StudentNumber", "Student Number");
			dgvStudents.Columns.Add("Name", "Name");
			dgvStudents.Columns.Add("Age", "Age");
			dgvStudents.Columns.Add("Gender", "Gender");
			dgvStudents.Columns.Add("Email", "Email");
			dgvStudents.Columns.Add("Location", "Location");
			dgvStudents.Columns.Add("FatherName", "Father's Name");
			dgvStudents.Columns.Add("LastSchool", "Last School");
			dgvStudents.Columns.Add("BirthDate", "Birth Date");

			DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
			imgCol.Name = "StudentImage";
			imgCol.HeaderText = "Image";
			imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
			dgvStudents.Columns.Add(imgCol);

			dgvStudents.RowTemplate.Height = 60;
		}

		private void LoadGrid()
		{
			dgvStudents.Rows.Clear();
foreach (var s in studentRecords)
			
			{
				dgvStudents.Rows.Add(
					s.StudentNumber,
					s.FirstName + " " + s.LastName,
					s.Age,
					s.Gender,
					s.Email,
					s.City + ", " + s.Region,
					s.FatherFirstName + " " + s.FatherLastName,
					s.LastSchool,
					s.BirthDate.ToShortDateString(),
					s.StudentImage
				);
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

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateForm()) 
				return;

			// Save personal info from form to student object
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

			// Create a snapshot copy so future edits don't overwrite this record
			StudentData saved = new StudentData();
			saved.StudentNumber = student.StudentNumber;
			saved.FirstName = student.FirstName;
			saved.MiddleName = student.MiddleName;
			saved.LastName = student.LastName;
			saved.ExtensionName = student.ExtensionName;
			saved.Age = student.Age;
			saved.CivilStatus = student.CivilStatus;
			saved.Gender = student.Gender;
			saved.BirthDate = student.BirthDate;
			saved.Religion = student.Religion;
			saved.PlaceOfBirth = student.PlaceOfBirth;
			saved.Email = student.Email;
			saved.MobileNumber = student.MobileNumber;
			saved.StudentImage = student.StudentImage;
			saved.Region = student.Region;
			saved.Province = student.Province;
			saved.City = student.City;
			saved.Barangay = student.Barangay;
			saved.HouseStreet = student.HouseStreet;
			saved.ZipCode = student.ZipCode;
			saved.FatherFirstName = student.FatherFirstName;
			saved.FatherMiddleName = student.FatherMiddleName;
			saved.FatherLastName = student.FatherLastName;
			saved.FatherExtension = student.FatherExtension;
			saved.MotherFirstName = student.MotherFirstName;
			saved.MotherMiddleName = student.MotherMiddleName;
			saved.MotherLastName = student.MotherLastName;
			saved.GuardianFirstName = student.GuardianFirstName;
			saved.GuardianMiddleName = student.GuardianMiddleName;
			saved.GuardianLastName = student.GuardianLastName;
			saved.GuardianRelationship = student.GuardianRelationship;
			saved.GuardianContact = student.GuardianContact;
			saved.GuardianEmail = student.GuardianEmail;
			saved.StudentType = student.StudentType;
			saved.LearnersRefNo = student.LearnersRefNo;
			saved.SchoolClassification = student.SchoolClassification;
			saved.LastSchool = student.LastSchool;
			saved.YearGraduated = student.YearGraduated;
			saved.Strand = student.Strand;
			saved.SchoolStreet = student.SchoolStreet;
			saved.SchoolCity = student.SchoolCity;
			saved.SchoolProvince = student.SchoolProvince;
			saved.ProgramFirstChoice = student.ProgramFirstChoice;
			saved.ProgramSecondChoice = student.ProgramSecondChoice;

			studentRecords.Add(saved);
			LoadGrid();

			MessageBox.Show("Student Saved Successfully!");

			// Disable Save after saving, Edit/Delete need a row click first
			btnSave.Enabled = false;
			btnEdit.Enabled = false;
			btnDelete.Enabled = false;
		}

		private void btnEdit_Click_1(object sender, EventArgs e)
		{
			if (selectedRowIndex < 0)
			{
				MessageBox.Show("Please select a student first.");
				return;
			}

			if (!ValidateForm())
			{
				MessageBox.Show("Fix all errors first!");
				return;
			}

			if (MessageBox.Show("Do you want to update this record?",
				"Confirm Update",
				MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				DataGridViewRow row = dgvStudents.Rows[selectedRowIndex];

				row.Cells[0].Value = txtStudentNumber.Text.Trim();
				row.Cells[1].Value = txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim();
				row.Cells[2].Value = (int)numAge.Value;
				row.Cells[3].Value = rbMale.Checked ? "Male" : "Female";
				row.Cells[4].Value = txtEmail.Text.Trim();
				row.Cells[8].Value = dtpBirthDate.Value.ToShortDateString();
				row.Cells[9].Value = picStudent.Image;

				// Also update the static list so data stays in sync
				StudentData record = studentRecords[selectedRowIndex];
				record.FirstName = txtFirstName.Text;
				record.MiddleName = txtMiddleName.Text;
				record.LastName = txtLastName.Text;
				record.StudentNumber = txtStudentNumber.Text;
				record.ExtensionName = cboExtensionName.Text;
				record.Age = (int)numAge.Value;
				record.CivilStatus = cboCivilStatus.Text;
				record.BirthDate = dtpBirthDate.Value;
				record.Religion = txtReligion.Text;
				record.PlaceOfBirth = txtPlaceOfBirth.Text;
				record.Email = txtEmail.Text;
				record.MobileNumber = txtMobileNumber.Text;
				record.StudentImage = picStudent.Image;
				record.Gender = rbMale.Checked ? "Male" : "Female";

				MessageBox.Show("Student Updated Successfully.");

				selectedRowIndex = -1;
				btnEdit.Enabled = false;
				btnDelete.Enabled = false;
				btnSave.Enabled = true;
			}
		}

		private void btnDelete_Click_1(object sender, EventArgs e)
		{
			if (selectedRowIndex < 0)
			{
				MessageBox.Show("Please select a student first.");
				return;
			}

			if (MessageBox.Show("Do you want to delete this record?",
				"Confirm Delete",
				MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				studentRecords.RemoveAt(selectedRowIndex);
				LoadGrid();
				MessageBox.Show("Student Deleted Successfully!");
				selectedRowIndex = -1;

				btnEdit.Enabled = false;
				btnDelete.Enabled = false;
				btnSave.Enabled = true;
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtFirstName.Clear();
			txtMiddleName.Clear();
			txtLastName.Clear();
			txtStudentNumber.Clear();
			cboExtensionName.SelectedIndex = -1;
			cboExtensionName.Text = "";
			numAge.Value = 0;
			cboCivilStatus.SelectedIndex = -1;
			cboCivilStatus.Text = "";
			rbMale.Checked = false;
			rbFemale.Checked = false;
			dtpBirthDate.Value = dtpBirthDate.MinDate;
			txtReligion.Clear();
			txtPlaceOfBirth.Clear();
			txtEmail.Clear();
			txtMobileNumber.Clear();
			picStudent.Image = null;
			errorProvider1.Clear();
			selectedRowIndex = -1;
			student = new StudentData();
		}

		private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.RowIndex >= studentRecords.Count) 
				return;

			selectedRowIndex = e.RowIndex;
			StudentData selected = studentRecords[selectedRowIndex];

			txtFirstName.Text = selected.FirstName;
			txtMiddleName.Text = selected.MiddleName;
			txtLastName.Text = selected.LastName;
			txtStudentNumber.Text = selected.StudentNumber;
			cboExtensionName.Text = selected.ExtensionName;

			if (selected.Age > 0)
				numAge.Value = selected.Age;

			cboCivilStatus.Text = selected.CivilStatus;

			if (selected.BirthDate >= dtpBirthDate.MinDate &&
				selected.BirthDate <= dtpBirthDate.MaxDate)
			{
				dtpBirthDate.Value = selected.BirthDate;
			}

			if (selected.Gender == "Male")
				rbMale.Checked = true;
			else if (selected.Gender == "Female")
				rbFemale.Checked = true;

			txtReligion.Text = selected.Religion;
			txtPlaceOfBirth.Text = selected.PlaceOfBirth;
			txtEmail.Text = selected.Email;
			txtMobileNumber.Text = selected.MobileNumber;
			picStudent.Image = selected.StudentImage;

			student = selected;

			// Enable Edit/Delete when a row is selected, disable Save
			btnEdit.Enabled = true;
			btnDelete.Enabled = true;
			btnSave.Enabled = false;
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
				e.Handled = true;
		}

		private void txtMiddleName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
				e.Handled = true;
		}

		private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
				e.Handled = true;
		}

		private void txtStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
				e.Handled = true;
		}

		private void txtReligion_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
				e.Handled = true;
		}

		private void txtPlaceOfBirth_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
				e.Handled = true;
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
				e.Handled = true;
		}

		// FORM VALIDATION
		private bool ValidateForm()
		{
			bool valid = true;
			errorProvider1.Clear();

			if (txtFirstName.Text == "")
			{ errorProvider1.SetError(txtFirstName, "Required"); 
				valid = false; 
			}

			if (txtMiddleName.Text == "")
			{ errorProvider1.SetError(txtMiddleName, "Required");
				valid = false; 
			}

			if (txtLastName.Text == "")
			{ errorProvider1.SetError(txtLastName, "Required"); 
				valid = false; 
			}

			if (txtStudentNumber.Text == "")
			{ errorProvider1.SetError(txtStudentNumber, "Required"); 
				valid = false; 
			}

			if (numAge.Value < 15 || numAge.Value > 50)
			{ errorProvider1.SetError(numAge, "Age must be 15 to 50"); 
				valid = false; 
			}

			if (cboCivilStatus.SelectedIndex == -1)
			{ errorProvider1.SetError(cboCivilStatus, "Required"); 
				valid = false; 
			}

			if (!rbMale.Checked && !rbFemale.Checked)
			{ errorProvider1.SetError(rbMale, "Select Gender"); 
				valid = false; 
			}

			if (txtReligion.Text == "")
			{ errorProvider1.SetError(txtReligion, "Required"); 
				valid = false; 
			}

			if (txtPlaceOfBirth.Text == "")
			{ errorProvider1.SetError(txtPlaceOfBirth, "Required"); 
				valid = false;
			}

			if (!IsValidEmail(txtEmail.Text))
			{ errorProvider1.SetError(txtEmail, "Invalid Email"); 
				valid = false; 
			}

			if (!IsValidMobile(txtMobileNumber.Text))
			{ errorProvider1.SetError(txtMobileNumber, "Must be 11 digits"); 
				valid = false; 
			}

			if (picStudent.Image == null)
			{ errorProvider1.SetError(picStudent, "Upload Image"); 
				valid = false; 
			}

			return valid;
		}

		private bool IsValidEmail(string email)
		{
			return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
		}

		private bool IsValidMobile(string number)
		{
			return Regex.IsMatch(number, @"^[0-9]{11}$");
		}

		private void label10_Click(object sender, EventArgs e) { }
		private void label8_Click(object sender, EventArgs e) { }

		
	}
}

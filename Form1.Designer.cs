namespace StudentInformationSystemFull
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnNext = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cboExtensionName = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cboCivilStatus = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtPlaceOfBirth = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtMobileNumber = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.numAge = new System.Windows.Forms.NumericUpDown();
			this.btnUpload = new System.Windows.Forms.Button();
			this.picStudent = new System.Windows.Forms.PictureBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtStudentNumber = new System.Windows.Forms.TextBox();
			this.rbFemale = new System.Windows.Forms.RadioButton();
			this.rbMale = new System.Windows.Forms.RadioButton();
			this.label13 = new System.Windows.Forms.Label();
			this.txtReligion = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtMiddleName = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label15 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(790, 6);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(113, 30);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "First Name:\r\n";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(625, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Last Name:\r\n";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(322, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Middle Name:\r\n";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(23, 43);
			this.txtFirstName.Multiline = true;
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(272, 24);
			this.txtFirstName.TabIndex = 4;
			this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(220, 100);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(121, 18);
			this.label5.TabIndex = 7;
			this.label5.Text = "Extension Name:";
			// 
			// cboExtensionName
			// 
			this.cboExtensionName.FormattingEnabled = true;
			this.cboExtensionName.Items.AddRange(new object[] {
            "Jr",
            "Sr",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII",
            "IX",
            "X"});
			this.cboExtensionName.Location = new System.Drawing.Point(223, 121);
			this.cboExtensionName.Name = "cboExtensionName";
			this.cboExtensionName.Size = new System.Drawing.Size(186, 24);
			this.cboExtensionName.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(20, 100);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(119, 18);
			this.label6.TabIndex = 9;
			this.label6.Text = "Student Number:";
			// 
			// cboCivilStatus
			// 
			this.cboCivilStatus.FormattingEnabled = true;
			this.cboCivilStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widowed",
            "Divorced",
            "Seperated"});
			this.cboCivilStatus.Location = new System.Drawing.Point(660, 121);
			this.cboCivilStatus.Name = "cboCivilStatus";
			this.cboCivilStatus.Size = new System.Drawing.Size(217, 24);
			this.cboCivilStatus.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(20, 179);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 18);
			this.label7.TabIndex = 13;
			this.label7.Text = "Sex:";
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpBirthDate.Location = new System.Drawing.Point(530, 196);
			this.dtpBirthDate.MaxDate = new System.DateTime(2011, 12, 31, 0, 0, 0, 0);
			this.dtpBirthDate.MinDate = new System.DateTime(1976, 1, 1, 0, 0, 0, 0);
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.Size = new System.Drawing.Size(249, 24);
			this.dtpBirthDate.TabIndex = 14;
			this.dtpBirthDate.Value = new System.DateTime(2011, 12, 25, 23, 59, 0, 0);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(657, 100);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 18);
			this.label8.TabIndex = 15;
			this.label8.Text = "Civil Status:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(527, 175);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(94, 18);
			this.label9.TabIndex = 16;
			this.label9.Text = "Date of Birth:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(20, 238);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 18);
			this.label10.TabIndex = 17;
			this.label10.Text = "Place of Birth:";
			// 
			// txtPlaceOfBirth
			// 
			this.txtPlaceOfBirth.Location = new System.Drawing.Point(23, 259);
			this.txtPlaceOfBirth.Multiline = true;
			this.txtPlaceOfBirth.Name = "txtPlaceOfBirth";
			this.txtPlaceOfBirth.Size = new System.Drawing.Size(393, 24);
			this.txtPlaceOfBirth.TabIndex = 18;
			this.txtPlaceOfBirth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaceOfBirth_KeyPress);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(20, 295);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(107, 18);
			this.label11.TabIndex = 27;
			this.label11.Text = "Email Address:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(20, 353);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(113, 18);
			this.label12.TabIndex = 28;
			this.label12.Text = "Mobile Number:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel1.Controls.Add(this.txtMobileNumber);
			this.panel1.Controls.Add(this.txtEmail);
			this.panel1.Controls.Add(this.numAge);
			this.panel1.Controls.Add(this.btnUpload);
			this.panel1.Controls.Add(this.picStudent);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.txtStudentNumber);
			this.panel1.Controls.Add(this.rbFemale);
			this.panel1.Controls.Add(this.rbMale);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.txtReligion);
			this.panel1.Controls.Add(this.txtLastName);
			this.panel1.Controls.Add(this.txtMiddleName);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.txtPlaceOfBirth);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.dtpBirthDate);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.cboCivilStatus);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.cboExtensionName);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtFirstName);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(23, 87);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(945, 420);
			this.panel1.TabIndex = 1;
			// 
			// txtMobileNumber
			// 
			this.txtMobileNumber.Location = new System.Drawing.Point(23, 374);
			this.txtMobileNumber.Multiline = true;
			this.txtMobileNumber.Name = "txtMobileNumber";
			this.txtMobileNumber.Size = new System.Drawing.Size(393, 24);
			this.txtMobileNumber.TabIndex = 40;
			this.txtMobileNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileNumber_KeyPress);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(23, 316);
			this.txtEmail.Multiline = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(393, 24);
			this.txtEmail.TabIndex = 39;
			this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
			// 
			// numAge
			// 
			this.numAge.BackColor = System.Drawing.SystemColors.Window;
			this.numAge.Location = new System.Drawing.Point(438, 121);
			this.numAge.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numAge.Name = "numAge";
			this.numAge.ReadOnly = true;
			this.numAge.Size = new System.Drawing.Size(201, 22);
			this.numAge.TabIndex = 38;
			// 
			// btnUpload
			// 
			this.btnUpload.Location = new System.Drawing.Point(743, 305);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(119, 45);
			this.btnUpload.TabIndex = 2;
			this.btnUpload.Text = "UPLOAD";
			this.btnUpload.UseVisualStyleBackColor = true;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// picStudent
			// 
			this.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picStudent.Location = new System.Drawing.Point(476, 259);
			this.picStudent.Name = "picStudent";
			this.picStudent.Size = new System.Drawing.Size(237, 139);
			this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picStudent.TabIndex = 37;
			this.picStudent.TabStop = false;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(435, 100);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(37, 18);
			this.label14.TabIndex = 36;
			this.label14.Text = "Age:";
			// 
			// txtStudentNumber
			// 
			this.txtStudentNumber.Location = new System.Drawing.Point(23, 121);
			this.txtStudentNumber.Multiline = true;
			this.txtStudentNumber.Name = "txtStudentNumber";
			this.txtStudentNumber.Size = new System.Drawing.Size(170, 24);
			this.txtStudentNumber.TabIndex = 35;
			this.txtStudentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentNumber_KeyPress);
			// 
			// rbFemale
			// 
			this.rbFemale.AutoSize = true;
			this.rbFemale.Location = new System.Drawing.Point(119, 200);
			this.rbFemale.Name = "rbFemale";
			this.rbFemale.Size = new System.Drawing.Size(74, 20);
			this.rbFemale.TabIndex = 34;
			this.rbFemale.TabStop = true;
			this.rbFemale.Text = "Female";
			this.rbFemale.UseVisualStyleBackColor = true;
			// 
			// rbMale
			// 
			this.rbMale.AutoSize = true;
			this.rbMale.Location = new System.Drawing.Point(23, 200);
			this.rbMale.Name = "rbMale";
			this.rbMale.Size = new System.Drawing.Size(58, 20);
			this.rbMale.TabIndex = 33;
			this.rbMale.TabStop = true;
			this.rbMale.Text = "Male";
			this.rbMale.UseVisualStyleBackColor = true;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(223, 175);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(65, 18);
			this.label13.TabIndex = 32;
			this.label13.Text = "Religion:";
			// 
			// txtReligion
			// 
			this.txtReligion.Location = new System.Drawing.Point(223, 196);
			this.txtReligion.Multiline = true;
			this.txtReligion.Name = "txtReligion";
			this.txtReligion.Size = new System.Drawing.Size(246, 24);
			this.txtReligion.TabIndex = 31;
			this.txtReligion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReligion_KeyPress);
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(628, 43);
			this.txtLastName.Multiline = true;
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(272, 24);
			this.txtLastName.TabIndex = 30;
			this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
			// 
			// txtMiddleName
			// 
			this.txtMiddleName.Location = new System.Drawing.Point(325, 43);
			this.txtMiddleName.Multiline = true;
			this.txtMiddleName.Name = "txtMiddleName";
			this.txtMiddleName.Size = new System.Drawing.Size(272, 24);
			this.txtMiddleName.TabIndex = 29;
			this.txtMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiddleName_KeyPress);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(19, 20);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(174, 22);
			this.label15.TabIndex = 1;
			this.label15.Text = "Personal Information";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel4.Controls.Add(this.btnNext);
			this.panel4.Location = new System.Drawing.Point(23, 513);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(945, 44);
			this.panel4.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.SkyBlue;
			this.panel2.Controls.Add(this.label15);
			this.panel2.Location = new System.Drawing.Point(23, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(942, 59);
			this.panel2.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(990, 574);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboExtensionName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboCivilStatus;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtpBirthDate;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtPlaceOfBirth;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtMiddleName;
		private System.Windows.Forms.RadioButton rbFemale;
		private System.Windows.Forms.RadioButton rbMale;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtReligion;
		private System.Windows.Forms.TextBox txtStudentNumber;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.PictureBox picStudent;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.NumericUpDown numAge;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox txtMobileNumber;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel2;
	}
}


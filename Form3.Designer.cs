namespace StudentInformationSystemFull
{
	partial class Form3
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
			this.btnBack = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cboFatherExtension = new System.Windows.Forms.ComboBox();
			this.txtGuardianEmail = new System.Windows.Forms.TextBox();
			this.txtGuardianContact = new System.Windows.Forms.TextBox();
			this.txtGuardianRelationship = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txtGuardianLastName = new System.Windows.Forms.TextBox();
			this.txtGuardianMiddleName = new System.Windows.Forms.TextBox();
			this.txtGuardianFirstName = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtMotherLastName = new System.Windows.Forms.TextBox();
			this.txtMotherMiddleName = new System.Windows.Forms.TextBox();
			this.txtMotherFirstName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtFatherLastName = new System.Windows.Forms.TextBox();
			this.txtFatherMiddleName = new System.Windows.Forms.TextBox();
			this.txtFatherFirstName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(706, 6);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(113, 30);
			this.btnBack.TabIndex = 2;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(825, 6);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(113, 30);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(14, 5);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(155, 22);
			this.label15.TabIndex = 1;
			this.label15.Text = "Family Information";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.cboFatherExtension);
			this.panel1.Controls.Add(this.txtGuardianEmail);
			this.panel1.Controls.Add(this.txtGuardianContact);
			this.panel1.Controls.Add(this.txtGuardianRelationship);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.txtGuardianLastName);
			this.panel1.Controls.Add(this.txtGuardianMiddleName);
			this.panel1.Controls.Add(this.txtGuardianFirstName);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txtMotherLastName);
			this.panel1.Controls.Add(this.txtMotherMiddleName);
			this.panel1.Controls.Add(this.txtMotherFirstName);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtFatherLastName);
			this.panel1.Controls.Add(this.txtFatherMiddleName);
			this.panel1.Controls.Add(this.txtFatherFirstName);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(27, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(959, 401);
			this.panel1.TabIndex = 4;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// cboFatherExtension
			// 
			this.cboFatherExtension.FormattingEnabled = true;
			this.cboFatherExtension.Items.AddRange(new object[] {
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
			this.cboFatherExtension.Location = new System.Drawing.Point(719, 48);
			this.cboFatherExtension.Name = "cboFatherExtension";
			this.cboFatherExtension.Size = new System.Drawing.Size(209, 24);
			this.cboFatherExtension.TabIndex = 72;
			// 
			// txtGuardianEmail
			// 
			this.txtGuardianEmail.Location = new System.Drawing.Point(629, 289);
			this.txtGuardianEmail.Multiline = true;
			this.txtGuardianEmail.Name = "txtGuardianEmail";
			this.txtGuardianEmail.Size = new System.Drawing.Size(271, 24);
			this.txtGuardianEmail.TabIndex = 56;
			this.txtGuardianEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuardianEmail_KeyPress);
			// 
			// txtGuardianContact
			// 
			this.txtGuardianContact.Location = new System.Drawing.Point(330, 289);
			this.txtGuardianContact.Multiline = true;
			this.txtGuardianContact.Name = "txtGuardianContact";
			this.txtGuardianContact.Size = new System.Drawing.Size(271, 24);
			this.txtGuardianContact.TabIndex = 55;
			this.txtGuardianContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuardianContact_KeyPress);
			// 
			// txtGuardianRelationship
			// 
			this.txtGuardianRelationship.Location = new System.Drawing.Point(25, 289);
			this.txtGuardianRelationship.Multiline = true;
			this.txtGuardianRelationship.Name = "txtGuardianRelationship";
			this.txtGuardianRelationship.Size = new System.Drawing.Size(271, 24);
			this.txtGuardianRelationship.TabIndex = 54;
			this.txtGuardianRelationship.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuardianRelationship_KeyPress);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(327, 268);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(196, 18);
			this.label12.TabIndex = 53;
			this.label12.Text = "Guardian\'s Contact Number:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(626, 268);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(182, 18);
			this.label13.TabIndex = 52;
			this.label13.Text = "Guardian\'s Email Address:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(22, 268);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(168, 18);
			this.label14.TabIndex = 51;
			this.label14.Text = "Guardian\'s Relationship:";
			// 
			// txtGuardianLastName
			// 
			this.txtGuardianLastName.Location = new System.Drawing.Point(629, 225);
			this.txtGuardianLastName.Multiline = true;
			this.txtGuardianLastName.Name = "txtGuardianLastName";
			this.txtGuardianLastName.Size = new System.Drawing.Size(271, 24);
			this.txtGuardianLastName.TabIndex = 50;
			this.txtGuardianLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuardianLastName_KeyPress);
			// 
			// txtGuardianMiddleName
			// 
			this.txtGuardianMiddleName.Location = new System.Drawing.Point(330, 225);
			this.txtGuardianMiddleName.Multiline = true;
			this.txtGuardianMiddleName.Name = "txtGuardianMiddleName";
			this.txtGuardianMiddleName.Size = new System.Drawing.Size(271, 24);
			this.txtGuardianMiddleName.TabIndex = 49;
			this.txtGuardianMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuardianMiddleName_KeyPress);
			// 
			// txtGuardianFirstName
			// 
			this.txtGuardianFirstName.Location = new System.Drawing.Point(25, 225);
			this.txtGuardianFirstName.Multiline = true;
			this.txtGuardianFirstName.Name = "txtGuardianFirstName";
			this.txtGuardianFirstName.Size = new System.Drawing.Size(271, 24);
			this.txtGuardianFirstName.TabIndex = 48;
			this.txtGuardianFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuardianFirstName_KeyPress);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(327, 204);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(174, 18);
			this.label9.TabIndex = 47;
			this.label9.Text = "Guardian\'s Middle Name:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(626, 204);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(159, 18);
			this.label10.TabIndex = 46;
			this.label10.Text = "Guardian\'s Last Name:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(22, 204);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(160, 18);
			this.label11.TabIndex = 45;
			this.label11.Text = "Guardian\'s First Name:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(19, 162);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(193, 22);
			this.label8.TabIndex = 2;
			this.label8.Text = "Emergency Information";
			// 
			// txtMotherLastName
			// 
			this.txtMotherLastName.Location = new System.Drawing.Point(629, 112);
			this.txtMotherLastName.Multiline = true;
			this.txtMotherLastName.Name = "txtMotherLastName";
			this.txtMotherLastName.Size = new System.Drawing.Size(271, 24);
			this.txtMotherLastName.TabIndex = 44;
			this.txtMotherLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotherLastName_KeyPress);
			// 
			// txtMotherMiddleName
			// 
			this.txtMotherMiddleName.Location = new System.Drawing.Point(330, 112);
			this.txtMotherMiddleName.Multiline = true;
			this.txtMotherMiddleName.Name = "txtMotherMiddleName";
			this.txtMotherMiddleName.Size = new System.Drawing.Size(271, 24);
			this.txtMotherMiddleName.TabIndex = 43;
			this.txtMotherMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotherMiddleName_KeyPress);
			// 
			// txtMotherFirstName
			// 
			this.txtMotherFirstName.Location = new System.Drawing.Point(25, 112);
			this.txtMotherFirstName.Multiline = true;
			this.txtMotherFirstName.Name = "txtMotherFirstName";
			this.txtMotherFirstName.Size = new System.Drawing.Size(271, 24);
			this.txtMotherFirstName.TabIndex = 42;
			this.txtMotherFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotherFirstName_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(327, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 18);
			this.label1.TabIndex = 41;
			this.label1.Text = "Mother\'s Middle Name:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(626, 91);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(146, 18);
			this.label6.TabIndex = 40;
			this.label6.Text = "Mother\'s Last Name:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(22, 91);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(147, 18);
			this.label7.TabIndex = 39;
			this.label7.Text = "Mother\'s First Name:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(716, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(178, 18);
			this.label5.TabIndex = 31;
			this.label5.Text = "Father\'s Extension Name:";
			// 
			// txtFatherLastName
			// 
			this.txtFatherLastName.Location = new System.Drawing.Point(488, 48);
			this.txtFatherLastName.Multiline = true;
			this.txtFatherLastName.Name = "txtFatherLastName";
			this.txtFatherLastName.Size = new System.Drawing.Size(209, 24);
			this.txtFatherLastName.TabIndex = 30;
			this.txtFatherLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFatherLastName_KeyPress);
			// 
			// txtFatherMiddleName
			// 
			this.txtFatherMiddleName.Location = new System.Drawing.Point(256, 48);
			this.txtFatherMiddleName.Multiline = true;
			this.txtFatherMiddleName.Name = "txtFatherMiddleName";
			this.txtFatherMiddleName.Size = new System.Drawing.Size(207, 24);
			this.txtFatherMiddleName.TabIndex = 29;
			this.txtFatherMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFatherMiddleName_KeyPress);
			// 
			// txtFatherFirstName
			// 
			this.txtFatherFirstName.Location = new System.Drawing.Point(23, 48);
			this.txtFatherFirstName.Multiline = true;
			this.txtFatherFirstName.Name = "txtFatherFirstName";
			this.txtFatherFirstName.Size = new System.Drawing.Size(207, 24);
			this.txtFatherFirstName.TabIndex = 4;
			this.txtFatherFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFatherFirstName_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(253, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(156, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Father\'s Middle Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(485, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(141, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Father\'s Last Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Father\'s First Name:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel4.Controls.Add(this.btnBack);
			this.panel4.Controls.Add(this.btnNext);
			this.panel4.Location = new System.Drawing.Point(27, 432);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(959, 44);
			this.panel4.TabIndex = 6;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1010, 495);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Name = "Form3";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtFatherLastName;
		private System.Windows.Forms.TextBox txtFatherMiddleName;
		private System.Windows.Forms.TextBox txtFatherFirstName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMotherLastName;
		private System.Windows.Forms.TextBox txtMotherMiddleName;
		private System.Windows.Forms.TextBox txtMotherFirstName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtGuardianEmail;
		private System.Windows.Forms.TextBox txtGuardianContact;
		private System.Windows.Forms.TextBox txtGuardianRelationship;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtGuardianLastName;
		private System.Windows.Forms.TextBox txtGuardianMiddleName;
		private System.Windows.Forms.TextBox txtGuardianFirstName;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.ComboBox cboFatherExtension;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Panel panel4;
	}
}
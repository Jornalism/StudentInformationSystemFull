namespace StudentInformationSystemFull
{
	partial class Form2
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
			this.label1 = new System.Windows.Forms.Label();
			this.panel1lll = new System.Windows.Forms.Panel();
			this.cboCity = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.cboBarangay = new System.Windows.Forms.ComboBox();
			this.cboProvince = new System.Windows.Forms.ComboBox();
			this.txtHouseStreet = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cboRegion = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.panellll = new System.Windows.Forms.Panel();
			this.panel1lll.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.panellll.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(645, 206);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(113, 30);
			this.btnBack.TabIndex = 2;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(764, 206);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(113, 30);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Address Information";
			// 
			// panel1lll
			// 
			this.panel1lll.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel1lll.Controls.Add(this.btnBack);
			this.panel1lll.Controls.Add(this.cboCity);
			this.panel1lll.Controls.Add(this.btnNext);
			this.panel1lll.Controls.Add(this.label17);
			this.panel1lll.Controls.Add(this.txtZipCode);
			this.panel1lll.Controls.Add(this.label16);
			this.panel1lll.Controls.Add(this.label15);
			this.panel1lll.Controls.Add(this.cboBarangay);
			this.panel1lll.Controls.Add(this.cboProvince);
			this.panel1lll.Controls.Add(this.txtHouseStreet);
			this.panel1lll.Controls.Add(this.label8);
			this.panel1lll.Controls.Add(this.cboRegion);
			this.panel1lll.Controls.Add(this.label4);
			this.panel1lll.Controls.Add(this.label3);
			this.panel1lll.Controls.Add(this.label2);
			this.panel1lll.Location = new System.Drawing.Point(25, 83);
			this.panel1lll.Name = "panel1lll";
			this.panel1lll.Size = new System.Drawing.Size(900, 248);
			this.panel1lll.TabIndex = 4;
			// 
			// cboCity
			// 
			this.cboCity.FormattingEnabled = true;
			this.cboCity.Items.AddRange(new object[] {
            "City Of Muntinlupa"});
			this.cboCity.Location = new System.Drawing.Point(605, 67);
			this.cboCity.Name = "cboCity";
			this.cboCity.Size = new System.Drawing.Size(265, 24);
			this.cboCity.TabIndex = 42;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label17.Location = new System.Drawing.Point(19, 15);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(143, 22);
			this.label17.TabIndex = 1;
			this.label17.Text = "Present Address";
			// 
			// txtZipCode
			// 
			this.txtZipCode.Location = new System.Drawing.Point(605, 131);
			this.txtZipCode.Multiline = true;
			this.txtZipCode.Name = "txtZipCode";
			this.txtZipCode.Size = new System.Drawing.Size(272, 24);
			this.txtZipCode.TabIndex = 41;
			this.txtZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZipCode_KeyPress);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(310, 110);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(169, 18);
			this.label16.TabIndex = 40;
			this.label16.Text = "House No/ Block/ Street";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(20, 110);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(70, 18);
			this.label15.TabIndex = 39;
			this.label15.Text = "Barangay";
			// 
			// cboBarangay
			// 
			this.cboBarangay.FormattingEnabled = true;
			this.cboBarangay.Items.AddRange(new object[] {
            "Alabang"});
			this.cboBarangay.Location = new System.Drawing.Point(23, 131);
			this.cboBarangay.Name = "cboBarangay";
			this.cboBarangay.Size = new System.Drawing.Size(265, 24);
			this.cboBarangay.TabIndex = 38;
			// 
			// cboProvince
			// 
			this.cboProvince.FormattingEnabled = true;
			this.cboProvince.Items.AddRange(new object[] {
            "NCR, Fourth District"});
			this.cboProvince.Location = new System.Drawing.Point(313, 67);
			this.cboProvince.Name = "cboProvince";
			this.cboProvince.Size = new System.Drawing.Size(265, 24);
			this.cboProvince.TabIndex = 37;
			// 
			// txtHouseStreet
			// 
			this.txtHouseStreet.Location = new System.Drawing.Point(313, 131);
			this.txtHouseStreet.Multiline = true;
			this.txtHouseStreet.Name = "txtHouseStreet";
			this.txtHouseStreet.Size = new System.Drawing.Size(265, 24);
			this.txtHouseStreet.TabIndex = 29;
			this.txtHouseStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHouseStreet_KeyPress);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(602, 110);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 18);
			this.label8.TabIndex = 15;
			this.label8.Text = "Zip Code";
			// 
			// cboRegion
			// 
			this.cboRegion.FormattingEnabled = true;
			this.cboRegion.Items.AddRange(new object[] {
            "NATIONAL CAPITAL REGION (NCR)"});
			this.cboRegion.Location = new System.Drawing.Point(23, 67);
			this.cboRegion.Name = "cboRegion";
			this.cboRegion.Size = new System.Drawing.Size(265, 24);
			this.cboRegion.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(310, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Province";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(602, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "City / Municipality";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Region";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// panellll
			// 
			this.panellll.BackColor = System.Drawing.Color.SkyBlue;
			this.panellll.Controls.Add(this.label1);
			this.panellll.Location = new System.Drawing.Point(25, 24);
			this.panellll.Name = "panellll";
			this.panellll.Size = new System.Drawing.Size(900, 59);
			this.panellll.TabIndex = 5;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(955, 369);
			this.Controls.Add(this.panellll);
			this.Controls.Add(this.panel1lll);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.panel1lll.ResumeLayout(false);
			this.panel1lll.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.panellll.ResumeLayout(false);
			this.panellll.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1lll;
		private System.Windows.Forms.TextBox txtHouseStreet;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cboRegion;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox cboBarangay;
		private System.Windows.Forms.ComboBox cboProvince;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtZipCode;
		private System.Windows.Forms.ComboBox cboCity;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Panel panellll;
	}
}
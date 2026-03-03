using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystemFull
{
	public class StudentData
	{
		// PERSONAL
		public string FirstName;
		public string MiddleName;
		public string LastName;
		public string StudentNumber;
		public string ExtensionName;
		public int Age;
		public string CivilStatus;
		public string Gender;
		public DateTime BirthDate;
		public string Religion;
		public string PlaceOfBirth;
		public string Email;
		public string MobileNumber;
		public Image StudentImage;

		// ADDRESS
		public string Region;
		public string Province;
		public string City;
		public string Barangay;
		public string HouseStreet;
		public string ZipCode;

		// FAMILY
		public string FatherFirstName;
		public string FatherMiddleName;
		public string FatherLastName;
		public string FatherExtension;

		public string MotherFirstName;
		public string MotherMiddleName;
		public string MotherLastName;

		public string GuardianFirstName;
		public string GuardianMiddleName;
		public string GuardianLastName;
	    public string GuardianRelationship;
		public string GuardianContact;
		public string GuardianEmail;


		// EDUCATION
		public string StudentType;
		public string LearnersRefNo;
		public string SchoolClassification;

		public string LastSchool;
		public string YearGraduated;
		public string Strand;

		public string SchoolStreet;
		public string SchoolCity;
	    public string SchoolProvince;

		public string ProgramFirstChoice;
		public string ProgramSecondChoice;

		// FLAG — true when user completed all 4 forms
		public bool CompletedAllForms;
	}
}


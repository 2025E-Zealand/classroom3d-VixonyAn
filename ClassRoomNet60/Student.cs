using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
	public class Student
	{
		#region instance fields
		private string name;
		private int birthMonth;
		private int birthDate;
		private string seasonName;
		#endregion

		#region properties
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public int BirthMonth
		{
			get { return birthMonth; }
			set { birthMonth = value; }
		}
		public int BirthDate
		{
			get { return birthDate; }
			set { birthDate = value; }
		}
		public string SeasonName
		{
			get { return seasonName; }
			set { seasonName = value; }
		}
		#endregion

		public Student(string name, int birthMonth, int birthDate)
		{
			Name = name;
			BirthMonth = birthMonth;
			BirthDate = birthDate;
		}

		public string Season()
		{
			switch (BirthMonth)
			{
				case 12:
				case 1:
				case 2:
					return "Winter";
				case 3:
				case 4:
				case 5:
					return "Spring";
				case 6:
				case 7:
				case 8:
					return "Summer";
				case 9:
				case 10:
				case 11:
					return "Autumn";
			}
			return "Error";
		}
	}
}

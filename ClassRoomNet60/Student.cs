using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
	public class Student
	{
		private string name;
		private int birthMonth;
		private int birthDate;

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

		public Student(string name, int birthMonth, int birthDate)
		{
			Name = name;
			BirthMonth = birthMonth;
			BirthDate = birthDate;
		}

	}
}

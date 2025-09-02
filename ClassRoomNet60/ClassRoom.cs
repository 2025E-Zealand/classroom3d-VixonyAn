using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassRoomNet60
{
	public class ClassRoom
	{
		public string ClassName;
		public List<Student> StudentList;
		public DateTime SemesterStart;

		public ClassRoom(string className, DateTime semesterStart)
		{
			ClassName = className;
			SemesterStart = semesterStart;
			StudentList = new List<Student>();
		}

		public void PrintStudentInfo()
		{
			Console.WriteLine($"Class name: {ClassName}\n" +
			$"Semester Start: {SemesterStart.ToString()}\n");
			foreach (var student in StudentList)
			{
				Console.WriteLine($"Student Name: {student.Name}\n" +
								  $"Student Birthday: {student.BirthMonth}/{student.BirthDate}\n");
			}
		}

		public void PrintSeasonStatistics()
		{
			var Winter = 0; var Spring = 0;	var Summer = 0; var Autumn = 0;
			foreach (var student in StudentList)
			{
				if (student.Season() == "Winter")
				{
					Winter++;
				}
				else if (student.Season() == "Spring")
				{
					Spring++;
				}
				else if (student.Season() == "Summer")
				{
					Summer++;
				}
				else if (student.Season() == "Autumn")
				{
					Autumn++;
				}
			}
			Console.WriteLine($"Winter birthdays: {Winter}\n" +
							  $"Spring birthdays: {Spring}\n" +
							  $"Summer birthdays: {Summer}\n" +
							  $"Autumn birthdays: {Autumn}\n");
		}
	}
}

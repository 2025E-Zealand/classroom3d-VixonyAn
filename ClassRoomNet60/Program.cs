using ClassRoomNet60;

ClassRoom ClassAD = new ClassRoom("AD", DateTime.Now);
Student Sofie = new Student("Sofie", 5, 13);
Student Vincent = new Student("Vincent", 3, 22);
Student Kristoffer = new Student("Kristoffer", 8, 7);
ClassAD.StudentList.Add(Sofie);
ClassAD.StudentList.Add(Vincent);
ClassAD.StudentList.Add(Kristoffer);

ClassAD.PrintStudentInfo();

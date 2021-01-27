using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = (File.ReadAllLines("studentdataRandom100Rows.csv"));

            List<Student> students = new List<Student>();

            Student stud = new Student();
            stud.FirstName = "Adam";
            stud.LastName = "Ackerman";
            stud.FavoriteColor = "blue";
            stud.ID = 1;
            Console.WriteLine(stud.CreateFullName());

            for(int i =1;i<lines.Length; i++)
            {
                string line = lines[i];

                string[] pieces = line.Split(',');

                //int id = Convert.ToInt32(pieces[0]);

                Student curentStudent = new Student(Convert.ToInt32(pieces[0]), pieces[1], pieces[2], pieces[3]);

                students.Add(curentStudent);
            }

            //output all the students whose favorite color is Puce
            foreach(var student in students)
            {
                if (student.FavoriteColor.ToLower() == "puce")
                {
                    Console.WriteLine(student);
                }
            }

            //foreach (var line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            Console.ReadKey();
        }
    }
}

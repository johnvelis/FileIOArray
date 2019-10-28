using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataPath = @"Data\Students.txt";
            string[] students;

            students = new string[3];
            students[0] = "Sue, McWaters, 34";
            students[1] = "Bill, Tompson, 23";
            students[2] = "Charlie, Velis, 22";

            WriteAllStudents(dataPath, students);

            students = ReadAllStudent(dataPath);

            DisplayAllStudents(students);
        }

        static string[] ReadAllStudent(string dataPath)
        {
            string[] students;

            students = File.ReadAllLines(dataPath);

            return students;
        }

        static void WriteAllStudents(string dataPath, string[] students)
        {
            File.WriteAllLines(dataPath, students);
        }

        static void DisplayAllStudents(string[] students)
        {
            Console.WriteLine();
            Console.WriteLine("All Students");
            Console.WriteLine();

            //
            // table headers
            //
            Console.WriteLine(
                "First Name".PadRight(20) +
                "Last Name".PadRight(20) +
                "Age".PadRight(20)
                );
            Console.WriteLine(
                "--------".PadRight(20) +
                "--------".PadRight(20) +
                "--------".PadRight(20)
                );

            //
            // table of students
            //
            foreach (string student in students)
            {
                string[] studentInfo = student.Split(',');
                Console.WriteLine(
                    studentInfo[0].PadRight(20) +
                    studentInfo[1].PadRight(20) +
                    studentInfo[2].PadRight(20)
                    );
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}

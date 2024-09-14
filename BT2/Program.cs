using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Show List of Student");
                Console.WriteLine("3. Filter Student Age(15-18)");
                Console.WriteLine("4. Filter Student Name start with 'A' ");
                Console.WriteLine("5. Sum of all Student Age in List");
                Console.WriteLine("6. Find and print out Oldest Student");
                Console.WriteLine("7. Arrange and print out Student list from youngest to oldest");
                Console.WriteLine("0. Exit");
                Console.WriteLine("=== ==== ===");
                Console.Write("Choose (0-7): ");
                Console.WriteLine();

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddStudent(studentList);

                        break;
                    //QUEST A:
                    case "2":
                        DisplayStudentList(studentList);

                        break;
                    //QUEST B:
                    case "3":
                        FilteredAge(studentList);

                        break;
                    //QUEST C:
                    case "4":
                        FilteredName(studentList);

                        break;
                    //QUEST D:
                    case "5":
                        SumAge(studentList);

                        break;
                    //QUEST E:
                    case "6":
                        Oldest(studentList);

                        break;
                    //QUEST F:
                    case "7":
                        Arrange(studentList);

                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("End The Program.");
                        break;
                    default:
                        Console.WriteLine("Try again.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void AddStudent(List<Student> studentList)
        {
            string continueAdding;
            do {
                Console.WriteLine("=== Enter Student Info ===");
                Student student = new Student();
                student.Input();
                studentList.Add(student);
                Console.WriteLine("Adding Sucess!");
                Console.Write("Would you like to add another student? (y/n): ");
                continueAdding = Console.ReadLine().Trim().ToLower();
            } while (continueAdding == "y");
            Console.WriteLine();
            Console.WriteLine("=== ==================== ===");
        }

        static void DisplayStudentList(List<Student> studentList)
        {
            Console.WriteLine("=== List ===");
            foreach (Student student in studentList)
            {
                student.Output();
            }
            Console.WriteLine();
        }

        static void FilteredAge(List<Student> studentList)
        {
            Console.WriteLine("=== AgeFilter ===");
            var filteredStudents = studentList.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            foreach (var student in filteredStudents)
            {
                student.Output();
            }
            Console.WriteLine("=== ========= ===");
            Console.WriteLine();
        }

        static void FilteredName(List<Student> studentList)
        {
            Console.WriteLine();
            Console.WriteLine("=== Name Filter: Starts with 'A' ===");
            var filteredStudents = studentList.Where(s => s.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (var student in filteredStudents)
            {
                student.Output();
            }
            Console.WriteLine("=== ============================ ===");
            Console.WriteLine();
        }

        static void SumAge(List<Student> studentList)
        {
            Console.WriteLine("=== Sum of Everyone Age ===");
            int sum = studentList.Sum(s => s.Age);
            Console.WriteLine("Total:");
            Console.WriteLine(sum.ToString());
            Console.WriteLine("=== =================== ===");
            Console.WriteLine();
        }
        static void Oldest(List<Student> studentList)
        {
            Console.WriteLine("=== Oldest Age ===");
            var oldestStudent = studentList.OrderByDescending(s => s.Age).FirstOrDefault();
            if (oldestStudent != null)
            {
                oldestStudent.Output();
            }
            Console.WriteLine("=== ========== ===");
            Console.WriteLine();
        }
        static void Arrange(List<Student> studentList)
        {
            Console.WriteLine("=== Arrange List ===");
            var sortedStudent = studentList.OrderBy(s => s.Age).ToList();
            foreach (var student in sortedStudent) {
                student.Output();
            }
            Console.WriteLine("=== ========== ===");
            Console.WriteLine();
        }
    }
}

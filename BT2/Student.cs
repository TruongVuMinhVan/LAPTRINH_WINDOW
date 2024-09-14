using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class Student
    {
        public int ID;
        public string Name;
        public int Age;

        public int StudentID { get => ID; set => ID = value; }
        public string FullName { get => Name; set => Name = value; }
        public int StudentAge { get => Age; set => Age = value; }

        public Student() { }

        public Student(int ID, string Name, int Age)
        {

            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
        }
        public void Input()
        { 
            Console.WriteLine("Enter Student ID: ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Student Age:");
            Age = Convert.ToInt32(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("ID:{0} Name:{1} Age:{2}", this.StudentID, this.FullName, this.StudentAge);
        }
        
    }
}

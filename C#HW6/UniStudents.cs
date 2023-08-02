using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW6
{
    internal class UniStudents
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }

        public UniStudents(string name, string surname, int age, int point)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;  

        }
        public virtual void TakeExam(int point)
        {
            if (point > 50)
            {
                Console.WriteLine("You can take an exam");
            }
            else
            {
                Console.WriteLine("You failed");
            }
        }
    }
}

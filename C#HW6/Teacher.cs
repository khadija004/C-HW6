using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW6
{
    internal class Teacher:UniStudents,IAzeSectorable
    {
        public Teacher(string name, string surname, int age,int point) : base(name, surname, age,point)
        {
            
        }

        public void Graduate()
        {
            if (Point>50)
            {
                Console.WriteLine("You graduated");
            }
            else
            {
                Console.WriteLine("You failed");
            }
        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying teacher in Azerbaijan.");

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW6
{
    internal class Engineer:UniStudents,IEngSectorable
    {
        public string Project { get; set; }

        public Engineer(string name, string surname, int age, string project, int point) : base(name, surname, age, point)
        {

            Project = project;

        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying engineering in English.");
        }

        public override void TakeExam(int point)
        {
            if (point > 80)
            {
                Console.WriteLine("You can take an exam");
            }
            else
            {
                Console.WriteLine("You failed");
            }
        }

        public void Graduate()
        {
            if (Point>80)
            {
                Console.WriteLine("You graduated with high honour");
            }
            else if (Point>70 && Point<80)
            {
                Console.WriteLine("You graduated with honour");
            }
            else
            {
                Console.WriteLine("You graduated");
            }
        }
    }
}

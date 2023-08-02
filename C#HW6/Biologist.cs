using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW6
{
    internal class Biologist : UniStudents,IEngSectorable
    {
        public Biologist(string name,string surname,int age,int point):base(name, surname, age,point)
        {
            
        }

        public void Graduate()
        {
            if (Point>60)
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
            Console.WriteLine("You study microbiology in University");
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
    }
}

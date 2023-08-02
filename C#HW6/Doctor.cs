using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW6
{
    internal class Doctor : UniStudents,IAzeSectorable
    {
        public string HospitalInternship { get; set; }
        public Doctor(string name, string surname, int age, string hospitalInternship, int point) : base(name, surname, age, point)
        {

            HospitalInternship = hospitalInternship;

        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying medical in Azerbaijan.");

        }


        public void Graduate()
        {
            Console.WriteLine($"You graduated from {HospitalInternship}");
        }
    }
}

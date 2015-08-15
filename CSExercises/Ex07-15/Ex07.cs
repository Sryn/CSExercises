using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ex07 - Please type your salary and we'll show you the total of your salary + 10% housing and 3% transport allowances:");
            double Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("${0:0.00}", Salary + (Salary * 0.1) + (Salary * 0.03));
        }
    }
}

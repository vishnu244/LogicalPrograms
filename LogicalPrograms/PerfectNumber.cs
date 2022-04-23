using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void perfefctnumber()
        {
            int x, sum = 0;
            Console.Write("enter the Number : ");
            x = Convert.ToInt16(Console.ReadLine());

            Console.Write("Factors of {0} are : ",x);
            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                {
                    sum = sum + i;
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            if (sum == x)
            {
                Console.WriteLine("Entered number is a perfect number\n");
                
            }
            else
            {
                Console.WriteLine("Entered number is not a perfect number\n");
               
            }
        }

    }
}

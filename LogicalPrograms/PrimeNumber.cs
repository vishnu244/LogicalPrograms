using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public void primenumber()
        {
           
            Console.Write("Enter the Number to check : ");
            int N = (int)Convert.ToInt16(Console.ReadLine());
            int x = 0;
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    Console.Write("Number is not Prime.\n");
                    x = 1;
                }
            }
            if (x == 0)
                Console.Write("Number is Prime.\n" );
            
        }
    }
}

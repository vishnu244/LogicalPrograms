using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Febinocciseries
    {
        public void febinocciseries()
        {
            int a = 0, b = 1, c, i, number;
            Console.Write("Enter the number of elements: ");
            number = Convert.ToInt16(Console.ReadLine());

            Console.Write(a+ " " + b+ " ");    
            for (i = 2; i < number; i++)   
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.WriteLine("\n");

        }
    }
}

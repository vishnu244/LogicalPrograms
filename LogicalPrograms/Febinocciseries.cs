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
            int a = 0, b = 1, c, x;
            Console.Write("Enter the number of elements: ");
            x = Convert.ToInt16(Console.ReadLine());

            Console.Write(a+ " " + b+ " ");    
            for (int i = 2; i < x; i++)   
            {
                c = a + b;
                Console.Write( c + " ");
                a = b;
                b = c;
                
            }

            Console.WriteLine("\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public void reversenumber()
        {
            Console.WriteLine("Enter a Number to reverse");
            int Number = (int)Convert.ToInt16(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0)
            {
                int result = Number % 10;
                Reverse = (Reverse * 10) + result;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();
        }
    }
}

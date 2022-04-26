using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class couponcode
    {
        public void CouponCode()
        {
            Console.WriteLine("Enter number of digits :");
            int digits = Convert.ToInt16(Console.ReadLine());
            string coupon = string.Empty;
            while (digits > 0)
            {
                int random = new Random().Next(1, 123);
                coupon += (char)random;
                digits -- ;

            }
            Console.WriteLine("coupon number = " + coupon );
        }
    }
}

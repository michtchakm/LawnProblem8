using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lawn
{
    class Lawn
    {
        int area;
        int payment;

        public void LawnMowingPrice()
        {
            if (area < 400)
            {
                Console.WriteLine("$25");
            }

            if (area > 400 && area < 600)
            {           
                Console.WriteLine("$35");
            }

            if (area > 600)
            {        
                Console.WriteLine("$50");
            }

            if (payment == 1)
            {        
                Console.WriteLine("Seasonal total:");
            }

            if (payment == 2)
            {   
                Console.WriteLine("$5 + .5(Seasonal fee):");
            }
                
            if (payment == 20)
            {        
                 Console.WriteLine("$3(Weekly Price):");
            }

            Console.WriteLine("Enter area of lawn:");
            Console.WriteLine("Weekly fee:");
            Console.WriteLine("Total fee for 20-week season:");
            Console.WriteLine("Amount of times customer wants to pay:");
        }
    }
}

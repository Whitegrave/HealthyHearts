using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyHearts
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge = 0;
            // Request age and validate
            while (userAge == 0)
            {
                Console.WriteLine("What is your age?");
                string stringTemp = Console.ReadLine();
                int intTemp = 0;
                // Attempt to convert the string to an int, and check its range and value
                if (!int.TryParse(stringTemp, out intTemp) || intTemp < 1 || intTemp > 105)
                {
                    Console.WriteLine("That was not a valid age, try again.");    
                }
                // Validation passed to assign it to our age variable which also flags the loop to end
                else
                {
                    userAge = intTemp;
                }
            }
            Console.WriteLine($"Your maximum heart rate should be {220 - userAge} beats per minute.");
            // using the (int) cast to round and drop percentages of the resulint floats
            Console.WriteLine($"Your target HR Zone is {(int)((220 - userAge) * 0.64)} - {(int)((220 - userAge) * 0.76)} beats per minute.");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice1
{
    public enum MonthsOfYear
    {
        January = 1, February = 2, March = 3, April = 4, May = 5, June = 6, July = 7,
        August = 8, September = 9, October = 10, November = 11, December = 12
    };
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number 1 - 12");

           var userInput = Console.ReadLine();
           var inputAsNumber = Convert.ToInt32(userInput);
           

            if (inputAsNumber < 0 || inputAsNumber > 12)
            {
                Console.WriteLine("Invalid entry. Please enter a number 1 - 12");
     
                userInput = Console.ReadLine();
            }

            MonthsOfYear inputAsEnum = (MonthsOfYear)inputAsNumber;
            Console.WriteLine(inputAsEnum);
            

        }
    }
}

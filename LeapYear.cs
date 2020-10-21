using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static bool IsLeapYear(int year)
        {
            if(year % 4 == 0 && !(year % 100 == 0) || year % 400 == 0)
            {
                return true;
            }
            return false;
        }

        /*
         static bool IsLeapYearAlternative(int year)
        {
            return year % 4 == 0 && !(year % 100 == 0) || year % 400 == 0;
        }
        
         
         
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine(IsLeapYear(2020));
            Console.WriteLine(IsLeapYear(2013));
            
            
            
            
            
            
            
            /*Console.WriteLine("Give a year");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && !(year % 100 == 0) || year % 400 == 0)
            {
                Console.WriteLine(year + " is leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }*/
        }
    }
}

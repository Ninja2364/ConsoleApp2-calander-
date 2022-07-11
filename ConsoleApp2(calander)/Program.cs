using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_calander_
{
    internal class Program
    {
        class ftime
        {
            public static void Main(string[] args)
            {
                string dt = DateTime.Today.ToString("12-dd-yyyy");
                Console.WriteLine("Today is " + dt);
                Console.Write(dt[0]); Console.WriteLine(dt[1]);

                //gets month into a int
                string month = DateTime.Today.ToString("MM");
                Convert.ToInt32(month);
                //get month into an name
                string monthname = DateTime.Today.ToString("MMMM");

                //Keep as MM for number value
                Console.WriteLine(month);
                //get *day*
                string day = DateTime.Today.ToString("dd");
                Console.WriteLine(day);


                Console.WriteLine("Today is the " + day + " of " + monthname);

            }

            
        }
    }
}

using System;

namespace ConsoleApp2_calander_
{
    internal class Program
    {

        public class ftime
        {
             static void Main(string[] args)
            {
                 string dt = DateTime.Today.ToString("12-dd-yyyy");
                Console.WriteLine("Today is " + dt);
                Console.Write(dt[0]); Console.WriteLine(dt[1]);

             

                


                //get month into an name 
                 string monthname = DateTime.Today.ToString("MMMM");

                
                //get *day*
                 string day = DateTime.Today.ToString("dd");
                Console.WriteLine(day);


                Console.WriteLine("Today is the " + day + " of " + monthname);

               
                miscctime();
                
              








                //Find leap and parts of... year, days of that certain month (relate with leaps)

                 void miscctime()
                {
                    //Find how many days are in the month *ADD LEAPS SOME OTHER DAY*
                    


                    string month = DateTime.Today.ToString("MM");
                    //monthx is now int version
                    int monthx = Convert.ToInt32(month);
                       Console.WriteLine(month);

                    string year;
                    year = DateTime.Today.ToString("yyyy");
                    int yearx = Convert.ToInt32(year);

                    //for checks change monthhx remove // 
                   /* monthx = 3;
                    yearx = 3;
                    */
                    int daysinmonth = 31;
                    
                    if (yearx%4 == 0 && monthx == 2)
                    {
                        daysinmonth = 29;
                    }
                    else if (monthx == 2)
                    {
                        daysinmonth = 28;
                    }

                   
                    
                   /* if (monthx == 7)
                    {
                        daysinmonth = 31;
                    }
                   */
                    switch (monthx)
                    {
                     /*   case 1:
                            daysinmonth = 31;
                            break;
                        case 3:
                            daysinmonth = 31;
                            break;
                        case 5:
                            daysinmonth = 31;
                            break;
                        case 7:
                            daysinmonth = 31;
                            Console.WriteLine("heard");
                            break;
                        case 9:
                            daysinmonth = 31;
                            break;
                        case 11:
                            daysinmonth = 31;
                            break;
                     */
                        //check for the ones that are 30 days
                        case 4:
                            daysinmonth = 30;
                            break;
                        case 6:
                            daysinmonth = 30;
                            break;
                        case 8:
                            daysinmonth = 30;
                            break;
                        case 10:
                            daysinmonth = 30;
                            break;
                        case 12:
                            daysinmonth = 30;
                            break;
                    }
                            Console.WriteLine("there are " + daysinmonth);
                    



                }






            }
        }
    }
}

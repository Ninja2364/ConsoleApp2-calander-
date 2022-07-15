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
                
                int firstcol;
                bool isleap = false;
                //create string of month
                string month = DateTime.Today.ToString("MM");
                //monthx is now int version
                int monthx = Convert.ToInt32(month);
                Console.WriteLine(month);
                int daysinmonth = 31;
                //create string of year
                string year;
                year = DateTime.Today.ToString("yyyy");
                int yearx = Convert.ToInt32(year);
                string tyear = DateTime.Today.ToString("yy");
                int twoyear = Convert.ToInt32(tyear);
                //first day of the month
                int fday = 0;
                //represents each day
                int i = 1;
                int f = 1;
                int l = 0;
                //get month into an name 
                string monthname = DateTime.Today.ToString("MMMM");
                int end;

                //get *day*
                string day = DateTime.Today.ToString("dd");
                
                int dayx = Convert.ToInt32(day);

              



                display();

                miscctime();

                leapcheck();

                fwday();

                writetoday();


                //-----------------------------------end of first------------








                //Find leap and parts of... year, days of that certain month (relate with leaps)

                void miscctime()
                {
                    //Find how many days are in the month *ADD LEAPS SOME OTHER DAY*




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


                    if (yearx % 4 == 0 && monthx == 2)
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
                        case 9:
                            daysinmonth = 30;
                            break;
                        case 11:
                            daysinmonth = 30;
                            break;
                    }
                   




                }

                //check if the user wants today or other day else gets info of other day


                void leapcheck()
                {
                    yearx = Convert.ToInt32(year);
                    int leapcheck;
                    leapcheck = yearx % 4;
                    if (leapcheck == 0)
                    {
                        isleap = true;
                       
                    }

                }

                void display()
                {
                    Console.WriteLine("Type today for this months calander, elsewise type in your date in this format, mm-dd-yyyy:");
                    //can also ask for month/day/year seperately
                    string Istoday = Console.ReadLine();

                    if (Istoday == "today")
                    {
                        Console.WriteLine("You have chosen to see this month's calander");


                    }
                    else
                    {

                        string[] todayy = Istoday.Split('-');

                        string cmonth = todayy[0];
                        string cday = todayy[1];
                        string cyear = todayy[2];
                        month = cmonth;
                        day = cday;
                        year = cyear;

                        dayx = Convert.ToInt32(cday);
                        yearx = Convert.ToInt32(cyear);
                        monthx = Convert.ToInt32(cmonth);
                        Console.WriteLine(yearx);

                    }
                    Console.WriteLine(Istoday);
                    Console.WriteLine("Calander of ");
                    Console.WriteLine(month + "is the month rn");



                }

                //checks what is the first weekday of the month

                void fwday()
                {
                    string tyear = year.Substring(2);
                    twoyear = Convert.ToInt32(tyear);
                    int ffday;
                    int fffday;
                    fday = (twoyear / 4);

                    ffday = Convert.ToInt32(fday);




                    int monthvalue = 3;
                    

                    switch (monthx)
                    {
                        case 1:
                            monthvalue = 0;
                            break;
                        case 4:
                            monthvalue = 6;
                            break;
                        case 5:
                            monthvalue = 1;
                            break;
                        case 6:
                            monthvalue = 4;
                            break;
                        case 7:
                            monthvalue = 6;
                            break;
                        case 8:
                            monthvalue = 2;
                            break;
                        case 9:
                            monthvalue = 5;
                            break;
                        case 10:
                            monthvalue = 0;
                            break;
                        case 12:
                            monthvalue = 5;
                            break;

                    }
                    fffday = fday + twoyear + monthvalue + 1;
                   



                    tyear = year.Substring(0, 2);
                    
                    int ttyear = Convert.ToInt32(tyear);
              

                    if (ttyear == 20)
                        fffday = fffday + 6;
                    else if (ttyear == 17)
                        fffday = fffday + 4;
                    else if (ttyear == 18)
                        fffday = fffday + 2;


                  

                    fday = fffday % 7;

                    if (isleap)
                    {
                        fday = fday - 1;
                    }

                       





                }

                //writes calander
                void writetoday()
                {
                    firstcol = 9 - fday;
                    end = fday - 4;

                    Console.WriteLine("there are " + daysinmonth + " days in this month");
                    Console.WriteLine("today is " + month + "/" + day + "/" + year);
                    Console.WriteLine("Mon Tue Wed Thu Fri Sat Sun");




                    while (f < fday)
                    {



                        Console.Write("   .");


                        f++;
                    }
                    while (i < firstcol)
                    {

                        Console.Write("   " + i);
                        i++;
                    }


                    // second line-------------------
                    Console.WriteLine();
                    l = 0;

                    while (i<10)
                    {
                        Console.Write("   " + i);
                        i++;
                        l++;
                    }
                    while (l < 7)
                    {
                        Console.Write("  " + i);
                        i++;
                        l++;
                    }

                    /*
                    for (i = i; i < 10; i++)
                    {
                        Console.Write("   " + i);
                        l++;
                    }
                    Console.WriteLine(l);
                    end = 7 - l;
                    while (end > 0)
                    {
                        Console.Write(" " + i);
                        i++;
                        end--;
                    }
                    
                    */
                }
                    
                    // line 3
                    
                Console.WriteLine();
                l = 0;
                    for (i = i; l < 7; i++)
                    { 
                        Console.Write("  " + i);
                        l++;
                    }
                    //line 4
                    Console.WriteLine();

                    for (i = i; l < 14; i++)
                    {
                        if (i == daysinmonth)
                        {
                            l = 20;
                        }
                        else
                        {
                            Console.Write("  " + i);
                            l++;
                        }

                    }
                    Console.WriteLine();
                    for (i = i; l < 21; i++)
                    {
                        if (i > daysinmonth)
                        {
                            l = 21;
                        }
                        else
                        {
                            Console.Write("  " + i);
                            l++;
                        }

                    }
                    Console.WriteLine();

                    for (i = i; l < 23; i++)
                    {
                        if (i > daysinmonth)
                        {
                            l = 23;
                        }
                        else
                        {
                            Console.Write("  " + i);
                            l++;
                        }

                    }


                }




            }
        }
    }


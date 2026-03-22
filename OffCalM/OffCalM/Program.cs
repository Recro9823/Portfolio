using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Principal;

namespace MyApp
{
    
    internal class Program
    {

        // Function to find the position of the first day of the year in the week
        static int FindPosition(string firstDay, string[] weekDays)
        {
            for (int i = 0; i < weekDays.Length; i++)
            {
                if (firstDay == weekDays[i])
                {
                    return i;
                }
            }
            return 0;
        }



        // Function to check if the current year is a leap year
        static bool isLeapYear()
        {
            if ((DateTime.Now.Year % 4 == 0 ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        static void Main(string[] args)
        {
 
            int counter = 1, position = 0;

            string firstDay = "Tue";  // HARDOCODED first day of the year (e.g., "Mon" for Monday, "Tue" for Tuesday, etc.)

            string[] weekDays = { "Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun" };
            int[] maxDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthTab = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            //find initial start position
            position = FindPosition(firstDay, weekDays);

            
            
            //check for leap year and adjust February days if necessary
            if (isLeapYear())
            {
                 maxDays[1] = 29; // if it's a leap year, set February to 29 days
            }
            
            //printing and filling the calendar
            for (int month = 0; month < maxDays.Length; month++)
            {
                Console.WriteLine("////////////////// " + monthTab[month] + " //////////////////");
                int[,] hexMonth = new int[6, 7];
                for (int i = 0; i < 6; i++)
                {
                    if (i == 0)                                               //first week SPECIAL CASE
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (j >= position)
                            {
                                hexMonth[i, j] = counter;
                                counter++;
                            }
                            Console.Write(hexMonth[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    else if (i < 6)                                         //other weeks
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (counter <= maxDays[month])
                            {
                                hexMonth[i, j] = counter;
                                counter++;
                                Console.Write(hexMonth[i, j] + "\t");
                            }
                            else if (counter == maxDays[month]+1)           //setting position for next month SPECIAL CASE
                            {
                                hexMonth[i, j] = 0;
                                position = j;
                                counter++;
                            }

                        }
                        Console.WriteLine();
                    }



                }
                counter = 1;       // reset day counter for next month
            }
        }
    }
}

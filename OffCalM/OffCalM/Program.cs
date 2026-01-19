using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Principal;

namespace MyApp
{
    
    internal class Program
    {
        
        static int FindPosition(string pierwszydz, string[] weekDays)
        {
            for (int i = 0; i < weekDays.Length; i++)
            {
                if (pierwszydz == weekDays[i])
                {
                    return i;
                }
            }
            return 0;
        }
        
        static void Main(string[] args)
        {
            int licznik = 1, position = 0;

            string pierwszydz = "Tue";  // HARDOCODED first day of the year (e.g., "Mon" for Monday, "Tue" for Tuesday, etc.)

            string[] weekDays = { "Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun" };
            int[] maxDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthTab = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            // find initial start position
            
            position = FindPosition(pierwszydz, weekDays);


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
                                hexMonth[i, j] = licznik;
                                licznik++;
                            }
                            Console.Write(hexMonth[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    else if (i < 6)                                         //other weeks
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (licznik <= maxDays[month])
                            {
                                hexMonth[i, j] = licznik;
                                licznik++;
                                Console.Write(hexMonth[i, j] + "\t");
                            }
                            else if (licznik == maxDays[month]+1)           //setting position for next month SPECIAL CASE
                            {
                                hexMonth[i, j] = 0;
                                position = j;
                                licznik++;
                            }

                        }
                        Console.WriteLine();
                    }



                }
                licznik = 1;       // reset day counter for next month
            }
        }
    }
}

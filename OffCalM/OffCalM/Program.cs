using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Principal;

namespace MyApp
{
    internal class Program
    {
        public void FirstWeek()
        {

        }

        static void Main(string[] args)
        {
            int licznik = 1, position = 0;

            string pierwszydz = "wt";

            int[,] hexMonth = new int[6, 7];
            string[] weekDays = { "pon", "wt", "srd", "czw", "pt", "sob", "niedz" };
            int[] maxDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthTab = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            // find initial start position
            for (int i = 0; i < weekDays.Length; i++)
            {
                if (pierwszydz == weekDays[i])
                {
                    position = i;
                }
            }



            for (int month = 0; month < maxDays.Length; month++)
            {
                Console.WriteLine("////////////////// " + monthTab[month] + " //////////////////");
                for (int i = 0; i < 6; i++)
                {
                    if (i == 0)
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
                    else if (i < 6)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            if (licznik <= maxDays[month])
                            {
                                hexMonth[i, j] = licznik;
                                licznik++;
                                Console.Write(hexMonth[i, j] + "\t");
                            }
                            else if (licznik == maxDays[month]+1)
                            {
                                hexMonth[i, j] = 0;
                                position = j;
                                licznik++;
                            }

                        }
                        Console.WriteLine();
                    }



                }
                licznik = 1;
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        hexMonth[i, j] = 0;
                    }
                }
            }
        }
    }
}

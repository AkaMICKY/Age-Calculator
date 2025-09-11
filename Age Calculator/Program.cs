using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Age_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I Calculate How Old You Are, using Your BirthDay\nSO Lets get Started");
            Console.Write("When Is Your Birthday(YEAR-MONTH-DAY)\nExample (2024-01-31) : ");
            DateTime Current_Date = DateTime.Now;
            
            

            if (DateTime.TryParse(Console.ReadLine(), out DateTime B_DAY))
            {
                TimeSpan Diff = DateTime.Now  - B_DAY;
                if (Current_Date < B_DAY)
                {
                    Console.WriteLine("Haha Nice Joke, Now Input Your Real Birthday, you werent Born In the Future"); //Prints When Inputted Year is Greater Than Current Year
                }
                else
                {
                    double Age = (double)Diff.Days / 365.25;
                    double Age_round = Math.Round(Age, 2);
                    Console.WriteLine("Would You like It Measured in\n1.Years\n2.Months\n3.Days\n4.Hours\n5.Seconds");
                    Console.Write("--Option: ");
                    string age = Console.ReadLine();
                    if (int.TryParse(age, out int AGE))
                    {
                        if (AGE == 1)
                        {
                            Console.WriteLine("You have Lived For Approximately " + Age_round + " Years");
                            PrintAgeClass(Age);
                        }
                        else if (AGE == 2)
                        {
                            double age_month = (double)Diff.Days / 30.44;
                            double age_month_round = Math.Round(age_month, 2);
                            Console.WriteLine("You have Lived For Approximately " + age_month_round + " Months");
                            PrintAgeClass(Age);
                        }
                        else if (AGE == 3)
                        {
                            double age_days = (double)Diff.Days;
                            double age_days_round = Math.Round(age_days, 2);
                            Console.WriteLine("You are " + age_days + " Days Old");
                            PrintAgeClass(Age);
                        }
                        else if (AGE == 4)
                        {
                            int age_hrs = (int)Diff.TotalHours;
                            
                            
                            Console.WriteLine("You are " + age_hrs + " Hours Old");
                            PrintAgeClass(Age);
                        }
                        else if (AGE == 5)
                        {
                            int age_sec = (int)Diff.TotalSeconds;
                            Console.WriteLine("You Have Lived for " + age_sec + " Seconds ,Damn thats Long ");
                            PrintAgeClass(Age);
                        }
                        else
                        {
                            Console.WriteLine("Option " + age + " is not an Available Option");
                        }
                    }
                    else
                    {
                        Console.WriteLine(age + " is not a Valid Option");
                    }



                }
            }
            else
            {
                Console.WriteLine("Invalid Year.");
            }



        }

        static void PrintAgeClass(double Age)
        {
            
            //Age Categories
            if (Age <= 5)
            {
                Console.Write("Hence You are a Baby/Toddler :)");
            }
            else if (Age <= 12)
            {
                Console.WriteLine("Hence You are a Child");
            }
            else if (Age <= 18)
            {
                Console.WriteLine("Hence You are a Teenager ;)");
            }
            else if (Age <= 27)
            {
                Console.WriteLine("Hence You are a Young Adult :|");
            }
            else if (Age <= 38)
            {
                Console.WriteLine("Hence You are Middle Age");
            }
            else if (Age <= 56)
            {
                Console.WriteLine("Hence You are an Elder");
            }
            else
            {
                Console.WriteLine("Hence You Are an OLD Elder :(");
            }

        }
    }
}

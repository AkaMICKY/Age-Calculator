using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Age_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I Calculate How Old You Are, using Your BirthDay\nSo Lets get Started");
            Console.Write("When Is Your Birthday(YEAR-MONTH-DAY)\nExample (2024-01-31) : ");
            DateTime Current_Date = DateTime.Now;
            string B_Day = Console.ReadLine();
            
            

            if (DateTime.TryParse(B_Day, out DateTime B_DAY))
            {

                 
                TimeSpan Diff = DateTime.Now  - B_DAY;
                if (Current_Date < B_DAY)
                {
                    Console.WriteLine("Haha Nice Joke, Now Input Your Real Birthday, you werent Born In the Future"); //Prints When Inputted Year is Greater Than Current Year
                }
                else
                {
                    
                    
                        double Age = (double)Diff.Days / 365.25;
                    int Age_Whole = (int)Diff.Days / 365;
                        double Age_round = Math.Round(Age, 2);
                        Console.WriteLine("Would You like It Measured in\n1.Years\n2.Months\n3.Days\n4.Hours\n5.Seconds");
                        Console.Write("--Option: ");
                        string option = Console.ReadLine();
                        if (int.TryParse(option, out int OPTION))
                        {
                                switch (OPTION)
                        {
                            case 1:
                                
                                Console.WriteLine("You are " + Age_Whole + " Years Old Or " + Age_round + " To be Exact");
                                PrintAgeClass(Age);
                                break;
                            case 2:
                                double Age_in_Months = (double)Diff.Days / 30.44;
                                double Age_in_Months_round = Math.Round(Age_in_Months, 2);
                                Console.WriteLine("You are " + Age_in_Months_round + " Months Old");
                                PrintAgeClass(Age);
                                break;
                            case 3:
                                Console.WriteLine("You are " + Diff.Days + " Days Old");
                                PrintAgeClass(Age);
                                break;
                            case 4:
                                double Age_in_Hours = Diff.TotalHours;
                                double Age_in_Hours_round = Math.Round(Age_in_Hours, 2);
                                Console.WriteLine("You are " + Age_in_Hours_round + " Hours Old");
                                PrintAgeClass(Age);
                                break;
                            case 5:
                                double Age_in_Seconds = Diff.TotalSeconds;
                                double Age_in_Seconds_round = Math.Round(Age_in_Seconds, 2);
                                Console.WriteLine("You are " + Age_in_Seconds_round + " Seconds Old");
                                PrintAgeClass(Age);
                                break;
                            default:
                                Console.WriteLine(option + " is not a Valid Option");
                                break;
                        }   
                            
                        }
                        else
                        {
                            Console.WriteLine(option + " is not a Valid Option");
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
            if (Age < 1)
            {
                Console.WriteLine("Hemce You are an Infant,but wait if you are an Infant How Could Use This App?");
            }

            else if (Age <= 5)
            {
                Console.WriteLine("Hence You are a Baby/Toddler :)");
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
            double Age_R = Math.Round(Age);
            if (Age_R < Age)
            {
                int Next_BirthDay = (int)(Age_R + 1);
                double Diff_Age = (double)(Next_BirthDay - Age);
                double Diff_Age_Days = Diff_Age * 365.25;
                double Diff_Age_Months = Diff_Age * 12;
                double Diff_Age_Months_Round = Math.Round(Diff_Age_Months, 1);
                Console.WriteLine("You have " + Diff_Age_Days + " Days Till Your Next Birthday or " + Diff_Age_Months_Round + " Months!");
            }
            else
            {
                double diff = (double)(Age_R - Age);
                double diff_days = diff * 365.25;
                double diff_months = diff * 12;
                double diff_months_round = Math.Round(diff_months, 1);
                Console.WriteLine("You have " + diff_days + " Days Till Your Next Birthday or " + diff_months_round + " Months!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I Calculate How Old You Are, using Your BirthDay\nSO Lets get Started");
            Console.Write("When Is Your BirthDay(Year)? : ");
            string B_Day = Console.ReadLine();
            if (int.TryParse(B_Day, out int B_DAY))
            {
                int Current_Year = DateTime.Now.Year;
                //Prevents Future Year as Input
                if (Current_Year < B_DAY)
                {
                    Console.WriteLine("Haha Nice Joke, Now Input Your Real Birthday, you werent Born In the Future"); //Prints When Inputted Year is Greater Than Current Year
                }
                else
                {
                    int Age = Current_Year - B_DAY; //Subtracts Users Input(B_DAY) from Current Year
                    Console.WriteLine("Would You like It Measured in\n1.Years\n2.Months\n3.Days\n4.Hours\n5.Seconds");
                    Console.Write("--Option: ");
                    string age = Console.ReadLine();
                    if (int.TryParse(age, out int AGE))
                    {
                        if (AGE == 1)
                        {
                            Console.WriteLine("You are " + Age + " years old");
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
                        } else if (AGE == 2)
                        {
                            int age_month = Age * 12;
                            Console.WriteLine("You are " + age_month + " months Old");
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
                        } else if (AGE == 3)
                        {
                            int age_days = Age * 365;
                            Console.WriteLine("You are " + age_days + " days old");
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
                        } else if (AGE == 4)
                        {
                            int age_hrs = Age * 8760;
                            Console.WriteLine("You are " + age_hrs + " Hours Old");
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
                        } else if (AGE == 5)
                        {
                            int age_sec = Age * 8760 * 60 * 60;
                            Console.WriteLine("You Have Lived for " + age_sec + " Seconds ,Damn thats Long " );
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
                        } else
                        {
                            Console.WriteLine("Option " + age + " is not an Available Option");
                        }
                    } else
                    {
                        Console.WriteLine(age + " is not a Valid Option");
                    }
                        

                    
                } 
            } else
            {
                Console.WriteLine("Invalid Year.");
            }
            
            
            
        }
    }
}

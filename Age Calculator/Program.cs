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
                    Console.WriteLine("Sorry Input A Correct Year, You Werent Born in the Future"); //Prints When Inputted Year is Greater Than Current Year
                }
                else
                {
                    int Age = Current_Year - B_DAY; //Subtracts Users Input(B_DAY) from Current Year
                    Console.WriteLine("You Are " + Age + " Years Old");
                    //Age Categories
                    if (Age <= 5)
                    {
                        Console.Write(" Hence You are a Baby/Toddler :)");
                    }
                    else if (Age <= 12)
                    {
                        Console.WriteLine(" Hence You are a Child");
                    }
                    else if (Age <= 18)
                    {
                        Console.WriteLine(" Hence You are a Teenager ;)");
                    }
                    else if (Age <= 27)
                    {
                        Console.WriteLine(" Hence You are a Young Adult :|");
                    }
                    else if (Age <= 38)
                    {
                        Console.WriteLine(" Hence You are Middle Age");
                    }
                    else if (Age <= 56)
                    {
                        Console.WriteLine(" Hence You are an Elder");
                    }
                    else
                    {
                        Console.WriteLine(" Hence You Are an OLD Elder :(");
                    }
                } 
            } else
            {
                Console.WriteLine("Invalid Year.");
            }
            
            
            
        }
    }
}

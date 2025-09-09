using System;
using System.Collections.Generic;
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
            int B_DAY = Convert.ToInt32(B_Day); //Converts the Year(DOB) Input from String To Integer
            int Age = DateTime.Now.Year - B_DAY; //Subtracts Users Input(B_DAY) from Current Year
            Console.WriteLine("You Are " + Age + " Years Old");
            if (Age < 5)
            {
                Console.Write(" Hence You are a Baby/Toddler :)");
            } else if (Age > 5 && Age < 12)
            {
                Console.WriteLine(" Hence You are a Child");
            } else if (Age > 12 && Age < 18)
            {
                Console.WriteLine(" Hence You are a Teenager ;)");
            } else if (Age > 18 && Age < 27)
            {
                Console.WriteLine(" Hence You are a Young Adult :|");
            }
            else if (Age > 27 && Age < 38)
            {
                Console.WriteLine(" Hence You are Middle Age");
            }
            else if (Age > 38 && Age < 56)
            {
                Console.WriteLine(" Hence You are an Elder");
            } else
            {
                Console.WriteLine(" Hence You Are an OLD Elder :(");
            }
        }
    }
}

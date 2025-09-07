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
        }
    }
}

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
            int B_DAY = int.Parse(B_Day);
            int Age = DateTime.Now.Year - B_DAY;
            Console.WriteLine("You Are " + Age + " Years Old");
        }
    }
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace CarpetCleaning
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enjoy with our offers for this month \n");
            //int priceOfSmallCarpt = 15;
            ///int priceOfbigCarpet = 25;
            Console.WriteLine("Enter Your number of small Carpet \n");
            int SmallNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your number of Big Carpet\n");
            int BigNum = Convert.ToInt32(Console.ReadLine());
            int SmallCarpet = SmallNum * 25;
            int BigCarpet = BigNum * 35;
            int Sum = SmallCarpet + BigCarpet;
            double Tax = Sum * .06;
            double Total = Tax + Sum;
            Console.WriteLine(" Your bill is " + Sum + " and the Tax is 6% the Total is\n ");
            Console.WriteLine("========================");
            Console.WriteLine(Total);
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }

}



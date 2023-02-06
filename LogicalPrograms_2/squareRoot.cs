using System;
namespace LogicalPrograms_2
{
	public class squareRoot
	{
		public static void squareRootDisplay()
		{
            //-----------------UC5_Square root of number --------------------------------//
            Console.WriteLine("Enter the number:");
            double Number = Convert.ToInt32(Console.ReadLine());
            if(Number<0)
            {
                Console.WriteLine("Enter the number should greater than zero");
            }
            else
            {
                double sqrt = Math.Sqrt(Number);
                Console.WriteLine("The square root of enetred number is {0}", sqrt);
            } 
        }
    }
}


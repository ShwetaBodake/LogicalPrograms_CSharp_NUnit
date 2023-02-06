using System;
namespace LogicalPrograms_2
{
	public class monthlyPayment
	{
		public static void monthlyPaymentCalculate()
		{
             //-----------------UC4_Monthly payment calculate ----------------------//
                     Console.WriteLine("Enter the Loan amount P:-");
                     double P = Convert.ToInt32(Console.ReadLine());

                     Console.WriteLine("Enter the Number of years Y:-");
                     double Y = Convert.ToInt32(Console.ReadLine());

                     Console.WriteLine("Enter the Interest Rate I:-");
                     double I = Convert.ToInt32(Console.ReadLine());

                     double numberOfMonths_n = Y * 12;
                     double monthlyInterest_r = Y / (12 * 100);
                     double MonthlyPayment = (P * monthlyInterest_r) / (1 - Math.Pow((1 + monthlyInterest_r), -numberOfMonths_n));

                     Console.WriteLine("Monthly Payment of {0} loan amount of {1} percent interest in {2} years is {3}", P, I, Y, MonthlyPayment);
         
        }
    }
}


using System;
namespace LogicalPrograms_2
{
	public class temperaturConversion
	{
		public static void  temperaturConversionDisplay()
		{
            //---------------UC3_TemperatureConversion---------------------------------//
                     Console.WriteLine("Welcome temprature Conversion");
                     Console.WriteLine("Enter the Temprature in celsius to convert into Fahrenheit:");
                     double Celsius = Convert.ToInt32(Console.ReadLine());
                     double Fahrenheit= ((Celsius * 9) / 5) + 32;
                     Console.WriteLine("The given temprature {0} celsius after converting is {1} Feranides", Celsius, Fahrenheit);

                     Console.WriteLine("Enter the Temprature in Fahrenheit to convert into Fahrenheit:");
                     double Fahrenheit2 = Convert.ToInt32(Console.ReadLine());
                     double Celsius2 = (Fahrenheit2-32) * 5 / 9;
                     Console.WriteLine("The given temprature {0} Fahrenheit: after converting is {1} Celsius2:", Fahrenheit2, Celsius2);
         
        }
    }
}


namespace LogicalPrograms_2
{
class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs of Nunit ");
            Console.WriteLine("Enter the option to choose the program 1.Vending Machine \n2.DayOfWeek" +
                " \n3.TemperaturConversion \n4.Monthly Payment");
            
                
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Vendingmachine.MinimumNotesDisplay();
                    break;
                case 2:
                    DayOfWeek.dayofweekDisplay();
                    break;
                case 3:
                    temperaturConversion.temperaturConversionDisplay();
                    break;
                case 4:
                    monthlyPayment.monthlyPaymentCalculate();
                    break;
                default:
                    Console.WriteLine("Enter option wihin given option");
                    break;
            }
        }
    }
}


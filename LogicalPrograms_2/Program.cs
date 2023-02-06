namespace LogicalPrograms_2
{
class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs of Nunit ");
            Console.WriteLine("Enter the option to choose the program 1.Vending Machine \n2.DayOfWeek");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Vendingmachine.MinimumNotesDisplay();
                    break;
                case 2:
                    DayOfWeek.dayofweekDisplay();
                    break;
                default:
                    Console.WriteLine("Enter option wihin given option");
                    break;
            }
        }
    }
}


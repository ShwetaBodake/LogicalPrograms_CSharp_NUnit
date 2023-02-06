using System;
namespace LogicalPrograms_2
{
	public class DayOfWeek
    {
        public static int d, m, y;

        public static void dayofweekDisplay()
		{
            //----------------------UC2_Day of entered date with date,month ,year------------------------//
           // public int d, m, y;
                Console.WriteLine("Enter the date");
            Console.WriteLine("Enter the day");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The given date is {0}/{1}/{2}", d, m, y);
            int y0 = y - (14 - m) / 12;
                                    int x = y0 + y0 / 4 - 0 / 100 + y0 / 400;
                                    int m0 = m + 12 * ((14 - m) / 12) - 2;
                                    int d0 = (d + x + (31 * m0) / 12) % 7;
                                    switch (d0)
                                    {
                                        case 0:
                                            Console.WriteLine("The day is Monday");
                                            break;
                                        case 1:
                                            Console.WriteLine("The day is Tuesaday");
                                            break;
                                        case 2:
                                            Console.WriteLine("The day is Wednesday");
                                            break;
                                        case 3:
                                            Console.WriteLine("The day is Thursday");
                                            break;
                                        case 4:
                                            Console.WriteLine("The day is Friday");
                                            break;
                                        case 5:
                                            Console.WriteLine("The day is Saturday");
                                            break;
                                        case 6:
                                            Console.WriteLine("The day is Sunday");
                                            break;
                                        default:
                                            break;
                                    }
        }
    }
}


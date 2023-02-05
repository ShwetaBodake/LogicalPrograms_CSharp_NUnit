namespace LogicalPrograms_2
{
class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs of Nunit ");
            Console.WriteLine("Welcome to Vendor Machine");
            //———Vending machine——————————//
            int[] notes = { 1, 2, 5, 10, 50, 100, 500, 1000 };
            Console.WriteLine("Enter the note for change:");
            int Rs = Convert.ToInt32(Console.ReadLine());
            int count_note = 0;

            int[] count = new int[8];
            while (Rs != 0)
            {
                int Arrlength = notes.Length;
                for (int i = Arrlength - 1; i >= 0; i--)
                {
                    if (notes[i] <= Rs)
                    {
                        count[i] = count[i] + Rs / notes[i];
                        Rs = Rs % notes[i];
                    }
                }
                for (int i = 7; i >= 0; i--)
                {
                    if (count[i] != 0)
                    {
                        Console.WriteLine("notes of {0} is of count {1}", notes[i], count[i]);
                    }
                }
                //--------------number of notes are counted-------------------------------------------//
                for (int i = 0; i < 8; i++)
                {
                    count_note += count[i];
                }
                Console.WriteLine("Total count of note is:{0}", count_note);
            }
        }
    }
}


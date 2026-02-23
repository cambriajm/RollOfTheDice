namespace RollOfTheDice
//Cambria Morgan
//RCET 2265
//Spring 2026
//RollOfTheDice
//https://github.com/cambriajm/RollOfTheDice.git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); //makes a random number variable
            int[] dice = new int[13];
            string format = "|"; // to space out the numbers of rolls 
            Console.WriteLine("Roll of the dice, rolls a dice 1000 times,"
                + "and will show how many rolls per number.");
            for (int i = 0; i < 1000; i++) // array to roll 1000 times 
            {
                int n = random.Next(2, 12 + 1);
                dice[n]++;
            }

            for (int i = 2; i <= 12; i++) // to show numbers 2-12 
            {
                Console.Write($"{i}".PadRight(5) + format);
            }
            Console.WriteLine();

            for(int i = 2; i <= 12; i++) // to list how many times 
            {
                Console.Write($"{dice[i]}".PadRight(5) + format);
            }
            Console.WriteLine();

            //pause 
            Console.Read();
        }
    }
}



namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalRolls = 100000;
            Random rand = new Random();
            int[] counts = new int[6];

            for (int i = 0; i < totalRolls; i++)
            {
                int roll = rand.Next(1, 7);
                counts[roll - 1]++;
            }

            Console.WriteLine("Result:");
            for (int i = 0; i < 6; i++)
            {
                double probability = (double)counts[i] / totalRolls * 100;
                Console.WriteLine($"Chislo {i + 1}: {probability:F2}%");
            }

        }
    }
}

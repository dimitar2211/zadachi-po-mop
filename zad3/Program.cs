namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi 9 chisla (3 x 3):");

            var numbers = Console.ReadLine()
                                 .Split(' ')
                                 .Select(double.Parse)
                                 .ToArray();

            if (numbers.Length != 9)
            {
                Console.WriteLine("Vuvedi 9 chisla.");
                return;
            }

            double a = numbers[0], b = numbers[1], c = numbers[2];
            double d = numbers[3], e = numbers[4], f = numbers[5];
            double g = numbers[6], h = numbers[7], i = numbers[8];

            double det = a * (e * i - f * h)
                       - b * (d * i - f * g)
                       + c * (d * h - e * g);

            Console.WriteLine($"Result: {det}");
        }
    }
}

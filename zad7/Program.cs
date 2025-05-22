namespace zad7
{
    internal class Program
    {
        static long Factorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++) result *= i;
            return result;
        }

        static void Main()
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k: ");
            int k = int.Parse(Console.ReadLine());

            if (n < 0 || k < 0 || k > n)
            {
                Console.WriteLine("Invalid command...");
                return;
            }

            long permutations = Factorial(n) / Factorial(n - k);
            long combinations = Factorial(n) / (Factorial(k) * Factorial(n - k));
            long variations = permutations; 

            Console.WriteLine($"Prmutacii: {permutations}");
            Console.WriteLine($"Combinacii: {combinations}");
            Console.WriteLine($"Variacii: {variations}");
        }

    }
}

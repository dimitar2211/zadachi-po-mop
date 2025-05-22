namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi coef (naprimer 1 -3 2): ");
            var coef = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            if (coef.Length == 3) 
            {
                double a = coef[0], b = coef[1], c = coef[2];
                double D = b * b - 4 * a * c;

                if (D > 0)
                    Console.WriteLine($"Dva korena: {(-b + Math.Sqrt(D)) / (2 * a)}, {(-b - Math.Sqrt(D)) / (2 * a)}");
                else if (D == 0)
                    Console.WriteLine($"Edin koren: {-b / (2 * a)}");
                else
                    Console.WriteLine("Nqma koreni.");
            }
            else if (coef.Length == 2) 
            {
                double a = coef[0], b = coef[1];
                if (a != 0)
                    Console.WriteLine($"Koren: {-b / a}");
                else
                    Console.WriteLine(b == 0 ? "Mnogo resheniq." : "Nqma reshenie.");
            }
            else
                Console.WriteLine("Trqbva da e purva ili vtora stepen.");
        }
    }
}

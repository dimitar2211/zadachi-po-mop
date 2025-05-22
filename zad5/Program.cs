namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Broq na vektorite: ");
            int n = int.Parse(Console.ReadLine());

            double minLength = double.MaxValue;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Vuvedi {i + 1}-viq 3D vektor (x y z): ");
                var vector = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

                double length = Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1] + vector[2] * vector[2]);

                if (length < minLength)
                    minLength = length;
            }

            Console.WriteLine($"Duljinata na nai kusiq e: {minLength:F2}");
        }
    }
}

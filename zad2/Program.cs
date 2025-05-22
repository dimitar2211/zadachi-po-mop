namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Chisla: ");
            var numbers = Console.ReadLine()
                                 .Split(' ')
                                 .Select(int.Parse)
                                 .OrderBy(n => n)
                                 .ToArray();

            double average = numbers.Average();

            double median = numbers.Length % 2 == 0
                ? (numbers[numbers.Length / 2 - 1] + numbers[numbers.Length / 2]) / 2.0
                : numbers[numbers.Length / 2];

            var mode = numbers.GroupBy(n => n)
                              .OrderByDescending(g => g.Count())
                              .ThenBy(n => n.Key)
                              .First().Key;

            Console.WriteLine($"Sredno: {average:F2}");
            Console.WriteLine($"Mediana: {median}");
            Console.WriteLine($"Moda: {mode}");
        }
    }
}

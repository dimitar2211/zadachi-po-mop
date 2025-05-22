namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1vo mnojestvo:");
            var set1 = new HashSet<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            Console.WriteLine("2ro mnojestvo:");
            var set2 = new HashSet<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            var intersection = new HashSet<int>(set1);
            intersection.IntersectWith(set2);

            var union = new HashSet<int>(set1);
            union.UnionWith(set2);

            var difference = new HashSet<int>(set1);
            difference.ExceptWith(set2);

            var symmetricDifference = new HashSet<int>(set1);
            symmetricDifference.SymmetricExceptWith(set2);

            Console.WriteLine($"Sechenie: {string.Join(" ", intersection)}");
            Console.WriteLine($"Obedinenie: {string.Join(" ", union)}");
            Console.WriteLine($"Razlika (set1 - set2): {string.Join(" ", difference)}");
            Console.WriteLine($"Symetrichna razlika: {string.Join(" ", symmetricDifference)}");
        }
    }
}

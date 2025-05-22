namespace zadachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - 10 -> ?");
            Console.WriteLine("2 - ? -> 10");
            Console.Write("1 or 2: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.Write("10no chislo: ");
                int decimalNumber = int.Parse(Console.ReadLine());

                Console.Write("broina sis (2, 8 or 16): ");
                int targetBase = int.Parse(Console.ReadLine());

                string result = Convert.ToString(decimalNumber, targetBase);
                Console.WriteLine("Result: " + result.ToUpper());
            }
            else if (option == "2")
            {
                Console.Write("chislo: ");
                string number = Console.ReadLine();

                Console.Write("ot koq broina sis e (2, 8 or 16): ");
                int sourceBase = int.Parse(Console.ReadLine());

                int decimalResult = Convert.ToInt32(number, sourceBase);
                Console.WriteLine("V desetichna: " + decimalResult);
            }
            else
            {
                Console.WriteLine("Invalid command...");
            }
        }
    }
}

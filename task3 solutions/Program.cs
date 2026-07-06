namespace task3_solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1 

            Console.Write("Enter the first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int y = int.Parse(Console.ReadLine());
            int sub = x - y;
            Console.WriteLine("The positive difference of seconde from first is: " + Math.Abs(sub));

            //--------------------------------------------------------

        }
    }
}

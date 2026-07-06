namespace task3_solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             // task 1 

             Console.Write("Enter the first number: ");
             int x = int.Parse(Console.ReadLine());
             Console.Write("Enter the second number: ");
             int y = int.Parse(Console.ReadLine());
             int sub = x - y;
             Console.WriteLine("The positive difference of seconde from first is: " + Math.Abs(sub));
            */
            //--------------------------------------------------------

            /*
            // task 2 

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The square of the number is: " + Math.Pow(num,2)+ " and the square root of the number is: "+ Math.Sqrt(num));
            */


            //--------------------------------------------------------

            /*
            // task 3

            Console.Write("pls entre your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("the name in upper case is:"+ name.ToUpper() + ", the name in lower case is: " + name.ToLower() + ", the number of laters on the name is: " + name.Length );
            */

            //--------------------------------------------------------

            // task 4 

            /*
            Console.Write("Enter the number of trial days: ");
            int trialDays = int.Parse(Console.ReadLine());

            DateTime startDate = DateTime.Today;
            DateTime endDate = startDate.AddDays(trialDays);

            Console.WriteLine("Trial end date: " + endDate.ToString("yyyy-MM-dd"));

            */

            //--------------------------------------------------------

            /*
            //  task 5

            Console.Write("Enter your raw exam score: ");
            double rawScore = double.Parse(Console.ReadLine());

            double roundedScore = Math.Round(rawScore, 0);

            if (roundedScore >= 60)
            {
                Console.WriteLine("Rounded Score: " + roundedScore);
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Rounded Score: " + roundedScore);
                Console.WriteLine("Result: Fail");
            }

            */

            //--------------------------------------------------------

        }
    }
}

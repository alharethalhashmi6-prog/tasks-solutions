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

            /*
            // task 6

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            bool isLongEnough = password.Length >= 8;
            bool containsForbiddenWord = password.ToLower().Contains("password");

            if (isLongEnough && !containsForbiddenWord)
            {
                Console.WriteLine("Strong password.");
            }
            else
            {
                Console.WriteLine("Weak password. Reason:");
                if (!isLongEnough)
                    Console.WriteLine("- Must be at least 8 characters long.");
                if (containsForbiddenWord)
                    Console.WriteLine("- Must not contain the word 'password'.");
            }
            */

            //--------------------------------------------------------

            /*
            // task 7

            Console.Write("Enter the name (first time): ");
            string name1 = Console.ReadLine();

            Console.Write("Enter the name (second time): ");
            string name2 = Console.ReadLine();

            string cleanName1 = name1.Trim().ToUpper();
            string cleanName2 = name2.Trim().ToUpper();

            if (cleanName1 == cleanName2)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }
            */

            //--------------------------------------------------------

            /*
            // task 8

            try
            {
                Console.Write("Enter membership start date (yyyy-MM-dd): ");
                DateTime startDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter number of valid membership days: ");
                int validDays = int.Parse(Console.ReadLine());

                DateTime expiryDate = startDate.AddDays(validDays);

                if (expiryDate >= DateTime.Today)
                {
                    Console.WriteLine("Status: Active");
                }
                else
                {
                    Console.WriteLine("Status: Expired");
                }

                Console.WriteLine("Expiry date: " + expiryDate.ToString("yyyy-MM-dd"));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input: " + ex.Message);
            }
            */

            //--------------------------------------------------------
        }
    }
}

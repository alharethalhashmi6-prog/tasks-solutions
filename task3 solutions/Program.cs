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

            /*
            // task 9

            Console.Write("Enter a decimal number: ");
            double number = double.Parse(Console.ReadLine());

            double nearest = Math.Round(number, 0);
            double roundedUp = Math.Ceiling(number);
            double roundedDown = Math.Floor(number);

            Console.WriteLine("Nearest whole number: " + nearest);
            Console.WriteLine("Always rounded up (Ceiling): " + roundedUp);
            Console.WriteLine("Always rounded down (Floor): " + roundedDown);

            */

            //--------------------------------------------------------

            /*
            // task 10

            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.Write("Enter the word to search for: ");
            string word = Console.ReadLine();

            int firstPosition = sentence.IndexOf(word);
            int lastPosition = sentence.LastIndexOf(word);

            if (firstPosition == -1)
            {
                Console.WriteLine("Word not found in the sentence.");
            }
            else
            {
                Console.WriteLine("First occurrence at index: " + firstPosition);
                Console.WriteLine("Last occurrence at index: " + lastPosition);
            }
            */

            //--------------------------------------------------------

            /*
            // task 11

            Random random = new Random();
            int otp = random.Next(1000, 10000);

            Console.WriteLine("Your OTP code is: " + otp);

            int attempts = 0;
            bool verified = false;

            while (attempts < 3 && !verified)
            {
                try
                {
                    Console.Write("Enter the OTP code: ");
                    int enteredCode = int.Parse(Console.ReadLine());

                    if (enteredCode == otp)
                    {
                        verified = true;
                        Console.WriteLine("Verified");
                    }
                    else
                    {
                        attempts++;
                        Console.WriteLine("Incorrect code. Attempts remaining: " + (3 - attempts));
                    }
                }
                catch (Exception ex)
                {
                    attempts++;
                    Console.WriteLine("Invalid input, please enter numbers only. Attempts remaining: " + (3 - attempts));
                }
            }

            if (!verified)
            {
                Console.WriteLine("Verification Failed");
            }
            */

            //--------------------------------------------------------

        }
    }
}

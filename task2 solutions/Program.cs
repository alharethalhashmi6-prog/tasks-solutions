namespace task2_solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            // task 1 

            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(i);
                if (i == 1)
                {
                    Console.WriteLine("Liftoff!");
                }

            }
            */

            //----------------------------------------------------------

            /*
            // task 2 

            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i<=n; i++)
            {
                sum += i;

            }
            Console.WriteLine("The sum of the fctorial of "+n+" is: "+sum);
            */

            //----------------------------------------------------------

            /*
            // task 3

            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int multi = 1;
            for (int i = 1; i <= 10; i++)
            {
                multi = n * i;
                Console.WriteLine(n + " x " + i + " = " + multi);
            }
            */

            //----------------------------------------------------------

            /*
            // task 4

            Console.Write("pls entre your password: ");
            String p = Console.ReadLine();
            string password = "Spark2026";
            while ( p != password)
            {
                Console.Write("Incorrect password, pls try again: ");
                p = Console.ReadLine();
            }

            Console.WriteLine("Correct password, welcome!");
            */


            //----------------------------------------------------------

            /*
            // task 5

            Console.Write("Pls entre the secret code: ");
            int code = Convert.ToInt32(Console.ReadLine());
            int sc = 50;
            int i = 1;
            do
            {
                if (code > sc)
                {
                    Console.Write("Too high, pls try again: ");
                    code = Convert.ToInt32(Console.ReadLine());
                    i++;
                }
                else if (code < sc)
                {
                    Console.Write("Too low, pls try again: ");
                    code = Convert.ToInt32(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Excellent :) ");
                }
            } while (code != sc);

            Console.WriteLine("Correct code, welcome! ");
            Console.WriteLine("You guessed the code in " + i + " attempts.");
            */

            //----------------------------------------------------------
        }
    }
}

using System.Linq.Expressions;

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

            /*
            // task 6 

            Console.Write("Pls entre the first number: ");
            double n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pls entre the second number: ");
            double n2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                double dev = n1 / n2;
                Console.WriteLine("the result of " + n1 + " / " + n2 + " = " + dev);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }*/

            //----------------------------------------------------------



            // task 7

            /*
            bool exit = true;

            while (exit)
            {
                try
                {
                    Console.Write("Pls entre a number: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Hello");
                            break;
                        case 2:
                            Console.WriteLine("good morning");
                            break;
                        case 3:
                            Console.WriteLine("Exit");
                            exit = false;
                            break;
                        default:
                            Console.WriteLine("You entered a number other than 1, 2, or 3.");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("error");
                }
            }
            */

            //----------------------------------------------------------

            /*

            // task 8

            Console.Write("Pls entre a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i<= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
               
            }
            Console.WriteLine("The sum of even numbers btw 1 and "+n+" is: "+ sum);
            */

            //----------------------------------------------------------


        }
    }
}

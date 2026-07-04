using Microsoft.VisualBasic.FileIO;
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

            /*
            // task 9

            Console.Write("Pls entre a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int x = 20;
            do
            {
                try
                {
                    if (n <= 0)
                    {
                        Console.Write("The number must be positive and grater than 0. Please try again: ");
                        n = Convert.ToInt32(Console.ReadLine());
                    }

                    else if (n!= x)
                    {
                        Console.Write("The number is not valid. Please try again: ");
                        n = Convert.ToInt32(Console.ReadLine());
                    }

                    else 
                    {
                        Console.WriteLine("Excellent");

                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            
            } while (n != x);

            Console.WriteLine("Excellent you chosed the valid number");

            for (int i =1; i<= x; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum of numbers btw 1 and " + x + " is: " + sum);


            */

            //----------------------------------------------------------


            // task 10

            /*

            Console.Write("Wellcome, Pls entre your password: ");
            int password = Convert.ToInt32(Console.ReadLine());
            int code = 1221;
            int t = 1;
            int balance = 100;
            int option = 0;
            do
            {
                try
                {
                    if (t >= 3)
                    {
                        Console.WriteLine("Card Blocked");
                        break;
                    }
                    else if (password != code)
                    {
                        Console.Write("Incorrect password, pls try again: ");
                        password = Convert.ToInt32(Console.ReadLine());
                        t++;
                    }
                    else
                    {
                        Console.WriteLine("Correct password, welcome!");
                        Console.WriteLine("Your balance is: " + balance);
                        while (true && (option != 4))
                        {
                            Console.WriteLine("1. Deposit");
                            Console.WriteLine("2. Withdraw");
                            Console.WriteLine("3. Check Balance");
                            Console.WriteLine("4. Exit");
                            Console.Write("Pls entre an option: ");
                            option = Convert.ToInt32(Console.ReadLine());

                            switch (option)
                            {
                                case 1:
                                   
                                        Console.Write("Pls entre the amount to deposit: ");
                                        int depositAmount = Convert.ToInt32(Console.ReadLine());
                                    try
                                    {
                                        if (depositAmount <= 0)
                                        {
                                            Console.WriteLine("Deposit amount must be positive.");
                                        }
                                        else
                                        {
                                            balance += depositAmount;
                                            Console.WriteLine("Deposit successful. New balance: " + balance);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("An error occurred: " + ex.Message);
                                    }
                                    break;

                                case 2:
                                    
                                        Console.Write("Pls entre the amount to withdraw: ");
                                        int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                                    try
                                    {
                                        if (withdrawAmount <= 0)
                                        {
                                            Console.WriteLine("Withdraw amount must be positive.");
                                        }
                                        else if (withdrawAmount > balance)
                                        {
                                            Console.WriteLine("Insufficient balance.");
                                        }
                                        else
                                        {
                                            balance -= withdrawAmount;
                                            Console.WriteLine("Withdraw successful. New balance: " + balance);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("An error occurred: " + ex.Message);
                                    }
                                    break;

                                case 3:
                                    Console.WriteLine("Your current balance is: " + balance);
                                    break;
                                case 4:
                                    Console.WriteLine("Exiting. Thank you for using our service.");
                                    break;
                                default:
                                    Console.WriteLine("Invalid option. Please try again.");
                                    break;
                            }


                        }
                    }

                }

                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);

                }
            } while (password != code && t <= 3 && option != 4);
            Console.WriteLine("Thank you for using our service. Goodbye!");

            */
        }
    }
}

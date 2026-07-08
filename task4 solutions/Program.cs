namespace task4_solutions
{
    internal class Program
    {
        /*
        // task 1 

        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome, " + name + "!");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            PrintWelcome(userName);
        }
        */


        //----------------------------------------------

        /*
        // task 2

         static int Square(int number)
         {
             return number * number;
         }
         static void Main(string[] args)
         {
             Console.Write("Enter a number: ");
             int num = int.Parse(Console.ReadLine());

             int result = Square(num);
             Console.WriteLine("The square is: " + result);
         }
        */

        //----------------------------------------------

        /*
        // task 3
        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in Celsius: ");
            double tempC = double.Parse(Console.ReadLine());
            double tempF = CelsiusToFahrenheit(tempC);
            Console.WriteLine("Temperature in Fahrenheit: " + tempF);
        }
        */

        //----------------------------------------------

        /*
        // task 4

        static void DisplayMenu()
        {
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }
        static void Main(string[] args)
        {
            DisplayMenu();
        }
        */

        //----------------------------------------------

        /*
        // task 5
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            bool result = IsEven(num);

            if (result)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
        */

        //----------------------------------------------
        /*
        // task 6

        static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());

            double area = CalculateArea(length, width);
            double perimeter = CalculatePerimeter(length, width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
        }
        */

        //----------------------------------------------

        /*
        // task 7
        static string GetGradeLetter(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter your score: ");
            int score = int.Parse(Console.ReadLine());

            string grade = GetGradeLetter(score);
            Console.WriteLine("Your grade is: " + grade);
        }
        */

        //----------------------------------------------

        /*
        // task 8

        static void Countdown(int start)
        {
            for (int i = start; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a starting number: ");
            int startNum = int.Parse(Console.ReadLine());

            Countdown(startNum);
        }
        */

        //----------------------------------------------
        /*
        // task 9
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        static void Main(string[] args)
        {
            int result1 = Multiply(4, 5);
            Console.WriteLine("Multiply(int, int): " + result1);

            double result2 = Multiply(2.5, 4.0);
            Console.WriteLine("Multiply(double, double): " + result2);

            int result3 = Multiply(2, 3, 4);
            Console.WriteLine("Multiply(int, int, int): " + result3);
        }
        */

        //----------------------------------------------

        /*
        // task 10

        static double CalculateArea(double side)
        {
            return side * side;
        }

        static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        static void Main(string[] args)
        {
            Console.Write("Which shape? (square/rectangle): ");
            string shape = Console.ReadLine().ToLower();

            if (shape == "square")
            {
                Console.Write("Enter the side length: ");
                double side = double.Parse(Console.ReadLine());

                double area = CalculateArea(side);
                Console.WriteLine("Square area: " + area);
            }
            else if (shape == "rectangle")
            {
                Console.Write("Enter the length: ");
                double length = double.Parse(Console.ReadLine());

                Console.Write("Enter the width: ");
                double width = double.Parse(Console.ReadLine());

                double area = CalculateArea(length, width);
                Console.WriteLine("Rectangle area: " + area);
            }
            else
            {
                Console.WriteLine("Invalid shape choice.");
            }
        }
        */

        //----------------------------------------------

        /*
        // task 11
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double MultiplyNumbers(double a, double b)
        {
            return a * b;
        }

        static double DivideNumbers(double a, double b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }
                return a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return 0;
            }
        }

        static void DisplayResult(string operation, double result)
        {
            Console.WriteLine("Operation: " + operation);
            Console.WriteLine("Result: " + result);
            Console.WriteLine("------------------------");
        }

        static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1) Add");
                Console.WriteLine("2) Subtract");
                Console.WriteLine("3) Multiply");
                Console.WriteLine("4) Divide");
                Console.WriteLine("5) Exit");
                Console.Write("Your choice: ");
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    exit = true;
                    Console.WriteLine("Goodbye!");
                    continue;
                }

                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());

                switch (choice)
                {
                    case "1":
                        DisplayResult("Addition", Add(num1, num2));
                        break;
                    case "2":
                        DisplayResult("Subtraction", Subtract(num1, num2));
                        break;
                    case "3":
                        DisplayResult("Multiplication", MultiplyNumbers(num1, num2));
                        break;
                    case "4":
                        DisplayResult("Division", DivideNumbers(num1, num2));
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
        */

        //----------------------------------------------

        /*
        // task 12
        static double CalculateAverage(double score1, double score2, double score3)
        {
            return (score1 + score2 + score3) / 3;
        }

        static string GetGradeLetter(double average)
        {
            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80)
            {
                return "B";
            }
            else if (average >= 70)
            {
                return "C";
            }
            else if (average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        static void PrintReportCard(string studentName, double average, string gradeLetter)
        {
            Console.WriteLine("======================");
            Console.WriteLine("      Report Card      ");
            Console.WriteLine("======================");
            Console.WriteLine("Student: " + studentName);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Grade: " + gradeLetter);
            Console.WriteLine("======================");
        }

        static void Main()
        {
            Console.Write("Enter student's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter first score: ");
            double score1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second score: ");
            double score2 = double.Parse(Console.ReadLine());

            Console.Write("Enter third score: ");
            double score3 = double.Parse(Console.ReadLine());

            double average = CalculateAverage(score1, score2, score3);
            string gradeLetter = GetGradeLetter(average);

            PrintReportCard(name, average, gradeLetter);
        }
        */
        
    }

}

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



    }
}

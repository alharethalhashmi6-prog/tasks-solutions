namespace task5_solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // task 1

            int[] grades = new int[5];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nAll grades entered:");
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

            */

            //-------------------------------------------------------

            /*
            // task 3

                Stack<string> history = new Stack<string>();

                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Enter website URL " + (i + 1) + ": ");
                    string url = Console.ReadLine();
                    history.Push(url);
                }

                string previousPage = history.Pop();
                Console.WriteLine("\nYou pressed 'Back'. You landed on: " + previousPage);
            */

            //-------------------------------------------------------

            /*
            // task 2
                List<string> todoList = new List<string>();

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Enter task " + (i + 1) + ": ");
                    string task = Console.ReadLine();
                    todoList.Add(task);
                }

                Console.WriteLine("\nYour To-Do List:");
                int counter = 1;
                foreach (string task in todoList)
                {
                    Console.WriteLine(counter + ". " + task);
                    counter++;
                }
            */

            //-------------------------------------------------------

            /*
            // task 4

            Queue<string> customerQueue = new Queue<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter customer name " + (i + 1) + ": ");
                string name = Console.ReadLine();
                customerQueue.Enqueue(name);
            }

            string servedCustomer = customerQueue.Dequeue();
            Console.WriteLine("\nNow serving: " + servedCustomer);

            */

            //-------------------------------------------------------


        }

    }
}

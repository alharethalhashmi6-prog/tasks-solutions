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


            /*
            // task 5

            int[] grades = new int[5];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(grades);

            int lowest = grades[0];
            int highest = grades[grades.Length - 1];

            int sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            double average = (double)sum / grades.Length;

            Console.WriteLine("\nLowest grade: " + lowest);
            Console.WriteLine("Highest grade: " + highest);
            Console.WriteLine("Average grade: " + average);
            */

            //-------------------------------------------------------

            /*
            // task 6

            List<string> shoppingList = new List<string>();

            Console.WriteLine("Enter shopping items (type 'done' to finish):");
            string item = Console.ReadLine();

            while (item.ToLower() != "done")
            {
                shoppingList.Add(item);
                item = Console.ReadLine();
            }

            Console.WriteLine("\nShopping list before removal:");
            foreach (string i in shoppingList)
            {
                Console.WriteLine("- " + i);
            }

            Console.Write("\nEnter the item to remove: ");
            string itemToRemove = Console.ReadLine();
            shoppingList.Remove(itemToRemove);

            Console.WriteLine("\nShopping list after removal:");
            foreach (string i in shoppingList)
            {
                Console.WriteLine("- " + i);
            }
            */

            //-------------------------------------------------------

            /*
            // task 7

            List<int> scores = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter score " + (i + 1) + ": ");
                int score = int.Parse(Console.ReadLine());
                scores.Add(score);
            }

            scores.Sort();
            scores.Reverse();

            Console.WriteLine("Podium:");
            Console.WriteLine("1st place: " + scores[0]);
            Console.WriteLine("2nd place: " + scores[1]);
            Console.WriteLine("3rd place: " + scores[2]);
            */

            //-------------------------------------------------------

            /*
            // task 8
            Stack<string> actions = new Stack<string>();

            Console.WriteLine("Enter actions (type 'stop' to finish):");
            string action = Console.ReadLine();

            while (action.ToLower() != "stop")
            {
                actions.Push(action);
                action = Console.ReadLine();
            }

            Console.WriteLine("\nUndoing last 2 actions:");
            string undo1 = actions.Pop();
            Console.WriteLine("Undone: " + undo1);

            string undo2 = actions.Pop();
            Console.WriteLine("Undone: " + undo2);

            Console.WriteLine("\nRemaining actions on stack:");
            foreach (string remainingAction in actions)
            {
                Console.WriteLine("- " + remainingAction);

            }
            */

            //-------------------------------------------------------

            /*
            // task 9

            static double CalculateAverage(List<int> grades)
            {
                int sum = 0;
                foreach (int grade in grades)
                {
                    sum += grade;
                }
                return (double)sum / grades.Count;
            }

            static int FindFirstFailing(List<int> grades)
            {
                return grades.Find(x => x < 60);
            }

            static void Main()
            {
                Console.Write("How many grades do you want to enter? ");
                int count = int.Parse(Console.ReadLine());

                List<int> grades = new List<int>();

                for (int i = 0; i < count; i++)
                {
                    Console.Write("Enter grade " + (i + 1) + ": ");
                    int grade = int.Parse(Console.ReadLine());
                    grades.Add(grade);
                }

                double average = CalculateAverage(grades);
                int firstFailing = FindFirstFailing(grades);

                Console.WriteLine("\nAverage grade: " + average);

                if (firstFailing == 0)
                {
                    Console.WriteLine("No failing grades found.");
                }
                else
                {
                    Console.WriteLine("First failing grade: " + firstFailing);
                }
            }

            */
            //-------------------------------------------------------

        }

    }
}

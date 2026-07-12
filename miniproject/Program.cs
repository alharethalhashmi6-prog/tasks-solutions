namespace miniproject
{
    internal class Program
    {
           // Shared data storage - declared at class level (static) so that
            // EVERY function below can read and modify the same three lists
            // without needing them passed in as parameters.
            static List<string> customerNames = new List<string>();
            static List<string> accountNumbers = new List<string>();
            static List<double> balances = new List<double>();

            static void Main(string[] args)
            {
                bool exitApp = false;

                while (!exitApp)
                {
                    Console.WriteLine("\n===== Welcome to Spark Bank =====");
                    Console.WriteLine("1. Add New Account");
                    Console.WriteLine("2. Deposit Money");
                    Console.WriteLine("3. Withdraw Money");
                    Console.WriteLine("4. Show Balance");
                    Console.WriteLine("5. Transfer Amount");
                    Console.WriteLine("6. List All Accounts");
                    Console.WriteLine("7. Find Richest Customer");
                    Console.WriteLine("8. Exit");
                    Console.Write("Choose an option: ");

                    int choice;
                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                        continue; // skip the rest of this loop pass, show the menu again
                    }

                    switch (choice)
                    {
                        case 1:
                            AddAccount();
                            break;
                        case 2:
                            DepositMoney();
                            break;
                        case 3:
                            WithdrawMoney();
                            break;
                        case 4:
                            ShowBalance();
                            break;
                        case 5:
                            TransferAmount();
                            break;
                        case 6:
                            ListAllAccounts();
                            break;
                        case 7:
                            FindRichestCustomer();
                            break;
                        case 8:
                            exitApp = true;
                            Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid option, please choose between 1 and 8.");
                            break;
                    }
                }
            }

            // ===================== SERVICE FUNCTIONS =====================
            // Each function owns ONE service end-to-end: it asks the user for
            // whatever it needs, validates it, updates the shared lists, and
            // prints the outcome. Main never reads input or prints results
            // for these services - it only shows the menu and calls them.

            static void AddAccount()
            {
                Console.Write("Enter customer name: ");
                string name = Console.ReadLine();

                Console.Write("Enter a new account number: ");
                string accNumber = Console.ReadLine();

                if (accountNumbers.Contains(accNumber))
                {
                    Console.WriteLine("Error: An account with this number already exists.");
                    return;
                }

                double initialDeposit;
                try
                {
                    Console.Write("Enter initial deposit amount: ");
                    initialDeposit = double.Parse(Console.ReadLine());

                    if (initialDeposit < 0)
                    {
                        Console.WriteLine("Error: Initial deposit cannot be negative.");
                        return;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid amount entered.");
                    return;
                }

                // Add to all three lists together so they stay the same length
                customerNames.Add(name);
                accountNumbers.Add(accNumber);
                balances.Add(initialDeposit);

                Console.WriteLine("Account created successfully!");
                Console.WriteLine("Customer: " + name);
                Console.WriteLine("Account Number: " + accNumber);
                Console.WriteLine("Starting Balance: " + initialDeposit);
            }

            static void DepositMoney()
            {
                Console.Write("Enter account number: ");
                string accNumber = Console.ReadLine();

                int index = accountNumbers.IndexOf(accNumber);

                if (index == -1)
                {
                    Console.WriteLine("Error: Account number not found.");
                    return;
                }

                try
                {
                    Console.Write("Enter deposit amount: ");
                    double amount = double.Parse(Console.ReadLine());

                    if (amount <= 0)
                    {
                        Console.WriteLine("Error: Deposit amount must be positive.");
                        return;
                    }

                    balances[index] += amount;
                    Console.WriteLine("Deposit successful. Updated balance: " + balances[index]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid amount entered.");
                }
            }

            static void WithdrawMoney()
            {
                Console.Write("Enter account number: ");
                string accNumber = Console.ReadLine();

                int index = accountNumbers.IndexOf(accNumber);

                if (index == -1)
                {
                    Console.WriteLine("Error: Account number not found.");
                    return;
                }

                try
                {
                    Console.Write("Enter withdrawal amount: ");
                    double amount = double.Parse(Console.ReadLine());

                    if (amount <= 0)
                    {
                        Console.WriteLine("Error: Withdrawal amount must be positive.");
                        return;
                    }

                    if (amount > balances[index])
                    {
                        Console.WriteLine("Error: Insufficient balance for this withdrawal.");
                        return;
                    }

                    balances[index] -= amount;
                    Console.WriteLine("Withdrawal successful. Updated balance: " + balances[index]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid amount entered.");
                }
            }

            static void ShowBalance()
            {
                Console.Write("Enter account number: ");
                string accNumber = Console.ReadLine();

                int index = accountNumbers.IndexOf(accNumber);

                if (index == -1)
                {
                    Console.WriteLine("Error: Account number not found.");
                    return;
                }

                Console.WriteLine("Customer: " + customerNames[index]);
                Console.WriteLine("Account Number: " + accountNumbers[index]);
                Console.WriteLine("Balance: " + balances[index]);
            }

            static void TransferAmount()
            {
                Console.Write("Enter sender's account number: ");
                string senderAcc = Console.ReadLine();

                Console.Write("Enter receiver's account number: ");
                string receiverAcc = Console.ReadLine();

                int senderIndex = accountNumbers.IndexOf(senderAcc);
                int receiverIndex = accountNumbers.IndexOf(receiverAcc);

                if (senderIndex == -1 || receiverIndex == -1)
                {
                    Console.WriteLine("Error: One or both account numbers were not found.");
                    return;
                }

                try
                {
                    Console.Write("Enter amount to transfer: ");
                    double amount = double.Parse(Console.ReadLine());

                    if (amount <= 0)
                    {
                        Console.WriteLine("Error: Transfer amount must be positive.");
                        return;
                    }

                    if (amount > balances[senderIndex])
                    {
                        Console.WriteLine("Error: Insufficient balance for this transfer.");
                        return;
                    }

                    balances[senderIndex] -= amount;
                    balances[receiverIndex] += amount;

                    Console.WriteLine("Transfer successful!");
                    Console.WriteLine(customerNames[senderIndex] + "'s new balance: " + balances[senderIndex]);
                    Console.WriteLine(customerNames[receiverIndex] + "'s new balance: " + balances[receiverIndex]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Invalid amount entered.");
                }
            }

            // ===================== CUSTOM SERVICES (Options 6 & 7) =====================

            static void ListAllAccounts()
            {
                if (customerNames.Count == 0)
                {
                    Console.WriteLine("No accounts have been created yet.");
                    return;
                }

                Console.WriteLine("\n----- All Accounts -----");
                for (int i = 0; i < customerNames.Count; i++)
                {
                    Console.WriteLine((i + 1) + ") " + customerNames[i] +
                        " | Account: " + accountNumbers[i] +
                        " | Balance: " + balances[i]);
                }
            }

            static void FindRichestCustomer()
            {
                if (balances.Count == 0)
                {
                    Console.WriteLine("No accounts have been created yet.");
                    return;
                }

                int richestIndex = 0;

                for (int i = 1; i < balances.Count; i++)
                {
                    if (balances[i] > balances[richestIndex])
                    {
                        richestIndex = i;
                    }
                }

                Console.WriteLine("Richest customer: " + customerNames[richestIndex]);
                Console.WriteLine("Account Number: " + accountNumbers[richestIndex]);
                Console.WriteLine("Balance: " + balances[richestIndex]);
            }
        }

    }

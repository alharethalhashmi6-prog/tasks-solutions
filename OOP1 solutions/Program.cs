using System.Runtime.Intrinsics.X86;


using System;

namespace OOP1_Solutions
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        // Parameterless constructor kept so we can still use object-initializer style
        public BankAccount() { }

        // Case 16: parameterized constructor
        public BankAccount(int accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }

        // Case 18: read-only property
        public bool IsOverdrawn
        {
            get { return Balance < 0; }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            SendEmail();
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
            SendEmail();
        }

        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }

        private void PrintInformation()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Holder Name   : {HolderName}");
            Console.WriteLine($"Balance       : {Balance}");
        }

        private void SendEmail()
        {
            // Placeholder: represents an email notification being sent
        }
    }

    public class Student
    {
        // Case 17: static field + static method
        private static int totalStudents = 0;

        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string email;
        int age;

        // Case 19: write-only property backing field
        private int securityPin;

        public Student()
        {
            totalStudents++;
        }

        public Student(string name, string address, int grade) : this()
        {
            Name = name;
            Address = address;
            Grade = grade;
        }

        public static int GetTotalStudents()
        {
            return totalStudents;
        }

        // Case 19: write-only property (set accessor only)
        public int SecurityPin
        {
            set { securityPin = value; }
        }

        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        private void SendEmail()
        {
            // Placeholder: represents a registration email being sent
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public void Sell(int quantity)
        {
            if (quantity <= StockQuantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("Not enough stock to complete this sale.");
            }
            LogTransaction();
        }

        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }

        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }

        private void PrintDetails()
        {
            Console.WriteLine($"Product Name : {ProductName}");
            Console.WriteLine($"Price        : {Price}");
            Console.WriteLine($"StockQuantity: {StockQuantity}");
        }

        private void LogTransaction()
        {
            // Placeholder: represents a transaction being logged
        }
    }

    public class Program
    {
        // The six required individual objects (no collections)
        static BankAccount acc1 = new BankAccount { AccountNumber = 19216802, HolderName = "MEC", Balance = 12000 };
        static BankAccount acc2 = new BankAccount { AccountNumber = 19216803, HolderName = "SQU", Balance = 15000 };

        static Student student1 = new Student("Al harith", "Muscat", 90);
        static Student student2 = new Student("Ahmed", "Muscat", 70);

        static Product product1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
        static Product product2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };

        public static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                PrintMenu();
                string choiceInput = Console.ReadLine();

                if (!int.TryParse(choiceInput, out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 20.\n");
                    continue;
                }

                switch (choice)
                {
                    case 1: Case1_ViewAccountDetails(); break;
                    case 2: Case2_UpdateStudentAddress(); break;
                    case 3: Case3_MakeDeposit(); break;
                    case 4: Case4_MakeWithdrawal(); break;
                    case 5: Case5_ViewProductDetails(); break;
                    case 6: Case6_RegisterStudent(); break;
                    case 7: Case7_CompareAccountBalances(); break;
                    case 8: Case8_RestockAndCheckLevel(); break;
                    case 9: Case9_TransferBetweenAccounts(); break;
                    case 10: Case10_UpdateStudentGradeValidated(); break;
                    case 11: Case11_StudentReportCard(); break;
                    case 12: Case12_AccountHealthStatus(); break;
                    case 13: Case13_BulkSaleWithRevenue(); break;
                    case 14: Case14_ScholarshipEligibility(); break;
                    case 15: Case15_FullBalanceTopUp(); break;
                    case 16: Case16_QuickAccountOpening(); break;
                    case 17: Case17_TotalStudentsCounter(); break;
                    case 18: Case18_OverdrawnAccountCheck(); break;
                    case 19: Case19_SetStudentSecurityPin(); break;
                    case 20:
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please pick a number between 1 and 20.\n");
                        break;
                }

                Console.WriteLine("press any key: ");
                Console.ReadKey();
                Console.Clear();

            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("========== MAIN MENU ==========");
            Console.WriteLine(" 1. View Account Details");
            Console.WriteLine(" 2. Update Student Address");
            Console.WriteLine(" 3. Make a Deposit");
            Console.WriteLine(" 4. Make a Withdrawal");
            Console.WriteLine(" 5. View Product Details");
            Console.WriteLine(" 6. Register a Student");
            Console.WriteLine(" 7. Compare Two Account Balances");
            Console.WriteLine(" 8. Restock Product & Stock Level Check");
            Console.WriteLine(" 9. Transfer Between Accounts");
            Console.WriteLine("10. Update Student Grade (Validated)");
            Console.WriteLine("11. Student Report Card");
            Console.WriteLine("12. Account Health Status");
            Console.WriteLine("13. Bulk Sale With Revenue Calculation");
            Console.WriteLine("14. Scholarship Eligibility Check");
            Console.WriteLine("15. Full Balance Top-Up Flow");
            Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
            Console.WriteLine("17. Total Students Counter (Static)");
            Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
            Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
            Console.WriteLine("20. Exit");
            Console.Write("Choose an option: ");
        }

        // ---------- Selection helpers ----------

        static BankAccount SelectAccount()
        {
            Console.WriteLine("Select an account:");
            Console.WriteLine($"1. {acc1.HolderName} (Acc #{acc1.AccountNumber})");
            Console.WriteLine($"2. {acc2.HolderName} (Acc #{acc2.AccountNumber})");
            Console.Write("Choice (1 or 2): ");
            string input = Console.ReadLine();
            return input == "2" ? acc2 : acc1;
        }

        static Student SelectStudent()
        {
            Console.WriteLine("Select a student:");
            Console.WriteLine($"1. {student1.Name}");
            Console.WriteLine($"2. {student2.Name}");
            Console.Write("Choice (1 or 2): ");
            string input = Console.ReadLine();
            return input == "2" ? student2 : student1;
        }

        static Product SelectProduct()
        {
            Console.WriteLine("Select a product:");
            Console.WriteLine($"1. {product1.ProductName}");
            Console.WriteLine($"2. {product2.ProductName}");
            Console.Write("Choice (1 or 2): ");
            string input = Console.ReadLine();
            return input == "2" ? product2 : product1;
        }

        static double ReadDouble(string prompt)
        {
            Console.Write(prompt);
            double.TryParse(Console.ReadLine(), out double value);
            return value;
        }

        // ---------- EASY ----------

        static void Case1_ViewAccountDetails()
        {
            BankAccount acc = SelectAccount();
            acc.CheckBalance();
        }

        static void Case2_UpdateStudentAddress()
        {
            Student s = SelectStudent();
            Console.Write("Enter new address: ");
            string newAddress = Console.ReadLine();
            s.Address = newAddress;
            Console.WriteLine($"Address updated. {s.Name}'s new address is: {s.Address}");
        }

        static void Case3_MakeDeposit()
        {
            BankAccount acc = SelectAccount();
            double amount = ReadDouble("Enter deposit amount: ");
            acc.Deposit(amount);
            Console.WriteLine($"{acc.HolderName}'s updated balance: {acc.Balance}");
        }

        static void Case4_MakeWithdrawal()
        {
            BankAccount acc = SelectAccount();
            double amount = ReadDouble("Enter withdrawal amount: ");
            acc.Withdraw(amount);
            Console.WriteLine($"Updated balance: {acc.Balance}");
        }

        static void Case5_ViewProductDetails()
        {
            Product p = SelectProduct();
            double value = p.GetInventoryValue();
            Console.WriteLine($"Total inventory value: {value}");
        }

        // ---------- MEDIUM ----------

        static void Case6_RegisterStudent()
        {
            Student s = SelectStudent();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            s.Register(email);
            Console.WriteLine($"{s.Name} has been registered successfully.");
        }

        static void Case7_CompareAccountBalances()
        {
            if (acc1.Balance > acc2.Balance)
            {
                Console.WriteLine($"{acc1.HolderName} has more money ({acc1.Balance} vs {acc2.Balance}).");
            }
            else if (acc2.Balance > acc1.Balance)
            {
                Console.WriteLine($"{acc2.HolderName} has more money ({acc2.Balance} vs {acc1.Balance}).");
            }
            else
            {
                Console.WriteLine("Both accounts have equal balances.");
            }
        }

        static void Case8_RestockAndCheckLevel()
        {
            Product p = SelectProduct();
            Console.Write("Enter quantity to restock: ");
            int.TryParse(Console.ReadLine(), out int qty);
            p.Restock(qty);

            if (p.StockQuantity < 10)
                Console.WriteLine("Stock level: Low");
            else if (p.StockQuantity <= 49)
                Console.WriteLine("Stock level: Moderate");
            else
                Console.WriteLine("Stock level: Well Stocked");
        }

        // ---------- HARD ----------

        static void Case9_TransferBetweenAccounts()
        {
            Console.WriteLine("-- Choose SOURCE account --");
            BankAccount source = SelectAccount();
            Console.WriteLine("-- Choose DESTINATION account --");
            BankAccount destination = SelectAccount();
            double amount = ReadDouble("Enter amount to transfer: ");

            if (source.Balance >= amount)
            {
                source.Withdraw(amount);
                destination.Deposit(amount);
                Console.WriteLine($"Transferred {amount} from {source.HolderName} to {destination.HolderName}.");
            }
            else
            {
                Console.WriteLine("Transfer failed: insufficient funds in source account.");
            }
        }

        static void Case10_UpdateStudentGradeValidated()
        {
            Student s = SelectStudent();
            Console.Write("Enter new grade: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int newGrade))
            {
                Console.WriteLine("Invalid input: grade must be a number. No change made.");
                return;
            }

            if (newGrade < 0 || newGrade > 100)
            {
                Console.WriteLine("Invalid grade: must be between 0 and 100. No change made.");
                return;
            }

            s.Grade = newGrade;
            Console.WriteLine($"{s.Name}'s grade updated to {s.Grade}.");
        }

        static void Case11_StudentReportCard()
        {
            Student s = SelectStudent();
            string result = s.Grade >= 60 ? "Pass" : "Fail";

            Console.WriteLine("---- Report Card ----");
            Console.WriteLine($"Name   : {s.Name}");
            Console.WriteLine($"Address: {s.Address}");
            Console.WriteLine($"Grade  : {s.Grade}");
            Console.WriteLine($"Result : {result}");
        }

        static void Case12_AccountHealthStatus()
        {
            BankAccount acc = SelectAccount();
            string status;

            if (acc.Balance < 50)
                status = "Low Balance";
            else if (acc.Balance <= 1000)
                status = "Healthy";
            else
                status = "Premium";

            Console.WriteLine($"{acc.HolderName}'s account status: {status}");
        }

        static void Case13_BulkSaleWithRevenue()
        {
            Product p = SelectProduct();
            Console.Write("Enter quantity to sell: ");
            int.TryParse(Console.ReadLine(), out int qty);

            if (qty > p.StockQuantity)
            {
                int shortfall = qty - p.StockQuantity;
                Console.WriteLine($"Not enough stock. You need {shortfall} more unit(s) to fulfill this order. Sale cancelled.");
                return;
            }

            p.Sell(qty);
            double revenue = qty * p.Price;
            Console.WriteLine($"Sale complete. Total revenue: {revenue}");
        }

        // ---------- ADVANCED ----------

        static void Case14_ScholarshipEligibility()
        {
            Console.WriteLine("-- Choose the student --");
            Student s = SelectStudent();
            Console.WriteLine("-- Choose the account --");
            BankAccount acc = SelectAccount();

            bool gradeOk = s.Grade >= 80;
            bool balanceOk = acc.Balance >= 100;

            if (gradeOk && balanceOk)
            {
                Console.WriteLine("Eligible for scholarship.");
            }
            else
            {
                Console.WriteLine("Not eligible. Reason(s):");
                if (!gradeOk) Console.WriteLine($" - Grade too low ({s.Grade}, needs 80+).");
                if (!balanceOk) Console.WriteLine($" - Balance too low ({acc.Balance}, needs 100+).");
            }
        }

        static void Case15_FullBalanceTopUp()
        {
            BankAccount acc = SelectAccount();
            double before = acc.Balance;

            if (before < 50)
            {
                double topUp = 100 - before;
                acc.Deposit(topUp);
                Console.WriteLine($"Balance before: {before}");
                Console.WriteLine($"Topped up by  : {topUp}");
                Console.WriteLine($"Balance after : {acc.Balance}");
            }
            else
            {
                Console.WriteLine("No top-up needed; balance is already 50 or above.");
            }
        }

        // ---------- RESEARCH-BASED ----------

        static void Case16_QuickAccountOpening()
        {
            Console.Write("Enter new account number: ");
            int.TryParse(Console.ReadLine(), out int accNum);
            Console.Write("Enter holder name: ");
            string holder = Console.ReadLine();
            double startingBalance = ReadDouble("Enter starting balance: ");

            BankAccount newAccount = new BankAccount(accNum, holder, startingBalance);
            Console.WriteLine("New account created:");
            newAccount.CheckBalance();
        }

        static void Case17_TotalStudentsCounter()
        {
            int total = Student.GetTotalStudents();
            Console.WriteLine($"Total students created so far: {total}");
        }

        static void Case18_OverdrawnAccountCheck()
        {
            BankAccount acc = SelectAccount();
            if (acc.IsOverdrawn)
                Console.WriteLine($"{acc.HolderName}'s account is OVERDRAWN.");
            else
                Console.WriteLine($"{acc.HolderName}'s account is not overdrawn.");
        }

        static void Case19_SetStudentSecurityPin()
        {
            Student s = SelectStudent();
            Console.Write("Enter a 4-digit PIN: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int pin) || input.Length != 4)
            {
                Console.WriteLine("Invalid PIN. It must be exactly 4 digits. No change made.");
                return;
            }

            s.SecurityPin = pin;
            Console.WriteLine($"PIN set successfully for {s.Name}.");
        }
    }
}
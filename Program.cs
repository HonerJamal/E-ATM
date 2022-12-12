internal class Program
{
    private static void Main(string[] args)
    {
        AccountManager acm = new();
        DebitCardManager dbm = new();
        DebitCard dc = new();
        Account acc = new();

            Console.WriteLine("***WELCOME TO YOUR FAVOURITE ATM***");
            Console.WriteLine("--------------------------------");
        
        bool cardValidation = false;
        while (cardValidation == false)
        {
            Console.Write("Please enter your ID to access your account: ");
            
            int id = int.Parse(Console.ReadLine());
            dbm.ValidateCard(id);
            Console.WriteLine("Please enter your PIN: ");
            int pin = int.Parse(Console.ReadLine());
            dbm.ValidatePin(pin);
            cardValidation = true;
            break;
        }
       
       
        while (cardValidation == true)
        {
            Console.WriteLine("Checking card number and PIN");
            int timer = 10;
            for (int i = 0; i < timer; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
            Console.Clear();
            Console.WriteLine("\nCard Validated!!");
            System.Console.WriteLine("***WELCOME***");
            System.Console.WriteLine("--------------");
            Console.WriteLine("Please choose your account: ");
            int id = int.Parse(Console.ReadLine());
            acm.ActiveAccount(id);
            Console.WriteLine("---------------------------");
            Console.WriteLine("\nPlease choose an option below");
            Console.WriteLine("[1] Withdraw");
            Console.WriteLine("[2] Check Balance");
            Console.WriteLine("[3] Deposit");
            Console.WriteLine("[4] Exit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                Console.WriteLine("***WITHDRAW***");
                Console.WriteLine("\nHow much would you like to withdraw?");
                int cash = int.Parse(Console.ReadLine());
                acm.WithdrawCash(cash);
                Console.WriteLine("Please wait...");
                Thread.Sleep(3000);
                Console.WriteLine("Please take your card");
                Console.WriteLine("(Press ENTER)");
                Console.ReadLine();
                Console.WriteLine("Please take your money");
                Console.WriteLine("Thank you for using your favourite ATM, Goodbye");
                Thread.Sleep(500);
                Environment.Exit(0);

            }

            if (choice == "2")
            {
                Console.Clear();
                int checkBalance = acm.GetBalance();
                Console.WriteLine("Your current balance is: " + checkBalance);
                System.Console.WriteLine("Press any key to exit");
                Console.ReadLine();
                Environment.Exit(0);
            }

            if (choice == "3")
            {
                Console.Clear();
                Console.WriteLine("How much would you like to deposit?");
                int deposit = int.Parse(Console.ReadLine());
                acm.DepositCash(deposit);
                Console.WriteLine("Please wait while we count your inserted cash...");
                Thread.Sleep(1000);
                Console.WriteLine("Please take your card");
                Console.WriteLine("(PRESS ENTER)");
                Console.ReadLine();
                Console.WriteLine("Thank you for using your favourite ATM, Goodbye");
                Thread.Sleep(500);
                Environment.Exit(0);
            }

            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Good Bye");
                Console.WriteLine("Dont forget your card");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }

            break;
        }
    }
}    
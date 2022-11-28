internal class Program
{
    private static void Main(string[] args)
    {
        AccountManager acm = new();
        DebitCardManager dbm = new();
        DatabaseConnections dbc = new();
        DebitCard dc = new();

            Console.WriteLine("***WELCOME TO YOUR FAVOURITE ATM***");
            Console.WriteLine("--------------------------------");
        
        bool cardValidation = false;
        while (cardValidation == false)
        {
            Console.Write("Please enter your ID to access your account: ");
            dbm.ValidateCard();
            cardValidation = true;
            break;

        }
       
       
        while (cardValidation == true)
        {
            //Console.Clear();
            System.Console.WriteLine("Card Validated!!");
            Console.WriteLine("\n\n Please choose an option below");

            break;
        }
    }
}    
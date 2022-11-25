internal class Program
{
    private static void Main(string[] args)
    {
        AccountManager acm = new();
        DebitCardManager dbm = new();
        InputManager im = new();
        DatabaseConnections dbc = new();
        
        bool cardValidation = true;
        while (cardValidation == true)
        {
            //Console.Clear();
            Console.WriteLine("***WELCOME TO YOUR FAVOURITE ATM***");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Please enter your ID to access your account....");
            dbm.ValidateCard();
            
        }

        while(cardValidation == false)
        {
            Console.WriteLine(dbm.ValidateCard);
        }


    }
}
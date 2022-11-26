internal class Program
{
    private static void Main(string[] args)
    {
        AccountManager acm = new();
        DebitCardManager dbm = new();
        InputManager im = new();
        DatabaseConnections dbc = new();
        DebitCard dc = new();

        bool cardValidation = false;
        while (cardValidation == false)
        {
            //Console.Clear();
            Console.WriteLine("***WELCOME TO YOUR FAVOURITE ATM***");
            Console.WriteLine("--------------------------------");
            Console.Write("Please enter your ID to access your account: ");
            dbm.ValidateCard();

        }
       
       
        bool menu = true;
        while (menu == true)
        {
            Console.Clear();
        }
    }
}    
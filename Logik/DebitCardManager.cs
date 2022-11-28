using Dapper;
using MySqlConnector;
public class DebitCardManager
{
    DatabaseConnections dbc = new();
    DebitCard dc = new();
    DebitCard? cardValidation;
    bool tryAgain = true;

    //Validera kort, returna ID och exp_date
    public DebitCard ValidateCard()
    {
        while (tryAgain)
        {
            try
            {        
                dbc.Open();
                int input = Convert.ToInt32(Console.ReadLine());
                //int DebitCard = im.InputError(1, 99, "Invalid ID, Please try again");
                var cardInfo = dbc.connection.Query<DebitCard>($"SELECT * FROM debitcard WHERE ID ='{input}'").ToList();
                foreach (DebitCard dc in cardInfo)
                {
                    Console.WriteLine("ID: " + dc.ID + " " + "Expiration date: " + dc.exp_date);
                }
                return cardValidation;
            }

            catch (Exception e)
            {
                Console.WriteLine("Invalid ID, Please try again!");
                tryAgain = true;
            }
        }
        return cardValidation;    
    }

    //Validera Pin
    // connecta account_to_debit card med pin så får vi ut aktuella accountet (INNER JOIN)
    /*public void ValidatePin()
    {
        dbc.Open();
        int pinInput = Convert.ToInt32(Console.ReadLine());
        var cardInfo = dbc.connection.Query<DebitCard>($"SELECT pin FROM WHERE pin = '{pinInput}'");
        foreach (DebitCard dc in cardInfo)
        {
            Console.WriteLine("***WELCOME***");
        }
    }*/
}
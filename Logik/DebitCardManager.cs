using Dapper;
using MySqlConnector;
public class DebitCardManager
{
    DatabaseConnections dbc = new();
    InputManager im = new();
    DebitCard dc = new();

    //Validera kort, returna ID och exp_date
    public void ValidateCard()
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
            }

            catch (Exception e)
            {
                Console.WriteLine("Invalid ID, Please try again!");
            }
    }

    //Validera Pin
    public void ValidatePin()
    {
        dbc.Open();
        int pinInput = Convert.ToInt32(Console.ReadLine());
        var cardInfo = dbc.connection.Query<DebitCard>($"SELECT pin FROM WHERE pin = '{pinInput}'");
        foreach (DebitCard dc in cardInfo)
        {
            Console.WriteLine("***WELCOME***");
        }
    }
}
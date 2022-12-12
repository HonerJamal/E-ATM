using Dapper;
public class DebitCardManager
{
    DatabaseConnections dbc = new();
    DebitCard? cardValidation;
    bool tryAgain = true;

    public DebitCard ValidateCard(int id)
    {
        while (tryAgain)
        {
            try
            {        
                dbc.Open();
                var cardInfo = dbc.connection.Query<DebitCard>($"SELECT * FROM debitcard WHERE ID ='{id}'").ToList();
                foreach (DebitCard dc in cardInfo)
                {
                    Console.WriteLine("ID: " + dc.ID + " " + "Expiration date: " + dc.exp_date);
                }
                return cardValidation;
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid ID, Please try again!");
                tryAgain = true;
            }
        }
        return cardValidation;    
    }

    public DebitCard ValidatePin(int pin)
    {
        while (tryAgain)
        {
            try
            {        
                dbc.Open();
                var cardInfo = dbc.connection.Query<DebitCard>($"SELECT * FROM debitcard WHERE pin ='{pin}'").ToList();
                foreach (DebitCard dc in cardInfo)
                {
                    return cardValidation;
                }
            }

            catch (Exception)
            {
                
                Console.WriteLine("Invalid PIN, Please try again!");
                tryAgain = true;
            }
        }
        return cardValidation;    
    }

}
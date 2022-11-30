using Dapper;
public class DebitCardManager
{
    DatabaseConnections dbc = new();
    DebitCard? cardValidation;
    bool tryAgain = true;

    public DebitCard ValidateCard()
    {
        while (tryAgain)
        {
            try
            {        
                dbc.Open();
                int input = Convert.ToInt32(Console.ReadLine());
                var cardInfo = dbc.connection.Query<DebitCard>($"SELECT * FROM debitcard WHERE ID ='{input}'").ToList();
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

    public DebitCard ValidatePin()
    {
        while (tryAgain)
        {
            try
            {        
                dbc.Open();
                int input = Convert.ToInt32(Console.ReadLine());;
                var cardInfo = dbc.connection.Query<DebitCard>($"SELECT * FROM debitcard WHERE pin ='{input}'").ToList();
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
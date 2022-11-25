using Dapper;
public class DebitCardManager
{
    DatabaseConnections dbc = new();
    InputManager im = new();
    DebitCard dc = new();
    DebitCard? Cardinsertetion;

    //Validera kort, returna ID och exp_date
    public DebitCard ValidateCard()
    {
        dbc.Open();
        string input = Console.ReadLine();
        var cardInfo = dbc.connection.Query<DebitCard>($"SELECT ID, pin, exp_date FROM debitcard WHERE ID ='{input}'");
        foreach (DebitCard info in cardInfo)
        {
            Cardinsertetion = info;
            //Console.WriteLine("ID: " + dc.ID + " " + "Expiration Date: " + dc.exp_date);
        }
        return Cardinsertetion;
    }

    //Validera Pin
    public void ValidatePin()
    {

    }
}
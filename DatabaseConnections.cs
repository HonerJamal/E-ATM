using MySqlConnector;
using Dapper;
using System.Data;
public class DatabaseConnections
{
    private string connectionstring = "Server=localhost;Database=eatm;Uid=root;pwd=;";
    public MySqlConnection connection;

    public DatabaseConnections()
    {
        Connect();
    }

    public void Connect()
    {
        connection = new MySqlConnection(connectionstring);
        Open();
    }

    public void Open()
    {
        if(connection.State != ConnectionState.Open)
        connection.Open();
    }
}

/*class Datamanager
{
    string cnn = "Server=localhost;Database=eatm;Uid=root;pwd=;";
    
    
    public List<DebitCard> getList(int ID) 
    {
        using(var connection = new MySqlConnection(cnn))
        {
            //string input = Console.ReadLine();
            string cnn = $"SELECT * FROM debitcard WHERE ID = ID";
            return connection.Query<DebitCard>(cnn).ToList();
        }
    }

}*/
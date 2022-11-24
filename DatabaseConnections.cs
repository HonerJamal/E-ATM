using MySqlConnector;
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
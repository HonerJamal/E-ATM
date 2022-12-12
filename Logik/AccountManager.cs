using Dapper;
public class AccountManager
{
    DatabaseConnections dbc = new();
    public void ActiveAccount(int id)
    {
        dbc.Open();
        var accInfo = dbc.connection.Query<Account>($"SELECT * FROM account WHERE ID = '{id}'");
        foreach (Account ac in accInfo)
        {
            Console.WriteLine("You are on this account: " + ac.account_name);
        }
    }

    public void WithdrawCash(int cash)
    {
        int myBalance = GetBalance();
        if (cash > myBalance)
        {
            Console.WriteLine("Insufficient funds!!");
            System.Console.WriteLine("Please take your card");
            Thread.Sleep(3000);
            Environment.Exit(0);
        }
        
        else 
        {
            var cashOut = dbc.connection.Query<Account>($"UPDATE account SET balance = balance - {cash} WHERE ID = 1");
        }

    }

    public int GetBalance()
    {
        int checkBalance = dbc.connection.QuerySingle<int>($"SELECT balance FROM account WHERE ID = 1");
        return checkBalance;
    }

    public void DepositCash(int deposit)
    {
        var cashIn = dbc.connection.Query<Account>($"UPDATE account SET balance = balance + {deposit} WHERE ID = 1");
    }



}
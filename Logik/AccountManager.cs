using Dapper;
public class AccountManager
{
    DatabaseConnections dbc = new();
    public void ActiveAccount()
    {
        dbc.Open();
        int input = Convert.ToInt32(Console.ReadLine());
        var accInfo = dbc.connection.Query<Account>($"SELECT * FROM account WHERE ID = '{input}'");
        foreach (Account ac in accInfo)
        {
            Console.WriteLine("You are on this account: " + ac.account_name);
        }
    }

    public void WithdrawCash()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        var cashOut = dbc.connection.Query<Account>($"UPDATE account SET balance = balance - {input} WHERE ID = 1");
    }

    public void GetBalance()
    {
        var checkBalance = dbc.connection.Query<Account>($"SELECT balance FROM account WHERE ID = 1");
        foreach (Account b in checkBalance)
        {
            Console.WriteLine("Your current balance is: " + b.balance);
        }
    }

    public void DepositCash()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        var cashIn = dbc.connection.Query<Account>($"UPDATE account SET balance = balance + {input} WHERE ID = 1");
    }


}
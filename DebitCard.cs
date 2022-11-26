public class DebitCard
{
    public int ID {get; set;}
    public int pin {get; set;}
    public string exp_date {get; set;}

    public DebitCard()
    {

    }

    public override string ToString()
    {
        return $"{ID}-{pin}-{exp_date}";
    }
}
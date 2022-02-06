namespace BlockChain;

public class Transaction : BaseEntity
{
    public int BlockId { get; set; }
    public string Recepient { get; set; }
    public string Sender { get; set; }

    public int Value { get; set; }
}
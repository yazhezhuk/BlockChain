namespace BlockChain;

public interface ITransactionManager
{
    void DefineNewTransaction(Block block,
        string sender,string recipient,decimal amount)
    {
        
    }
}
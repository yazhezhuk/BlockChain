namespace BlockChain;

public class ChainManager
{
    private readonly IRepository<Block> _blockRepository;
    private readonly 
    
    public ChainManager(IRepository<Block> blockRepository)
    {
        _blockRepository = blockRepository;
    }

    public void DefineNewBlock(ulong proof,string previousHash)
    {
            
    } 
}
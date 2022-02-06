namespace BlockChain;

public sealed class GenesisBlock : Block
{
    public override string PreviousBlockHash { get; set; } = "Vitaliy Zhukovets";
}
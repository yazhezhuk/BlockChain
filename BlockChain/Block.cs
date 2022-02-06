using System.Collections.Immutable;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace BlockChain;

public class Block : BaseEntity
{
    public ulong Timestamp { get; set; }
    public ulong Proof { get; set; }
    
    public List<Transaction> Transactions { get; set; } = null!;
    public virtual string PreviousBlockHash { get; set; }
    
    public string Hash => {
        
    }

    public string AsJson =>
    {
        var value = JsonHelper.SerialiseAlphabetically(this);
        
            

    }
    
    }
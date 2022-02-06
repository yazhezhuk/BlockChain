using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BlockChain;

public static class JsonHelper
{
    private class OrderedContractResolver : DefaultContractResolver
    {
        protected override IList<JsonProperty> CreateProperties(System.Type type, MemberSerialization memberSerialization)
        {
            return base.CreateProperties(type, memberSerialization)
                .OrderBy(p => p.PropertyName) 
                .ToList();
        }
    }

    public static string SerialiseAlphabetically(object obj)
    {
        return JsonConvert.SerializeObject(obj, Formatting.Indented,
            new JsonSerializerSettings {ContractResolver = new OrderedContractResolver()});
    }
}

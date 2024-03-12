using System.Text.Json;
using System.Text.Json.Serialization;

namespace Rootwire.ApiClients.SuperOps.Models.Client;

public class ClientUserDetail
{

    public ClientUserDetail()
    {
        
    }

    public ClientUserDetail(JsonElement jsonElement)
    {
        var clientUserDetail = jsonElement.Deserialize<ClientUserDetail>();
        if (clientUserDetail != null)
        {
            UserId = clientUserDetail.UserId;
            Name = clientUserDetail.Name;
        }
    }

    public ClientUserDetail(string userId, string name)
    {
        UserId = userId;
        Name = name;
    }
    
    [JsonPropertyName("userId")]
    public string UserId { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
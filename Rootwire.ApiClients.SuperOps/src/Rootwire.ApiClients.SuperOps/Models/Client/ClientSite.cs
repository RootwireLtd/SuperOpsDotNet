using System.Text.Json;
using System.Text.Json.Serialization;

namespace Rootwire.ApiClients.SuperOps.Models.Client;

public class ClientSite
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }

    public ClientSite()
    {
        
    }

    public ClientSite(JsonElement jsonElement)
    {
        var clientSite = jsonElement.Deserialize<ClientSite>();

        if (clientSite != null)
        {
            Id = clientSite.Id;
            Name = clientSite.Name;
        }
    }
    public ClientSite(string id, string name)
    {
        Id = id;
        Name = name;
    }
}
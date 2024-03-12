using System.Text.Json;
using Rootwire.ApiClients.SuperOps.Models.Client;

namespace Rootwire.ApiClients.SuperOps.Tests.Models.Client;

public class ClientSiteTests
{
    [Fact]
    public void Task_Test_ClientSiteCanBeInitialisedFromJsonElement()
    {
        string jsonString =
            "{\"id\":\"6388330821016842241\",\"name\":\"Client Site Headquarters\"}";

        JsonElement jsonElement = JsonDocument.Parse(jsonString).RootElement;

        ClientSite serviceItem = new ClientSite(jsonElement);
        
        Assert.Equal("6388330821016842241", serviceItem.Id);
        Assert.Equal("Client Site Headquarters", serviceItem.Name);
    }

    [Fact]
    public void Task_Test_ClientSiteCanBeConstructedFromJsonDeserializer()
    {
        string jsonString =
            "{\"id\":\"6388330821016842241\",\"name\":\"Client Site Headquarters\"}";

        JsonElement jsonElement = JsonDocument.Parse(jsonString).RootElement;
        
        var serviceItem = JsonSerializer.Deserialize<ClientSite>(jsonElement);
    
        Assert.Equal("6388330821016842241", serviceItem.Id);
        Assert.Equal("Client Site Headquarters", serviceItem.Name);

    }
}
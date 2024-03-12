using System.Text.Json;
using Rootwire.ApiClients.SuperOps.Models.Client;
using Rootwire.ApiClients.SuperOps.Models.InvoiceItem;

namespace Rootwire.ApiClients.SuperOps.Tests.Models.Client;

public class ClientUserDetailTests
{
    [Fact]
    public void Task_Test_ClientUserDetailCanBeInitialisedFromJsonElement()
    {
        string jsonString =
            "{\"userId\":\"6388330821016842241\",\"name\":\"Client User Name\"}";

        JsonElement jsonElement = JsonDocument.Parse(jsonString).RootElement;

        ClientUserDetail serviceItem = new ClientUserDetail(jsonElement);
        
        Assert.Equal("6388330821016842241", serviceItem.UserId);
        Assert.Equal("Client User Name", serviceItem.Name);
    }

    [Fact]
    public void Task_Test_ClientUserDetailCanBeConstructedFromJsonDeserializer()
    {
        string jsonString =
            "{\"userId\":\"6388330821016842241\",\"name\":\"Client User Name\"}";

        JsonElement jsonElement = JsonDocument.Parse(jsonString).RootElement;
        ClientUserDetail serviceItem = JsonSerializer.Deserialize<ClientUserDetail>(jsonElement);
        
        Assert.Equal("6388330821016842241", serviceItem.UserId);
        Assert.Equal("Client User Name", serviceItem.Name);

    }
}
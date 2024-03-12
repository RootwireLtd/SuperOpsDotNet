using System.Text.Json;
using Rootwire.ApiClients.SuperOps.Models.Invoice;

namespace Rootwire.ApiClients.SuperOps.Tests.Models.Invoice;

public class InvoiceClientTests
{
    [Fact]
    public void Task_Test_InvoiceClientCanBeInitialisedFromJsonElement()
    {
        string JsonString = "{\"accountId\":\"224975260544155648\",\"name\":\"ClientName\"}";

        JsonElement jsonElement = JsonDocument.Parse(JsonString).RootElement;

        InvoiceClient invoiceClient = new InvoiceClient(jsonElement);
        
        Assert.Equal("224975260544155648", invoiceClient.AccountId);
        Assert.Equal("ClientName", invoiceClient.Name);
    }
    [Fact]
    public void Task_Test_InvoiceClientCanBeConstructedFromJsonDeserializer()
    {
        string JsonString = "{\"accountId\":\"224975260544155648\",\"name\":\"ClientName\"}";

        JsonElement jsonElement = JsonDocument.Parse(JsonString).RootElement;

        InvoiceClient invoiceClient = JsonSerializer.Deserialize<InvoiceClient>(jsonElement);
        
        Assert.Equal("224975260544155648", invoiceClient.AccountId);
        Assert.Equal("ClientName", invoiceClient.Name);
    }
}
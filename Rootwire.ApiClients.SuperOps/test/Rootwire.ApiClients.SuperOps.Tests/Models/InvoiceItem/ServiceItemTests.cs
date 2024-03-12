using System.Text.Json;
using Rootwire.ApiClients.SuperOps.Models.InvoiceItem;

namespace Rootwire.ApiClients.SuperOps.Tests.Models.InvoiceItem;

public class ServiceItemTests
{
    [Fact]
    public void Task_Test_ServiceItemCanBeInitialisedFromJsonElement()
    {
        string jsonString =
            "{\"itemId\":\"6388330821016842241\",\"name\":\"Labour | Support and Maintenance\",\"quantityType\":\"HOURS\"}";

        JsonElement jsonElement = JsonDocument.Parse(jsonString).RootElement;

        ServiceItem serviceItem = new ServiceItem(jsonElement);
        
        Assert.Equal("6388330821016842241", serviceItem.ItemId);
        Assert.Equal("Labour | Support and Maintenance", serviceItem.Name);
        Assert.Equal("HOURS", serviceItem.QuantityType);
    }

    [Fact]
    public void Task_Test_ServiceItemCanBeConstructedFromJsonDeserializer()
    {
        string jsonString =
            "{\"itemId\":\"6388330821016842241\",\"name\":\"Labour | Support and Maintenance\",\"quantityType\":\"HOURS\"}";

    JsonElement jsonElement = JsonDocument.Parse(jsonString).RootElement;

    
    
    var serviceItem = JsonSerializer.Deserialize<ServiceItem>(jsonElement);
    
    Assert.Equal("6388330821016842241", serviceItem.ItemId);
    Assert.Equal("Labour | Support and Maintenance", serviceItem.Name);
    Assert.Equal("HOURS", serviceItem.QuantityType);

    }
}
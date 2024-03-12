using System.Text.Json;
using System.Text.Json.Serialization;

namespace Rootwire.ApiClients.SuperOps.Models.InvoiceItem;

public class ServiceItem
{
    [JsonPropertyName("itemId")]
    public string ItemId { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("quantityType")]
    public string QuantityType { get; set; }

    public ServiceItem(JsonElement jsonElement)
    {
        var serviceItem = jsonElement.Deserialize<ServiceItem>();
        if (serviceItem != null)
        {
            ItemId = serviceItem.ItemId;
            Name = serviceItem.Name;
            QuantityType = serviceItem.QuantityType;
        }
    }

    // Default constructor
    public ServiceItem() {}

    // Additional constructor for other purposes (if needed)
    public ServiceItem(string itemId, string name, string quantityType)
    {
        ItemId = itemId;
        Name = name;
        QuantityType = quantityType;
    }
    
    
}
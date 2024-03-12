using System.Text.Json;
using System.Text.Json.Serialization;

namespace Rootwire.ApiClients.SuperOps.Models.Invoice;

public class InvoiceClient
{

    public InvoiceClient()
    {
        
    }
    
    public InvoiceClient(JsonElement jsonElement)
    {
        var invoiceClient = jsonElement.Deserialize<InvoiceClient>();
        if (invoiceClient != null)
        {
            AccountId = invoiceClient.AccountId;
            Name = invoiceClient.Name;
        }
    }

    public InvoiceClient(string accountId, string name)
    {
        AccountId = accountId;
        Name = name;
    }
    
    [JsonPropertyName("accountId")]
    public string AccountId { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
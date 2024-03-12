using StrawberryShake;

namespace Rootwire.ApiClients.SuperOps.Services;

public class InvoiceService
{
    private readonly ISuperOpsGraphQLClient _superOpsGraphQlClient;

    public InvoiceService(ISuperOpsGraphQLClient superOpsGraphQlClient)
    {
        _superOpsGraphQlClient = superOpsGraphQlClient;
    }

    public async Task<IGetInvoiceList_GetInvoiceList?> GetInvoiceListAsync(int pageNumber = 1, int pageSize = 50,
        RuleConditionInput? ruleConditionInput = null, IReadOnlyList<SortInput>? sortInput = null)
    {
        var listInfoInput = new ListInfoInput
        {
            Page = pageNumber,
            PageSize = pageSize,
            Condition = ruleConditionInput,
            Sort = sortInput
        };

        var response = await _superOpsGraphQlClient.GetInvoiceList.ExecuteAsync(listInfoInput);
        response.EnsureNoErrors();
        return response.Data?.GetInvoiceList;
    }

    public async Task<IGetInvoice_GetInvoice?> GetInvoiceByIdAsync(string id)
    {
        InvoiceIdentifierInput input = new InvoiceIdentifierInput()
        {
            InvoiceId = id
        };

        var response = await _superOpsGraphQlClient.GetInvoice.ExecuteAsync(input);
        response.EnsureNoErrors();

        return response.Data?.GetInvoice;
    }
}
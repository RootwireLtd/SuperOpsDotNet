using StrawberryShake;

namespace Rootwire.ApiClients.SuperOps.Services;

public class ServiceCatalogService
{
    private readonly ISuperOpsGraphQLClient _superOpsGraphQlClient;

    public ServiceCatalogService(ISuperOpsGraphQLClient superOpsGraphQlClient)
    {
        _superOpsGraphQlClient = superOpsGraphQlClient;
    }
    
    public async Task<IReadOnlyList<IGetServiceCategoryList_GetServiceCategoryList?>?> GetServiceCategoryListAsync()
    {
        var response = await _superOpsGraphQlClient.GetServiceCategoryList.ExecuteAsync();
        response.EnsureNoErrors();
        return response.Data?.GetServiceCategoryList;
    }

    public async Task<IGetServiceItemList_GetServiceItemList?> GetServiceItemListAsync(int pageNumber = 1, int pageSize = 50,
        RuleConditionInput? ruleConditionInput = null, IReadOnlyList<SortInput>? sortInput = null)
    {
        var listInfoInput = new ListInfoInput
        {
            Page = pageNumber,
            PageSize = pageSize,
            Condition = ruleConditionInput,
            Sort = sortInput
        };

        var response = await _superOpsGraphQlClient.GetServiceItemList.ExecuteAsync(listInfoInput);
        response.EnsureNoErrors();
        return response.Data?.GetServiceItemList;
    }
    
    public async Task<IGetServiceItem_GetServiceItem?> GetServiceItemByIdAsync(string id)
    {
        ServiceItemIdentifierInput input = new ServiceItemIdentifierInput()
        {
            ItemId = id
        };

        var response = await _superOpsGraphQlClient.GetServiceItem.ExecuteAsync(input);
        response.EnsureNoErrors();

        return response.Data?.GetServiceItem;
    }
}
using StrawberryShake;

namespace Rootwire.ApiClients.SuperOps.Services;

public class ClientService
{

    private readonly ISuperOpsGraphQLClient _superOpsGraphQlClient;
    
    public ClientService(ISuperOpsGraphQLClient superOpsGraphQlClient)
    {
        _superOpsGraphQlClient = superOpsGraphQlClient;
    }
    
    public async Task<IGetClientList_GetClientList?> GetClientListAsync(int pageNumber=1, int pageSize=50, RuleConditionInput? ruleConditionInput=null, IReadOnlyList<SortInput>? sortInput=null)
    {
        
        
        var listInfoInput = new ListInfoInput
        {
            Page = pageNumber,
            PageSize = pageSize,
            Condition = ruleConditionInput,
            Sort = sortInput
        };

        var response = await _superOpsGraphQlClient.GetClientList.ExecuteAsync(listInfoInput);
        response.EnsureNoErrors();
        return response.Data?.GetClientList;
    }

    public async Task<IGetClient_GetClient?> GetClientByIdAsync(string id)
    {
        ClientIdentifierInput input = new ClientIdentifierInput()
        {
            AccountId = id
        };

        var response = await _superOpsGraphQlClient.GetClient.ExecuteAsync(input);
        response.EnsureNoErrors();

        return response.Data?.GetClient;
    }
}
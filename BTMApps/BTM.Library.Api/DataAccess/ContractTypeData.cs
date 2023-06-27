using Btm.Api.Library.Internal.DataAccess;
using Btm.Api.Library.Models.Contracts;

namespace Btm.Api.Library.DataAccess;

public class ContractTypeData
{
    private string _spProductContractTypeGetAll = "sp_ContractType_Get_All";
    private string _defaultConnection = "DefaultConnection";
    private string _readonlyConnection = "ReadOnlyConnection";

    //public List<ContractType> GetContractTypes()
    //{
    //    SqlDataAccess sql = new SqlDataAccess();

    //    var p = new { };

    //    var output = sql.LoadData<ContractType, dynamic>(_spProductContractTypeGetAll, p, _readonlyConnection);

    //    return output;
    //}
}
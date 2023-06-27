namespace Btm.Web.Models.Contracts;

public class ContractType : IContractType
{
    public Guid Id { get; set; }
    public Guid ContractCategoryId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
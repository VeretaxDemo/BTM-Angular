namespace Btm.Web.Models.Contracts;

public interface IContractType
{
    Guid Id { get; set; }
    Guid ContractCategoryId { get; set; }
    string Title { get; set; }
    string Description { get; set; }
}
namespace Btm.Api.Library.Models.Contracts;

public class ContractCategory : IContractCategory
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string SpecialConsiderations { get; set; }

}
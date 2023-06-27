namespace Btm.Api.Library.Models.Contracts;

public interface IContractCategory
{
    Guid Id { get; set; }
    string Title { get; set; }
    string Description { get; set; }
    string SpecialConsiderations { get; set; }
}
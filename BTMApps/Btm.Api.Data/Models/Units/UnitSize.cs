namespace Btm.Api.Data.Models.Units;

public class UnitSize
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public UnitTechBase UnitTechBase { get; set; }

}
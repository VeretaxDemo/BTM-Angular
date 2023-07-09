namespace Btm.Api.Data.Models.Units;

public class UnitType
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public UnitTechBase TechBase { get; set; } = UnitTechBase.InnerSphere;


}
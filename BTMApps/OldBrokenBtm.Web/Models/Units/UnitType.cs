namespace Btm.Web.Models.Units;


public enum UnitTechBase
{
    Periphery = 0,
    InnerSphere = 1,
    Mercenary = 2,
    ComStar = 3,
    Clan = 4,
    WordOfBlake = 5,
    BtmMixedTech = 6,
    BtmCustom = 7
}

public class UnitType
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public UnitTechBase TechBase { get; set; } = UnitTechBase.InnerSphere;


}
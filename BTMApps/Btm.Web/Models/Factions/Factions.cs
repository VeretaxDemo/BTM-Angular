namespace Btm.Web.Models.Factions;

public enum MajorFactionCategory
{
    BanditKingdom,
    Pirates,
    DarkCaste,
    Rebels,
    Periphery,
    Independent,
    ChaosMarch,
    Corporation,
    GeneralPublic,
    TheNobility,
    InnerSphere,
    Mercenary,
    StarLeague,
    Clan,
    ComStar,
    WordOfBlake,

}

public interface IFactions
{
    Guid id { get; set; }
    string Name { get; set; }
    string Abbreviation { get; set; }
    string Description { get; set; }
    MajorFactionCategory MajorFactionCategory { get; set; }
}

public class Factions : IFactions
{
    public Guid id { get; set; }
    public string Name { get; set; }
    public string Abbreviation { get; set; }
    public string Description { get; set; }
    public MajorFactionCategory MajorFactionCategory { get; set; }

}
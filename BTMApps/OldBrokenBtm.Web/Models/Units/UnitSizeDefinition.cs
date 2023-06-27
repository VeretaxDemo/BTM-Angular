namespace Btm.Web.Models.Units;

public class UnitSizeDefinition
{
    public Guid Id { get; set; }
    public int MinimumUnitCount { get; set; }
    public int MaximumUnitCount { get; set; }
    public int MinimumTonnage { get; set; }
    public int MaximumTonnage { get; set; }
    public int MinimumBattleValue { get; set; }
    public int MaximumBattleValue { get; set; }
    public string MucoRankName { get; set; }
    public string MuxoRankName { get; set; }



}
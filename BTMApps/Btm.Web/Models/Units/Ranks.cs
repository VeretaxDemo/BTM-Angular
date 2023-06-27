namespace Btm.Web.Models.Units
{
    public enum InnerSphereRanksGeneric
    {
        Recruit,
        Private,
        Corporal,
        Sergeant,
        StaffSergeant,
        MasterSergeant,
        SergeantMajor,
        LieutenantJuniorGrade,
        LieutenantSeniorGrade,
        Captain,
        Major,
        Colonel,
        LieutenantGeneral,
        MajorGeneral,
        General,
        CommandingGeneral
    };

    public enum ClanRanksGeneric
    {
        Warrior,
        PointCommander,
        StarCommander,
        StarCaptain,
        StarColonel,
        GalaxyCommander,
        Khan
    };

    public enum ClanRanksNova
    {
        Warrior,
        PointCommander,
        NovaCommander,
        NovaCaptain,
        NovaColonel,
        GalaxyCommander,
        Khan

    }

    public enum InnerSphereRankClass
    {
        Enlisted,
        NonCommissionedOfficer,
        WarrantOfficer,
        JuniorOfficer,
        SeniorOfficer,
    }

    public enum ClanRankClass
    {
        Freeborn,
        Trueborn
    }

    public enum ClanCaste
    {
        DarkCaste,
        LaborerCaste,
        MerchantCaste,
        TechnicianCaste,
        ScientistCaste,
        WarriorCaste
    }

    public class Ranks
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }





    }
}

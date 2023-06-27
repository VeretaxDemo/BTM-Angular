namespace Btm.Web.Models.Contracts;

public class ContractPaymentDefinition
{
    public Guid Id { get; set; }
    public Guid ContractTypeId { get; set; }
    public int Months { get; set; }
    public int Days => Months * 30;
    public int BountyPerWord { get; set; }
    public int MinimumWordsCountTarget { get; set; }

    public int BonusSalvageBountyTarget { get; set; }

}
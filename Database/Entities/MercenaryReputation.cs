using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities;

[Table("MERCENARY_REPUTATIONS")]
public class MercenaryReputation
{
    public CrimeSyndicate? CrimeSyndicate { get; set; }
    
    [Column("SyndicateId"), Required]
    public int SyndicateId { get; set; }
    
    public Mercenary? Mercenary { get; set; }
    
    [Column("MercenaryId"), Required]
    public int MercenaryId { get; set; }
    
    [Column("ReputationChange"), Required, MaxLength(45)]
    public string? ReputationChange {get; set; }
}
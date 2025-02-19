using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities;

[Table("CRIME_SYNDICATES")]
public class CrimeSyndicate
{
    [Column("SyndicateId"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SyndicateId { get; set; }
    
    [Column("Name"), Required, MaxLength(45)]
    public string? Name { get; set; }
    
    [Column("Location"), Required, MaxLength(45)]
    public string? Location { get; set; }
}
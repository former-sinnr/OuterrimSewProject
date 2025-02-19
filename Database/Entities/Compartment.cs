using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities;

[Table("COMPARTMENTS")]
public class Compartment
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("CompartmentId")]
    public int CompartmentId { get; set; }
    
    public Aircraft? Aircraft { get; set; }
    
    [Column("AircraftId"), Required]
    public int AircraftId { get; set; }
    
    public ICollection<Machinery>? Machineries { get; set; }
}
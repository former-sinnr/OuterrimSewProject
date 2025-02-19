using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities;

[Table("AIRCRAFT_SPECIFICATIONS")]
public class AircraftSpecification
{
    [Key, Column("SpecificationId"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SpecificationId { get; set; }
    
    [Column("Structure"), Required]
    public int Structure { get; set; }
    
    [Column("FuelTankCapacity"), Required]
    public int FuelTankCapacity { get; set; }
    public int MinSpeed { get; set; }
    
    [Column("MaxSpeed"), Required]
    public int MaxSpeed { get; set; }
    
    [Column("MaxAltitude"), Required]
    public int MaxAltitude { get; set; }
    
    [Column("SpecificationCode"), Required, MaxLength(45)]
    public string? SpecificationCode { get; set; }
}
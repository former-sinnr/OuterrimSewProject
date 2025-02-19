using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities;

[Table("MACHINERIES")]
public class Machinery
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("MachineId")]
    public int MachineryId { get; set; }
    
    [Column("Label"), Required]
    public string? Label { get; set; }
    
    [Column("Function"), Required]
    public string? Function { get; set; }
    
    public Compartment? Compartment { get; set; }
    
    [Column("CompartmentId"), Required]
    public int? CompartmentId { get; set; }
}

public class Weapon: Machinery {}
public class EnergySystem: Machinery {}
public class EnvironmentalSystem: Machinery {}
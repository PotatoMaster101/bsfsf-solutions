using System.ComponentModel.DataAnnotations;

namespace Section06.Models;

public class MilkshakeModel
{
    public bool AddCream { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 1)]
    public string Name { get; set; } = default!;

    [Range(1, 100)]
    public int Quantity { get; set; } = 1;

    public MilkshakeSize Size { get; set; } = MilkshakeSize.Medium;

    [Required]
    public MilkshakeType Type { get; set; } = default!;
}

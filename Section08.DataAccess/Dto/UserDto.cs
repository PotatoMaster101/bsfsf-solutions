using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Section08.DataAccess.Dto;

[Table("User")]
public class UserDto
{
    [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public required int Id { get; set; }

    [Required, MaxLength(255)]
    public required string FirstName { get; set; }

    [Required, MaxLength(255)]
    public required string LastName { get; set; }

    [Required]
    public required DateTime DateOfBirth { get; set; }
}

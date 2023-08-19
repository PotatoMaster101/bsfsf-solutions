using System.ComponentModel.DataAnnotations;

namespace Section08.Models;

public class User
{
    private DateTime _dateOfBirth = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);

    public int Id { get; set; }

    [Required, MaxLength(255)]
    public string FirstName { get; set; } = default!;

    [Required, MaxLength(255)]
    public string LastName { get; set; } = default!;

    [Required]
    public DateTime DateOfBirth
    {
        get => _dateOfBirth;
        set => _dateOfBirth = DateTime.SpecifyKind(value, DateTimeKind.Utc);    // postgres only accepts UTC datetime
    }

    public string FullName => $"{FirstName} {LastName}";

    public User Clone(bool copyId = true)
    {
        return new User
        {
            Id = copyId ? Id : 0,
            FirstName = FirstName,
            LastName = LastName,
            DateOfBirth = DateOfBirth
        };
    }
}

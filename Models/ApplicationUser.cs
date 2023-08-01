using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace JWT.Models;

public class ApplicationUser : IdentityUser<Guid>
{
    [Required, MaxLength(50)]
    public string FirstName { get; set; }
    [Required, MaxLength(50)]
    public string LastName { get; set; }
}
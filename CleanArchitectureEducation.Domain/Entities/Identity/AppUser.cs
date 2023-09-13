using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitectureEducation.Domain.Entities.Identity;

public sealed class AppUser : IdentityUser<string>
{
    [Column(TypeName = "varchar(100)")]
    public string NameLastName { get; set; }
    public bool IsActive { get; set; }
}

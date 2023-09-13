using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitectureEducation.Domain.Entities.Identity;

public sealed class AppRole : IdentityRole<string>
{
    [NotMapped]
    public override string? ConcurrencyStamp { get; set; }
}

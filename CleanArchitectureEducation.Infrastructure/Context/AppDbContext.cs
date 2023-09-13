using CleanArchitectureEducation.Domain.Entities;
using CleanArchitectureEducation.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureEducation.Infrastructure.Context;

public sealed class AppDbContext : IdentityDbContext<AppUser,AppRole,string>
{
    public AppDbContext(DbContextOptions options): base(options)
    {
    }

    public DbSet<AppUser> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}

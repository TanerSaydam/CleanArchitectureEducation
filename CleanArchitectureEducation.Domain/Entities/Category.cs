using CleanArchitectureEducation.Domain.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitectureEducation.Domain.Entities;

public sealed class Category : Entity
{
    public Category()
    {
    }

    public Category(string name, string description)
    {
        Name = name;
        Description = description;        
    }

    [Column(TypeName = "varchar(100)")]
    public string Name { get; set; }

    [Column(TypeName = "varchar(200)")]
    public string Description { get; set; }
    public ICollection<Product> Products { get; set; }
}
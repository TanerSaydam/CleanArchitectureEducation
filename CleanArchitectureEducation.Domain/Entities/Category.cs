using CleanArchitectureEducation.Domain.Abstractions;

namespace CleanArchitectureEducation.Domain.Entities;

public sealed class Category : Entity
{
    public Category()
    {
        IsDeleted = false;
        IsActive = true;
    }

    public Category(string name, string description)
    {
        Name = name;
        Description = description;
        IsDeleted = false;
        IsActive = true;
    }
    public string Name { get; set; }
    public string Description { get; set; }
}
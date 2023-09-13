using CleanArchitectureEducation.Domain.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArchitectureEducation.Domain.Entities;

public sealed class Product : Entity
{
    public Product()
    {       
    }

    public Product(string name, string description, decimal price, int quantity, string ımageUrl, string categoryId)
    {
        Name = name;
        Description = description;
        Price = price;
        Quantity = quantity;
        ImageUrl = ımageUrl;
        CategoryId = categoryId;       
    }

    [Column(TypeName ="varchar(100)")]
    public string Name { get; set; }

    [Column(TypeName = "varchar(200)")]
    public string Description { get; set; }

    [Column(TypeName ="money")]
    public decimal Price { get; set; }

    [MaxLength(999)]
    public int Quantity { get; set; }

    [Column(TypeName = "varchar(200)")]
    public string ImageUrl { get; set; }

    [ForeignKey("Category")]
    public string CategoryId { get; set; }
    public Category Category { get; set; }
}

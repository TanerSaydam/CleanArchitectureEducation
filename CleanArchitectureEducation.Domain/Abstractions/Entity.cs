namespace CleanArchitectureEducation.Domain.Abstractions;

public abstract class Entity
{
    public Entity()
    {
        Id = Ulid.NewUlid().ToString();
        IsActive = true;
        IsDeleted = false;
        CreatedDate = DateTime.Now;
    }
    public string Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsCreated { get; set; }
}

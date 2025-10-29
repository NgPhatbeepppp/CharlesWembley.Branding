namespace Cw.Domain.Entities;

public class Product
{
    public long Id { get; set; }
    public long? CoverImageId { get; set; }
    public long? PdfMediaId { get; set; }
    public bool IsPublished { get; set; } = true;
    public DateTime? PublishedAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public Guid? UpdatedBy { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }
    public Guid? DeletedBy { get; set; }

    public ICollection<ProductTranslation> Translations { get; set; } = new List<ProductTranslation>();
}

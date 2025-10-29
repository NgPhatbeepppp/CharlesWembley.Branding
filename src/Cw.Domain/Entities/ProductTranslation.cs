namespace Cw.Domain.Entities;

public class ProductTranslation
{
    public long ProductId { get; set; }
    public string LanguageCode { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Slug { get; set; } = default!;
    public string? ShortDescription { get; set; }
    public string? Specifications { get; set; }
    public string? MetaTitle { get; set; }
    public string? MetaDescription { get; set; }

    public Product Product { get; set; } = default!;
    public Language Language { get; set; } = default!;
}

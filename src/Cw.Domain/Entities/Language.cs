namespace Cw.Domain.Entities;

public class Language
{
    public string LanguageCode { get; set; } = default!;
    public string Name { get; set; } = default!;

    public ICollection<ProductTranslation> ProductTranslations { get; set; } = new List<ProductTranslation>();
}

namespace Cw.Domain.Entities
{
    public class ProductCategoryTranslation
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public string LanguageCode { get; set; } = null!;

        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string? Summary { get; set; }
        public string? MetaTitle { get; set; }
        public string? MetaDescription { get; set; }
    }
}

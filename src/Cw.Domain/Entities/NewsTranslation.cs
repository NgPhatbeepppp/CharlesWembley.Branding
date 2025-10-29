namespace Cw.Domain.Entities
{
    public class NewsTranslation
    {
        public long Id { get; set; }
        public long NewsId { get; set; }
        public string LanguageCode { get; set; } = null!;

        public string Title { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string? Excerpt { get; set; }
        public string? BodyHtml { get; set; }
        public string? MetaTitle { get; set; }
        public string? MetaDescription { get; set; }
    }
}

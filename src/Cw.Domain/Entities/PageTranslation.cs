namespace Cw.Domain.Entities
{
    public class PageTranslation
    {
        public long Id { get; set; }
        public long PageId { get; set; }
        public string LanguageCode { get; set; } = null!;

        public string Title { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string? Summary { get; set; }
        public string? MetaTitle { get; set; }
        public string? MetaDescription { get; set; }
        public string? ContentHtml { get; set; }
    }
}

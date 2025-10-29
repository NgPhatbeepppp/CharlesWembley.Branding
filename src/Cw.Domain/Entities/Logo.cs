namespace Cw.Domain.Entities
{
    public class Logo
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? LinkUrl { get; set; }
        public int SortOrder { get; set; }

        public long? MediaId { get; set; }
    }
}

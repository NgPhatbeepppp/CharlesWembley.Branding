namespace Cw.Domain.Entities
{
    public class ProductMedia
    {
        public long ProductId { get; set; }
        public long MediaId { get; set; }
        public bool IsCover { get; set; }
        public int SortOrder { get; set; }
    }
}

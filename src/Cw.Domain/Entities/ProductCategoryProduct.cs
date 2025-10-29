namespace Cw.Domain.Entities
{
    public class ProductCategoryProduct
    {
        public long ProductId { get; set; }
        public long CategoryId { get; set; }
        public int SortOrder { get; set; }
    }
}

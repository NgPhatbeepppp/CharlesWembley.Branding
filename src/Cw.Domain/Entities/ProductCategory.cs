namespace Cw.Domain.Entities
{
    public class ProductCategory
    {
        public long Id { get; set; }
        public long? ParentId { get; set; }
        public long? IconMediaId { get; set; }

        // Soft-delete & audit (simple form to avoid base-class dependency)
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

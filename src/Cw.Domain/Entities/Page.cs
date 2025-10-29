namespace Cw.Domain.Entities
{
    public class Page
    {
        public long Id { get; set; }
        public string Code { get; set; } = null!;

        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

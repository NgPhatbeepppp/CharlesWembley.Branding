namespace Cw.Domain.Entities
{
    public class News
    {
        public long Id { get; set; }
        public DateTime? PublishAt { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

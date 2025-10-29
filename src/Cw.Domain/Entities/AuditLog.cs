namespace Cw.Domain.Entities
{
    public class AuditLog
    {
        public long Id { get; set; }
        public string? Event { get; set; }
        public string? Actor { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? DataJson { get; set; }
    }
}

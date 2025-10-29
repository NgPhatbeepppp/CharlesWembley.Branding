namespace Cw.Domain.Entities
{
    public class Contact
    {
        public long Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Message { get; set; }
        public string? IpAddress { get; set; }
        public bool Processed { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

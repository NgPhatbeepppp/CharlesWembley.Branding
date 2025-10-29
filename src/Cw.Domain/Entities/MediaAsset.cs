namespace Cw.Domain.Entities
{
    public class MediaAsset
    {
        public long Id { get; set; }
        public string FileName { get; set; } = null!;
        public string StoragePath { get; set; } = null!;
        public string? ContentType { get; set; }
        public string? Hash { get; set; }
        public long SizeBytes { get; set; }
    }
}

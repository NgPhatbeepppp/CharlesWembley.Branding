namespace Cw.Domain.Entities
{
    public class SettingTranslation
    {
        public long Id { get; set; }
        public long SettingId { get; set; }
        public string LanguageCode { get; set; } = null!;
        public string? Value { get; set; }
    }
}

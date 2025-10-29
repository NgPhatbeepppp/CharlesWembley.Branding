using Microsoft.EntityFrameworkCore;
using Cw.Domain.Entities;

namespace Cw.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public const string Schema = "cms";
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ProductTranslation> ProductTranslations => Set<ProductTranslation>();
        public DbSet<Language> Languages => Set<Language>();

        
        public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();
        public DbSet<ProductCategoryTranslation> ProductCategoryTranslations => Set<ProductCategoryTranslation>();
        public DbSet<ProductCategoryProduct> ProductCategoryProducts => Set<ProductCategoryProduct>();
        public DbSet<MediaAsset> MediaAssets => Set<MediaAsset>();
        public DbSet<ProductMedia> ProductMedia => Set<ProductMedia>();
        public DbSet<Page> Pages => Set<Page>();
        public DbSet<PageTranslation> PageTranslations => Set<PageTranslation>();
        public DbSet<News> News => Set<News>();
        public DbSet<NewsTranslation> NewsTranslations => Set<NewsTranslation>();
        public DbSet<Setting> Settings => Set<Setting>();
        public DbSet<SettingTranslation> SettingTranslations => Set<SettingTranslation>();
        public DbSet<Logo> Logos => Set<Logo>();
        public DbSet<Contact> Contacts => Set<Contact>();
        public DbSet<AuditLog> AuditLogs => Set<AuditLog>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace GNW_Bazzar.Entity
{
    public class GNW_BazaarDbContext(DbContextOptions<GNW_BazaarDbContext> options) : DbContext(options)
    {
        public DbSet<HealthCareCategory> HealthCareCategories { get; set; }
        public DbSet<CategoryMaster> CategoryMasters { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Otp> Otps { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<SubCategoryMaster> SubCategoryMasters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubCategoryMaster>()
                .ToTable("SubCategoryMasters");
        }
    }
}

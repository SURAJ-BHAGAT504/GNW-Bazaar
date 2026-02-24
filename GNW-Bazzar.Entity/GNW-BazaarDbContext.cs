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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryMaster>().HasData(
                new CategoryMaster
                {
                    Id = 1,
                    CategoryName = "Health Care",
                    Description = "Health Care related services",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new CategoryMaster
                {
                    Id = 2,
                    CategoryName = "Food",
                    Description = "",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new CategoryMaster
                {
                    Id = 3,
                    CategoryName = "Shopping",
                    Description = "",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new CategoryMaster
                {
                    Id = 4,
                    CategoryName = "Makeovers",
                    Description = "",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new CategoryMaster
                {
                    Id = 5,
                    CategoryName = "Events",
                    Description = "",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new CategoryMaster
                {
                    Id = 6,
                    CategoryName = "Travel",
                    Description = "",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new CategoryMaster
                {
                    Id = 7,
                    CategoryName = "Homecare",
                    Description = "",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new CategoryMaster
                {
                    Id = 8,
                    CategoryName = "Property",
                    Description = "",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new CategoryMaster
                {
                    Id = 9,
                    CategoryName = "Astrology",
                    Description = "",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new CategoryMaster
                {
                    Id = 10,
                    CategoryName = "Education",
                    Description = "",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new CategoryMaster
                {
                    Id = 11,
                    CategoryName = "FitLife",
                    Description = "",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new CategoryMaster
                {
                    Id = 12,
                    CategoryName = "Pets",
                    Description = "",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new CategoryMaster
                {
                    Id = 13,
                    CategoryName = "Relocation",
                    Description = "",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new CategoryMaster
                {
                    Id = 14,
                    CategoryName = "Finance",
                    Description = "",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new CategoryMaster
                {
                    Id = 15,
                    CategoryName = "Security",
                    Description = "",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new CategoryMaster
                {
                    Id = 16,
                    CategoryName = "Service",
                    Description = "",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                }
            );

            modelBuilder.Entity<HealthCareCategory>().HasData(
                new HealthCareCategory
                {
                    Id = 1,
                    Category = "Anaesthesiology",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 2,
                    Category = "Cardiology",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 3,
                    Category = "Critical Care",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 4,
                    Category = "Dentistry",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 5,
                    Category = "Dermatology",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 6,
                    Category = "Endocrinology",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 7,
                    Category = "ENT",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 8,
                    Category = "Gastroenterology",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 9,
                    Category = "General Physician",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 10,
                    Category = "General Surgery",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 11,
                    Category = "Geriatrics",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 12,
                    Category = "Gynecology & Obstetrics",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 13,
                    Category = "Hematology",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 14,
                    Category = "Hepatology",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 15,
                    Category = "Immunology",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 16,
                    Category = "Infectious Diseases",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 17,
                    Category = "Internal Medicine",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 18,
                    Category = "Interventional Spine & Pain Medicine",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 19,
                    Category = "IVF",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 20,
                    Category = "Nephrology",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 21,
                    Category = "Neurology",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 22,
                    Category = "Nuclear Medicine",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 23,
                    Category = "Nutrition & Health",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 24,
                    Category = "Oncology",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 25,
                    Category = "Ophthalmology",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 26,
                    Category = "Orthopedics",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 27,
                    Category = "Pathology & Laboratory Medicine",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 28,
                    Category = "Pediatrics",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 29,
                    Category = "Physiotherapy & Rehabilitation",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 30,
                    Category = "Plastic & Reconstructive Surgery",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 31,
                    Category = "Psychology & Psychiatry",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 32,
                    Category = "Pulmonology",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 33,
                    Category = "Radiology",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 34,
                    Category = "Rheumatology",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 35,
                    Category = "Robotic Surgery",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 36,
                    Category = "Urology",
                    CategoryMasterId = 1,
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                }
            );
        }
    }
}

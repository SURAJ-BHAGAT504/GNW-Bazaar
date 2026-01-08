using Microsoft.EntityFrameworkCore;

namespace GNW_Bazzar.Entity
{
    public class GNW_BazaarDbContext(DbContextOptions<GNW_BazaarDbContext> options) : DbContext(options)
    {
        public DbSet<HealthCareCategory> HealthCareCategories { get; set; }
        public DbSet<HealthCareSubCategory> HealthCareSubCategories { get; set; }
        public DbSet<CategoryMaster> CategoryMasters { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Otp> Otps { get; set; }

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

            modelBuilder.Entity<HealthCareSubCategory>().HasData(
                new HealthCareSubCategory
                {
                    Id = 1,
                    SubCategory = "Heart",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 2
                },
                new HealthCareSubCategory
                {
                    Id = 2,
                    SubCategory = "Hormones",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 6
                },
                new HealthCareSubCategory
                {
                    Id = 3,
                    SubCategory = "Diabetes",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 6
                },
                new HealthCareSubCategory
                {
                    Id = 4,
                    SubCategory = "Thyroid",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 6
                },
                new HealthCareSubCategory
                {
                    Id = 5,
                    SubCategory = "Ear",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 7
                },
                new HealthCareSubCategory
                {
                    Id = 6,
                    SubCategory = "Nose",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 7
                },
                new HealthCareSubCategory
                {
                    Id = 7,
                    SubCategory = "Throat",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 7
                },
                new HealthCareSubCategory
                {
                    Id = 8,
                    SubCategory = "Digestive System",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 8
                },
                new HealthCareSubCategory
                {
                    Id = 9,
                    SubCategory = "Family Medicine",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 9
                },
                new HealthCareSubCategory
                {
                    Id = 10,
                    SubCategory = "Elderly Care",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 11
                },
                new HealthCareSubCategory
                {
                    Id = 11,
                    SubCategory = "Blood",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 13
                },
                new HealthCareSubCategory
                {
                    Id = 12,
                    SubCategory = "Liver",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 14
                },
                new HealthCareSubCategory
                {
                    Id = 13,
                    SubCategory = "Allergies",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 15
                },
                new HealthCareSubCategory
                {
                    Id = 14,
                    SubCategory = "Immune Disorders",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 15
                },
                new HealthCareSubCategory
                {
                    Id = 15,
                    SubCategory = "Kidneys",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 20
                },
                new HealthCareSubCategory
                {
                    Id = 16,
                    SubCategory = "Brain",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 21
                },
                new HealthCareSubCategory
                {
                    Id = 17,
                    SubCategory = "Nervous System",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 21
                },
                new HealthCareSubCategory
                {
                    Id = 18,
                    SubCategory = "Cancer",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 24
                },
                new HealthCareSubCategory
                {
                    Id = 19,
                    SubCategory = "Bone Marrow Transplant",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 24
                },
                new HealthCareSubCategory
                {
                    Id = 20,
                    SubCategory = "Cancer Care",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 24
                },
                new HealthCareSubCategory
                {
                    Id = 21,
                    SubCategory = "Eye Surgery",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 25
                },
                new HealthCareSubCategory
                {
                    Id = 22,
                    SubCategory = "Bones",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 26
                },
                new HealthCareSubCategory
                {
                    Id = 23,
                    SubCategory = "Joints",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 26
                },
                new HealthCareSubCategory
                {
                    Id = 24,
                    SubCategory = "Lungs",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 32
                },
                new HealthCareSubCategory
                {
                    Id = 25,
                    SubCategory = "Joints",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 34
                },
                new HealthCareSubCategory
                {
                    Id = 26,
                    SubCategory = "Arthritis",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 34
                },
                new HealthCareSubCategory
                {
                    Id = 27,
                    SubCategory = "Autoimmune",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 34
                },
                new HealthCareSubCategory
                {
                    Id = 28,
                    SubCategory = "Urinary Tract",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 36
                },
                new HealthCareSubCategory
                {
                    Id = 29,
                    SubCategory = "Male Reproductive",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null,
                    HealthCareCategoryId = 36
                }
            );
        }
    }
}

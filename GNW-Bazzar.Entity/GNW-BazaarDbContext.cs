using Microsoft.EntityFrameworkCore;

namespace GNW_Bazzar.Entity
{
    public class GNW_BazaarDbContext(DbContextOptions<GNW_BazaarDbContext> options) : DbContext(options)
    {
        public DbSet<HealthCareCategory> HealthCareCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HealthCareCategory>().HasData(
                new HealthCareCategory
                {
                    Id = 1,
                    Category = "Anaesthesiology",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 2,
                    Category = "Cardiology",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 3,
                    Category = "Critical Care",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 4,
                    Category = "Dentistry",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 5,
                    Category = "Dermatology",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 6,
                    Category = "Endocrinology",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 7,
                    Category = "ENT",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 8,
                    Category = "Gastroenterology",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 9,
                    Category = "General Physician",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 10,
                    Category = "General Surgery",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 11,
                    Category = "Geriatrics",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 12,
                    Category = "Gynecology & Obstetrics",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 13,
                    Category = "Hematology",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 14,
                    Category = "Hepatology",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 15,
                    Category = "Immunology",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 16,
                    Category = "Infectious Diseases",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 17,
                    Category = "Internal Medicine",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 18,
                    Category = "Interventional Spine & Pain Medicine",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 19,
                    Category = "IVF",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 20,
                    Category = "Nephrology",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 21,
                    Category = "Neurology",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 22,
                    Category = "Nuclear Medicine",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 23,
                    Category = "Nutrition & Health",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 24,
                    Category = "Oncology",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 25,
                    Category = "Ophthalmology",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 26,
                    Category = "Orthopedics",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 27,
                    Category = "Pathology & Laboratory Medicine",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 28,
                    Category = "Pediatrics",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 29,
                    Category = "Physiotherapy & Rehabilitation",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 30,
                    Category = "Plastic & Reconstructive Surgery",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 31,
                    Category = "Psychology & Psychiatry",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 32,
                    Category = "Pulmonology",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 33,
                    Category = "Radiology",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 34,
                    Category = "Rheumatology",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 35,
                    Category = "Robotic Surgery",
                    CreatedOn = DateTime.UtcNow,
                    UpdatedOn = null
                },
                new HealthCareCategory
                {
                    Id = 36,
                    Category = "Urology",
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

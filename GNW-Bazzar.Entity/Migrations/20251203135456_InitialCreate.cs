using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GNW_Bazzar.Entity.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryMasters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryMasterId = table.Column<long>(type: "bigint", nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_CategoryMasters_CategoryMasterId",
                        column: x => x.CategoryMasterId,
                        principalTable: "CategoryMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthCareCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryMasterId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCareCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthCareCategories_CategoryMasters_CategoryMasterId",
                        column: x => x.CategoryMasterId,
                        principalTable: "CategoryMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Otps",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtpCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiresOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    Attempts = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Otps_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthCareSubCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HealthCareCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCareSubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthCareSubCategories_HealthCareCategories_HealthCareCategoryId",
                        column: x => x.HealthCareCategoryId,
                        principalTable: "HealthCareCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HealthCareSubCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutDoctor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<long>(type: "bigint", nullable: false),
                    Phonenumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_HealthCareSubCategories_HealthCareSubCategoryId",
                        column: x => x.HealthCareSubCategoryId,
                        principalTable: "HealthCareSubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategoryMasters",
                columns: new[] { "Id", "CategoryName", "CreatedOn", "Description", "IsActive", "UpdatedOn" },
                values: new object[,]
                {
                    { 1L, "Health Care", new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5352), "Health Care related services", false, null },
                    { 2L, "Food", new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5360), "", false, null },
                    { 3L, "Shopping", new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5362), "", false, null },
                    { 4L, "Makeovers", new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5364), "", false, null },
                    { 5L, "Events", new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5366), "", false, null },
                    { 6L, "Travel", new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5368), "", false, null },
                    { 7L, "Homecare", new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5369), "", false, null },
                    { 8L, "Property", new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5371), "", false, null },
                    { 9L, "Astrology", new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5373), "", false, null },
                    { 10L, "Education", new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5375), "", false, null },
                    { 11L, "FitLife", new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5377), "", false, null },
                    { 12L, "Pets", new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5378), "", false, null },
                    { 13L, "Relocation", new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5380), "", false, null },
                    { 14L, "Finance", new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5381), "", false, null },
                    { 15L, "Security", new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5383), "", false, null },
                    { 16L, "Service", new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5385), "", false, null }
                });

            migrationBuilder.InsertData(
                table: "HealthCareCategories",
                columns: new[] { "Id", "Category", "CategoryMasterId", "CreatedOn", "UpdatedOn" },
                values: new object[,]
                {
                    { 1L, "Anaesthesiology", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5652), null },
                    { 2L, "Cardiology", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5655), null },
                    { 3L, "Critical Care", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5657), null },
                    { 4L, "Dentistry", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5658), null },
                    { 5L, "Dermatology", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5660), null },
                    { 6L, "Endocrinology", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5662), null },
                    { 7L, "ENT", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5664), null },
                    { 8L, "Gastroenterology", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5665), null },
                    { 9L, "General Physician", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5667), null },
                    { 10L, "General Surgery", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5669), null },
                    { 11L, "Geriatrics", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5670), null },
                    { 12L, "Gynecology & Obstetrics", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5672), null },
                    { 13L, "Hematology", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5673), null },
                    { 14L, "Hepatology", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5675), null },
                    { 15L, "Immunology", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5677), null },
                    { 16L, "Infectious Diseases", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5678), null },
                    { 17L, "Internal Medicine", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5680), null },
                    { 18L, "Interventional Spine & Pain Medicine", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5681), null },
                    { 19L, "IVF", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5683), null },
                    { 20L, "Nephrology", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5684), null },
                    { 21L, "Neurology", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5686), null },
                    { 22L, "Nuclear Medicine", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5687), null },
                    { 23L, "Nutrition & Health", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5689), null },
                    { 24L, "Oncology", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5691), null },
                    { 25L, "Ophthalmology", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5692), null },
                    { 26L, "Orthopedics", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5694), null },
                    { 27L, "Pathology & Laboratory Medicine", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5697), null },
                    { 28L, "Pediatrics", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5698), null },
                    { 29L, "Physiotherapy & Rehabilitation", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5700), null },
                    { 30L, "Plastic & Reconstructive Surgery", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5701), null },
                    { 31L, "Psychology & Psychiatry", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5703), null },
                    { 32L, "Pulmonology", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5704), null },
                    { 33L, "Radiology", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5706), null },
                    { 34L, "Rheumatology", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5707), null },
                    { 35L, "Robotic Surgery", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5709), null },
                    { 36L, "Urology", 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5711), null }
                });

            migrationBuilder.InsertData(
                table: "HealthCareSubCategories",
                columns: new[] { "Id", "CreatedOn", "HealthCareCategoryId", "SubCategory", "UpdatedOn" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5781), 2L, "Heart", null },
                    { 2L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5784), 6L, "Hormones", null },
                    { 3L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5786), 6L, "Diabetes", null },
                    { 4L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5788), 6L, "Thyroid", null },
                    { 5L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5790), 7L, "Ear", null },
                    { 6L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5792), 7L, "Nose", null },
                    { 7L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5794), 7L, "Throat", null },
                    { 8L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5797), 8L, "Digestive System", null },
                    { 9L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5799), 9L, "Family Medicine", null },
                    { 10L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5800), 11L, "Elderly Care", null },
                    { 11L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5802), 13L, "Blood", null },
                    { 12L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5804), 14L, "Liver", null },
                    { 13L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5805), 15L, "Allergies", null },
                    { 14L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5807), 15L, "Immune Disorders", null },
                    { 15L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5808), 20L, "Kidneys", null },
                    { 16L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5810), 21L, "Brain", null },
                    { 17L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5812), 21L, "Nervous System", null },
                    { 18L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5814), 24L, "Cancer", null },
                    { 19L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5816), 24L, "Bone Marrow Transplant", null },
                    { 20L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5817), 24L, "Cancer Care", null },
                    { 21L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5819), 25L, "Eye Surgery", null },
                    { 22L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5820), 26L, "Bones", null },
                    { 23L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5822), 26L, "Joints", null },
                    { 24L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5823), 32L, "Lungs", null },
                    { 25L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5825), 34L, "Joints", null },
                    { 26L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5826), 34L, "Arthritis", null },
                    { 27L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5828), 34L, "Autoimmune", null },
                    { 28L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5829), 36L, "Urinary Tract", null },
                    { 29L, new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5831), 36L, "Male Reproductive", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CategoryMasterId",
                table: "Clients",
                column: "CategoryMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_HealthCareSubCategoryId",
                table: "Doctors",
                column: "HealthCareSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCareCategories_CategoryMasterId",
                table: "HealthCareCategories",
                column: "CategoryMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCareSubCategories_HealthCareCategoryId",
                table: "HealthCareSubCategories",
                column: "HealthCareCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Otps_UserId",
                table: "Otps",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Otps");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "HealthCareSubCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "HealthCareCategories");

            migrationBuilder.DropTable(
                name: "CategoryMasters");
        }
    }
}

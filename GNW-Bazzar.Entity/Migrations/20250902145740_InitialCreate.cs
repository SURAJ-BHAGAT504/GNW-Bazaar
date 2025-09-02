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
                name: "HealthCareCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCareCategories", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "HealthCareCategories",
                columns: new[] { "Id", "Category", "CreatedOn", "UpdatedOn" },
                values: new object[,]
                {
                    { 1L, "Anaesthesiology", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5817), null },
                    { 2L, "Cardiology", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5827), null },
                    { 3L, "Critical Care", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5829), null },
                    { 4L, "Dentistry", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5831), null },
                    { 5L, "Dermatology", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5833), null },
                    { 6L, "Endocrinology", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5835), null },
                    { 7L, "ENT", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5837), null },
                    { 8L, "Gastroenterology", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5839), null },
                    { 9L, "General Physician", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5841), null },
                    { 10L, "General Surgery", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5843), null },
                    { 11L, "Geriatrics", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5845), null },
                    { 12L, "Gynecology & Obstetrics", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5847), null },
                    { 13L, "Hematology", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5849), null },
                    { 14L, "Hepatology", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5851), null },
                    { 15L, "Immunology", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5853), null },
                    { 16L, "Infectious Diseases", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5855), null },
                    { 17L, "Internal Medicine", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5857), null },
                    { 18L, "Interventional Spine & Pain Medicine", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5859), null },
                    { 19L, "IVF", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5861), null },
                    { 20L, "Nephrology", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5863), null },
                    { 21L, "Neurology", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5864), null },
                    { 22L, "Nuclear Medicine", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5866), null },
                    { 23L, "Nutrition & Health", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5868), null },
                    { 24L, "Oncology", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5870), null },
                    { 25L, "Ophthalmology", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5872), null },
                    { 26L, "Orthopedics", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5873), null },
                    { 27L, "Pathology & Laboratory Medicine", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5875), null },
                    { 28L, "Pediatrics", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5877), null },
                    { 29L, "Physiotherapy & Rehabilitation", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5879), null },
                    { 30L, "Plastic & Reconstructive Surgery", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5881), null },
                    { 31L, "Psychology & Psychiatry", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5883), null },
                    { 32L, "Pulmonology", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5885), null },
                    { 33L, "Radiology", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5887), null },
                    { 34L, "Rheumatology", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5889), null },
                    { 35L, "Robotic Surgery", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5891), null },
                    { 36L, "Urology", new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(5920), null }
                });

            migrationBuilder.InsertData(
                table: "HealthCareSubCategories",
                columns: new[] { "Id", "CreatedOn", "HealthCareCategoryId", "SubCategory", "UpdatedOn" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6327), 2L, "Heart", null },
                    { 2L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6332), 6L, "Hormones", null },
                    { 3L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6335), 6L, "Diabetes", null },
                    { 4L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6337), 6L, "Thyroid", null },
                    { 5L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6339), 7L, "Ear", null },
                    { 6L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6341), 7L, "Nose", null },
                    { 7L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6343), 7L, "Throat", null },
                    { 8L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6345), 8L, "Digestive System", null },
                    { 9L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6347), 9L, "Family Medicine", null },
                    { 10L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6350), 11L, "Elderly Care", null },
                    { 11L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6352), 13L, "Blood", null },
                    { 12L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6355), 14L, "Liver", null },
                    { 13L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6357), 15L, "Allergies", null },
                    { 14L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6359), 15L, "Immune Disorders", null },
                    { 15L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6361), 20L, "Kidneys", null },
                    { 16L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6363), 21L, "Brain", null },
                    { 17L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6365), 21L, "Nervous System", null },
                    { 18L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6367), 24L, "Cancer", null },
                    { 19L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6369), 24L, "Bone Marrow Transplant", null },
                    { 20L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6371), 24L, "Cancer Care", null },
                    { 21L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6373), 25L, "Eye Surgery", null },
                    { 22L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6376), 26L, "Bones", null },
                    { 23L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6378), 26L, "Joints", null },
                    { 24L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6380), 32L, "Lungs", null },
                    { 25L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6382), 34L, "Joints", null },
                    { 26L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6384), 34L, "Arthritis", null },
                    { 27L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6386), 34L, "Autoimmune", null },
                    { 28L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6388), 36L, "Urinary Tract", null },
                    { 29L, new DateTime(2025, 9, 2, 14, 57, 39, 92, DateTimeKind.Utc).AddTicks(6390), 36L, "Male Reproductive", null }
                });

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
                name: "HealthCareSubCategories");

            migrationBuilder.DropTable(
                name: "Otps");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "HealthCareCategories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

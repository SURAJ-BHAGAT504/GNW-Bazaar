using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GNW_Bazzar.Entity.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { 1L, "Anaesthesiology", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2817), null },
                    { 2L, "Cardiology", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2824), null },
                    { 3L, "Critical Care", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2826), null },
                    { 4L, "Dentistry", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2828), null },
                    { 5L, "Dermatology", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2830), null },
                    { 6L, "Endocrinology", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2831), null },
                    { 7L, "ENT", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2833), null },
                    { 8L, "Gastroenterology", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2835), null },
                    { 9L, "General Physician", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2836), null },
                    { 10L, "General Surgery", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2838), null },
                    { 11L, "Geriatrics", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2840), null },
                    { 12L, "Gynecology & Obstetrics", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2841), null },
                    { 13L, "Hematology", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2843), null },
                    { 14L, "Hepatology", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2844), null },
                    { 15L, "Immunology", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2845), null },
                    { 16L, "Infectious Diseases", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2846), null },
                    { 17L, "Internal Medicine", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2848), null },
                    { 18L, "Interventional Spine & Pain Medicine", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2849), null },
                    { 19L, "IVF", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2851), null },
                    { 20L, "Nephrology", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2852), null },
                    { 21L, "Neurology", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2854), null },
                    { 22L, "Nuclear Medicine", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2856), null },
                    { 23L, "Nutrition & Health", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2857), null },
                    { 24L, "Oncology", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2859), null },
                    { 25L, "Ophthalmology", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2860), null },
                    { 26L, "Orthopedics", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2861), null },
                    { 27L, "Pathology & Laboratory Medicine", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2863), null },
                    { 28L, "Pediatrics", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2864), null },
                    { 29L, "Physiotherapy & Rehabilitation", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2866), null },
                    { 30L, "Plastic & Reconstructive Surgery", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2867), null },
                    { 31L, "Psychology & Psychiatry", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2868), null },
                    { 32L, "Pulmonology", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2870), null },
                    { 33L, "Radiology", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2871), null },
                    { 34L, "Rheumatology", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2872), null },
                    { 35L, "Robotic Surgery", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2874), null },
                    { 36L, "Urology", new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(2875), null }
                });

            migrationBuilder.InsertData(
                table: "HealthCareSubCategories",
                columns: new[] { "Id", "CreatedOn", "HealthCareCategoryId", "SubCategory", "UpdatedOn" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3112), 2L, "Heart", null },
                    { 2L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3116), 6L, "Hormones", null },
                    { 3L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3118), 6L, "Diabetes", null },
                    { 4L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3120), 6L, "Thyroid", null },
                    { 5L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3122), 7L, "Ear", null },
                    { 6L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3124), 7L, "Nose", null },
                    { 7L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3126), 7L, "Throat", null },
                    { 8L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3127), 8L, "Digestive System", null },
                    { 9L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3129), 9L, "Family Medicine", null },
                    { 10L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3130), 11L, "Elderly Care", null },
                    { 11L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3132), 13L, "Blood", null },
                    { 12L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3134), 14L, "Liver", null },
                    { 13L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3135), 15L, "Allergies", null },
                    { 14L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3137), 15L, "Immune Disorders", null },
                    { 15L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3138), 20L, "Kidneys", null },
                    { 16L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3140), 21L, "Brain", null },
                    { 17L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3141), 21L, "Nervous System", null },
                    { 18L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3215), 24L, "Cancer", null },
                    { 19L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3217), 24L, "Bone Marrow Transplant", null },
                    { 20L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3219), 24L, "Cancer Care", null },
                    { 21L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3220), 25L, "Eye Surgery", null },
                    { 22L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3222), 26L, "Bones", null },
                    { 23L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3223), 26L, "Joints", null },
                    { 24L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3225), 32L, "Lungs", null },
                    { 25L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3227), 34L, "Joints", null },
                    { 26L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3228), 34L, "Arthritis", null },
                    { 27L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3230), 34L, "Autoimmune", null },
                    { 28L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3231), 36L, "Urinary Tract", null },
                    { 29L, new DateTime(2025, 8, 30, 8, 9, 55, 805, DateTimeKind.Utc).AddTicks(3233), 36L, "Male Reproductive", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HealthCareSubCategories_HealthCareCategoryId",
                table: "HealthCareSubCategories",
                column: "HealthCareCategoryId");

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
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "HealthCareCategories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

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
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "HealthCareCategories",
                columns: new[] { "Id", "Category", "CreatedOn", "UpdatedOn" },
                values: new object[,]
                {
                    { 1L, "Anaesthesiology", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5193), null },
                    { 2L, "Cardiology", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5197), null },
                    { 3L, "Critical Care", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5198), null },
                    { 4L, "Dentistry", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5199), null },
                    { 5L, "Dermatology", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5200), null },
                    { 6L, "Endocrinology", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5201), null },
                    { 7L, "ENT", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5202), null },
                    { 8L, "Gastroenterology", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5204), null },
                    { 9L, "General Physician", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5205), null },
                    { 10L, "General Surgery", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5206), null },
                    { 11L, "Geriatrics", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5207), null },
                    { 12L, "Gynecology & Obstetrics", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5208), null },
                    { 13L, "Hematology", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5209), null },
                    { 14L, "Hepatology", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5210), null },
                    { 15L, "Immunology", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5211), null },
                    { 16L, "Infectious Diseases", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5212), null },
                    { 17L, "Internal Medicine", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5213), null },
                    { 18L, "Interventional Spine & Pain Medicine", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5215), null },
                    { 19L, "IVF", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5216), null },
                    { 20L, "Nephrology", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5217), null },
                    { 21L, "Neurology", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5218), null },
                    { 22L, "Nuclear Medicine", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5219), null },
                    { 23L, "Nutrition & Health", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5220), null },
                    { 24L, "Oncology", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5221), null },
                    { 25L, "Ophthalmology", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5222), null },
                    { 26L, "Orthopedics", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5224), null },
                    { 27L, "Pathology & Laboratory Medicine", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5226), null },
                    { 28L, "Pediatrics", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5227), null },
                    { 29L, "Physiotherapy & Rehabilitation", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5228), null },
                    { 30L, "Plastic & Reconstructive Surgery", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5229), null },
                    { 31L, "Psychology & Psychiatry", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5230), null },
                    { 32L, "Pulmonology", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5231), null },
                    { 33L, "Radiology", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5232), null },
                    { 34L, "Rheumatology", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5233), null },
                    { 35L, "Robotic Surgery", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5234), null },
                    { 36L, "Urology", new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5235), null }
                });

            migrationBuilder.InsertData(
                table: "HealthCareSubCategories",
                columns: new[] { "Id", "CreatedOn", "HealthCareCategoryId", "SubCategory", "UpdatedOn" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5425), 2L, "Heart", null },
                    { 2L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5427), 6L, "Hormones", null },
                    { 3L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5429), 6L, "Diabetes", null },
                    { 4L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5430), 6L, "Thyroid", null },
                    { 5L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5431), 7L, "Ear", null },
                    { 6L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5433), 7L, "Nose", null },
                    { 7L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5434), 7L, "Throat", null },
                    { 8L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5435), 8L, "Digestive System", null },
                    { 9L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5437), 9L, "Family Medicine", null },
                    { 10L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5438), 11L, "Elderly Care", null },
                    { 11L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5439), 13L, "Blood", null },
                    { 12L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5441), 14L, "Liver", null },
                    { 13L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5442), 15L, "Allergies", null },
                    { 14L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5444), 15L, "Immune Disorders", null },
                    { 15L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5445), 20L, "Kidneys", null },
                    { 16L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5446), 21L, "Brain", null },
                    { 17L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5447), 21L, "Nervous System", null },
                    { 18L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5448), 24L, "Cancer", null },
                    { 19L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5449), 24L, "Bone Marrow Transplant", null },
                    { 20L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5450), 24L, "Cancer Care", null },
                    { 21L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5452), 25L, "Eye Surgery", null },
                    { 22L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5453), 26L, "Bones", null },
                    { 23L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5454), 26L, "Joints", null },
                    { 24L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5455), 32L, "Lungs", null },
                    { 25L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5456), 34L, "Joints", null },
                    { 26L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5458), 34L, "Arthritis", null },
                    { 27L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5459), 34L, "Autoimmune", null },
                    { 28L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5460), 36L, "Urinary Tract", null },
                    { 29L, new DateTime(2025, 8, 29, 10, 11, 8, 619, DateTimeKind.Utc).AddTicks(5462), 36L, "Male Reproductive", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HealthCareSubCategories_HealthCareCategoryId",
                table: "HealthCareSubCategories",
                column: "HealthCareCategoryId");
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
        }
    }
}

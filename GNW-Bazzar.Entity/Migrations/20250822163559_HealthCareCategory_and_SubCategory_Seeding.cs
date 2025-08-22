using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GNW_Bazzar.Entity.Migrations
{
    /// <inheritdoc />
    public partial class HealthCareCategory_and_SubCategory_Seeding : Migration
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
                    UpdatedBy = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCareCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HealthCareSubCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HealthCareCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCareSubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthCareSubCategory_HealthCareCategories_HealthCareCategoryId",
                        column: x => x.HealthCareCategoryId,
                        principalTable: "HealthCareCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HealthCareCategories",
                columns: new[] { "Id", "Category", "CreatedOn", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, "Anaesthesiology", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7145), null },
                    { 2L, "Cardiology", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7151), null },
                    { 3L, "Critical Care", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7154), null },
                    { 4L, "Dentistry", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7157), null },
                    { 5L, "Dermatology", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7160), null },
                    { 6L, "Endocrinology", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7162), null },
                    { 7L, "ENT", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7165), null },
                    { 8L, "Gastroenterology", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7167), null },
                    { 9L, "General Physician", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7170), null },
                    { 10L, "General Surgery", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7172), null },
                    { 11L, "Geriatrics", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7175), null },
                    { 12L, "Gynecology & Obstetrics", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7177), null },
                    { 13L, "Hematology", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7179), null },
                    { 14L, "Hepatology", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7182), null },
                    { 15L, "Immunology", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7184), null },
                    { 16L, "Infectious Diseases", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7187), null },
                    { 17L, "Internal Medicine", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7189), null },
                    { 18L, "Interventional Spine & Pain Medicine", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7191), null },
                    { 19L, "IVF", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7193), null },
                    { 20L, "Nephrology", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7196), null },
                    { 21L, "Neurology", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7198), null },
                    { 22L, "Nuclear Medicine", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7201), null },
                    { 23L, "Nutrition & Health", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7203), null },
                    { 24L, "Oncology", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7205), null },
                    { 25L, "Ophthalmology", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7208), null },
                    { 26L, "Orthopedics", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7213), null },
                    { 27L, "Pathology & Laboratory Medicine", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7215), null },
                    { 28L, "Pediatrics", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7218), null },
                    { 29L, "Physiotherapy & Rehabilitation", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7220), null },
                    { 30L, "Plastic & Reconstructive Surgery", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7222), null },
                    { 31L, "Psychology & Psychiatry", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7225), null },
                    { 32L, "Pulmonology", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7227), null },
                    { 33L, "Radiology", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7229), null },
                    { 34L, "Rheumatology", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7232), null },
                    { 35L, "Robotic Surgery", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7234), null },
                    { 36L, "Urology", new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7236), null }
                });

            migrationBuilder.InsertData(
                table: "HealthCareSubCategory",
                columns: new[] { "Id", "CreatedOn", "HealthCareCategoryId", "SubCategory", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7704), 2L, "Heart", null },
                    { 2L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7711), 6L, "Hormones", null },
                    { 3L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7715), 6L, "Diabetes", null },
                    { 4L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7718), 6L, "Thyroid", null },
                    { 5L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7720), 7L, "Ear", null },
                    { 6L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7723), 7L, "Nose", null },
                    { 7L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7725), 7L, "Throat", null },
                    { 8L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7729), 8L, "Digestive System", null },
                    { 9L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7732), 9L, "Family Medicine", null },
                    { 10L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7735), 11L, "Elderly Care", null },
                    { 11L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7737), 13L, "Blood", null },
                    { 12L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7740), 14L, "Liver", null },
                    { 13L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7742), 15L, "Allergies", null },
                    { 14L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7745), 15L, "Immune Disorders", null },
                    { 15L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7748), 20L, "Kidneys", null },
                    { 16L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7750), 21L, "Brain", null },
                    { 17L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7753), 21L, "Nervous System", null },
                    { 18L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7755), 24L, "Cancer", null },
                    { 19L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7758), 24L, "Bone Marrow Transplant", null },
                    { 20L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7761), 24L, "Cancer Care", null },
                    { 21L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7763), 25L, "Eye Surgery", null },
                    { 22L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7766), 26L, "Bones", null },
                    { 23L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7768), 26L, "Joints", null },
                    { 24L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7771), 32L, "Lungs", null },
                    { 25L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7774), 34L, "Joints", null },
                    { 26L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7776), 34L, "Arthritis", null },
                    { 27L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7779), 34L, "Autoimmune", null },
                    { 28L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7781), 36L, "Urinary Tract", null },
                    { 29L, new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7784), 36L, "Male Reproductive", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HealthCareSubCategory_HealthCareCategoryId",
                table: "HealthCareSubCategory",
                column: "HealthCareCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HealthCareSubCategory");

            migrationBuilder.DropTable(
                name: "HealthCareCategories");
        }
    }
}

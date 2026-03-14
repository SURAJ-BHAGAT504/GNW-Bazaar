using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNW_Bazzar.Entity.Migrations
{
    /// <inheritdoc />
    public partial class updatedDoctorTableAsRequirements : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_HealthCareCategories_HealthCareCategoryId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_HealthCareCategoryId",
                table: "Doctors");

            migrationBuilder.CreateTable(
                name: "DoctorHealthCareCategory",
                columns: table => new
                {
                    DoctorsId = table.Column<long>(type: "bigint", nullable: false),
                    healthCareCategoryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorHealthCareCategory", x => new { x.DoctorsId, x.healthCareCategoryId });
                    table.ForeignKey(
                        name: "FK_DoctorHealthCareCategory_Doctors_DoctorsId",
                        column: x => x.DoctorsId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorHealthCareCategory_HealthCareCategories_healthCareCategoryId",
                        column: x => x.healthCareCategoryId,
                        principalTable: "HealthCareCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 21, 32, 702, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.CreateIndex(
                name: "IX_DoctorHealthCareCategory_healthCareCategoryId",
                table: "DoctorHealthCareCategory",
                column: "healthCareCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorHealthCareCategory");

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 12, 59, 19, 661, DateTimeKind.Utc).AddTicks(5653));

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_HealthCareCategoryId",
                table: "Doctors",
                column: "HealthCareCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_HealthCareCategories_HealthCareCategoryId",
                table: "Doctors",
                column: "HealthCareCategoryId",
                principalTable: "HealthCareCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

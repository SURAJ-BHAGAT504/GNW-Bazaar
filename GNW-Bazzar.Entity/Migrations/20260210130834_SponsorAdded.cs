using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNW_Bazzar.Entity.Migrations
{
    /// <inheritdoc />
    public partial class SponsorAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sponsors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SponsorFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SponsorType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Frequency = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponsors", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 13, 8, 33, 438, DateTimeKind.Utc).AddTicks(5182));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sponsors");

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2026, 1, 27, 11, 49, 5, 906, DateTimeKind.Utc).AddTicks(5733));
        }
    }
}

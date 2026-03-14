using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNW_Bazzar.Entity.Migrations
{
    /// <inheritdoc />
    public partial class updatedDoctorTableAsRequirements2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HealthCareCategoryId",
                table: "Doctors");

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedOn",
                value: new DateTime(2026, 3, 14, 11, 56, 15, 944, DateTimeKind.Utc).AddTicks(1558));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "HealthCareCategoryId",
                table: "Doctors",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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
        }
    }
}

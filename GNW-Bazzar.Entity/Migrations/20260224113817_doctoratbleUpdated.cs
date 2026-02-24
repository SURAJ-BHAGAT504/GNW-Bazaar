using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNW_Bazzar.Entity.Migrations
{
    /// <inheritdoc />
    public partial class doctoratbleUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WhatsAppNumber",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 11, 38, 17, 27, DateTimeKind.Utc).AddTicks(3574));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WhatsAppNumber",
                table: "Doctors");

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 24, 10, 39, 6, 578, DateTimeKind.Utc).AddTicks(896));
        }
    }
}

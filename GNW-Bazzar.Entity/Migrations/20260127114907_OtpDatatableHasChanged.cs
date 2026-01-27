using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNW_Bazzar.Entity.Migrations
{
    /// <inheritdoc />
    public partial class OtpDatatableHasChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "Otps",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "Otps");

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2025, 12, 3, 13, 54, 55, 853, DateTimeKind.Utc).AddTicks(5831));
        }
    }
}

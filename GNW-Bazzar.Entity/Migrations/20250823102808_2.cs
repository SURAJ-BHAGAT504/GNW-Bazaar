using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNW_Bazzar.Entity.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "HealthCareSubCategory",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "HealthCareCategories",
                newName: "UpdatedOn");

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 23, 10, 28, 7, 780, DateTimeKind.Utc).AddTicks(6668));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "HealthCareSubCategory",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "HealthCareCategories",
                newName: "UpdatedBy");

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategory",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 22, 16, 35, 57, 997, DateTimeKind.Utc).AddTicks(7784));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNW_Bazzar.Entity.Migrations
{
    /// <inheritdoc />
    public partial class refreshToken_table_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthCareSubCategory_HealthCareCategories_HealthCareCategoryId",
                table: "HealthCareSubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HealthCareSubCategory",
                table: "HealthCareSubCategory");

            migrationBuilder.RenameTable(
                name: "HealthCareSubCategory",
                newName: "HealthCareSubCategories");

            migrationBuilder.RenameIndex(
                name: "IX_HealthCareSubCategory_HealthCareCategoryId",
                table: "HealthCareSubCategories",
                newName: "IX_HealthCareSubCategories_HealthCareCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HealthCareSubCategories",
                table: "HealthCareSubCategories",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "HealthCareSubCategories",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2025, 8, 28, 14, 57, 39, 666, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCareSubCategories_HealthCareCategories_HealthCareCategoryId",
                table: "HealthCareSubCategories",
                column: "HealthCareCategoryId",
                principalTable: "HealthCareCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthCareSubCategories_HealthCareCategories_HealthCareCategoryId",
                table: "HealthCareSubCategories");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HealthCareSubCategories",
                table: "HealthCareSubCategories");

            migrationBuilder.RenameTable(
                name: "HealthCareSubCategories",
                newName: "HealthCareSubCategory");

            migrationBuilder.RenameIndex(
                name: "IX_HealthCareSubCategories_HealthCareCategoryId",
                table: "HealthCareSubCategory",
                newName: "IX_HealthCareSubCategory_HealthCareCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HealthCareSubCategory",
                table: "HealthCareSubCategory",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCareSubCategory_HealthCareCategories_HealthCareCategoryId",
                table: "HealthCareSubCategory",
                column: "HealthCareCategoryId",
                principalTable: "HealthCareCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

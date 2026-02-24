using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GNW_Bazzar.Entity.Migrations
{
    /// <inheritdoc />
    public partial class someupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_HealthCareSubCategories_HealthCareSubCategoryId",
                table: "Doctors");

            migrationBuilder.DropTable(
                name: "HealthCareSubCategories");

            migrationBuilder.DropColumn(
                name: "Frequency",
                table: "Sponsors");

            migrationBuilder.RenameColumn(
                name: "HealthCareSubCategoryId",
                table: "Doctors",
                newName: "HealthCareCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_HealthCareSubCategoryId",
                table: "Doctors",
                newName: "IX_Doctors_HealthCareCategoryId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_HealthCareCategories_HealthCareCategoryId",
                table: "Doctors",
                column: "HealthCareCategoryId",
                principalTable: "HealthCareCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_HealthCareCategories_HealthCareCategoryId",
                table: "Doctors");

            migrationBuilder.RenameColumn(
                name: "HealthCareCategoryId",
                table: "Doctors",
                newName: "HealthCareSubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_HealthCareCategoryId",
                table: "Doctors",
                newName: "IX_Doctors_HealthCareSubCategoryId");

            migrationBuilder.AddColumn<long>(
                name: "Frequency",
                table: "Sponsors",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "HealthCareSubCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthCareCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubCategory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "CategoryMasters",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 26L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 27L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 28L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 29L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 30L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 31L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 32L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 33L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 34L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 35L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "HealthCareCategories",
                keyColumn: "Id",
                keyValue: 36L,
                column: "CreatedOn",
                value: new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.InsertData(
                table: "HealthCareSubCategories",
                columns: new[] { "Id", "CreatedOn", "HealthCareCategoryId", "SubCategory", "UpdatedOn" },
                values: new object[,]
                {
                    { 1L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6359), 2L, "Heart", null },
                    { 2L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6360), 6L, "Hormones", null },
                    { 3L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6362), 6L, "Diabetes", null },
                    { 4L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6362), 6L, "Thyroid", null },
                    { 5L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6363), 7L, "Ear", null },
                    { 6L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6364), 7L, "Nose", null },
                    { 7L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6365), 7L, "Throat", null },
                    { 8L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6366), 8L, "Digestive System", null },
                    { 9L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6367), 9L, "Family Medicine", null },
                    { 10L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6368), 11L, "Elderly Care", null },
                    { 11L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6369), 13L, "Blood", null },
                    { 12L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6370), 14L, "Liver", null },
                    { 13L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6371), 15L, "Allergies", null },
                    { 14L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6372), 15L, "Immune Disorders", null },
                    { 15L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6373), 20L, "Kidneys", null },
                    { 16L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6374), 21L, "Brain", null },
                    { 17L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6375), 21L, "Nervous System", null },
                    { 18L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6376), 24L, "Cancer", null },
                    { 19L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6377), 24L, "Bone Marrow Transplant", null },
                    { 20L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6378), 24L, "Cancer Care", null },
                    { 21L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6379), 25L, "Eye Surgery", null },
                    { 22L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6380), 26L, "Bones", null },
                    { 23L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6381), 26L, "Joints", null },
                    { 24L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6382), 32L, "Lungs", null },
                    { 25L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6382), 34L, "Joints", null },
                    { 26L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6383), 34L, "Arthritis", null },
                    { 27L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6384), 34L, "Autoimmune", null },
                    { 28L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6385), 36L, "Urinary Tract", null },
                    { 29L, new DateTime(2026, 2, 10, 14, 15, 35, 571, DateTimeKind.Utc).AddTicks(6386), 36L, "Male Reproductive", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HealthCareSubCategories_HealthCareCategoryId",
                table: "HealthCareSubCategories",
                column: "HealthCareCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_HealthCareSubCategories_HealthCareSubCategoryId",
                table: "Doctors",
                column: "HealthCareSubCategoryId",
                principalTable: "HealthCareSubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

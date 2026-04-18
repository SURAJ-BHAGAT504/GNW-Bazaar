using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNW_Bazzar.Entity.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CategoryMasterId",
                table: "Sponsors",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sponsors_CategoryMasterId",
                table: "Sponsors",
                column: "CategoryMasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sponsors_CategoryMasters_CategoryMasterId",
                table: "Sponsors",
                column: "CategoryMasterId",
                principalTable: "CategoryMasters",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sponsors_CategoryMasters_CategoryMasterId",
                table: "Sponsors");

            migrationBuilder.DropIndex(
                name: "IX_Sponsors_CategoryMasterId",
                table: "Sponsors");

            migrationBuilder.DropColumn(
                name: "CategoryMasterId",
                table: "Sponsors");
        }
    }
}

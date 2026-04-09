using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNW_Bazzar.Entity.Migrations
{
    /// <inheritdoc />
    public partial class initial_create_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientSubCategoryMaster_SubCategoryMaster_subCategoryMastersId",
                table: "ClientSubCategoryMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategoryMaster_CategoryMasters_CategoryMasterId",
                table: "SubCategoryMaster");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategoryMaster",
                table: "SubCategoryMaster");

            migrationBuilder.RenameTable(
                name: "SubCategoryMaster",
                newName: "SubCategoryMasters");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "SubCategoryMasters",
                newName: "CategoryName");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategoryMaster_CategoryMasterId",
                table: "SubCategoryMasters",
                newName: "IX_SubCategoryMasters_CategoryMasterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategoryMasters",
                table: "SubCategoryMasters",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientSubCategoryMaster_SubCategoryMasters_subCategoryMastersId",
                table: "ClientSubCategoryMaster",
                column: "subCategoryMastersId",
                principalTable: "SubCategoryMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategoryMasters_CategoryMasters_CategoryMasterId",
                table: "SubCategoryMasters",
                column: "CategoryMasterId",
                principalTable: "CategoryMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientSubCategoryMaster_SubCategoryMasters_subCategoryMastersId",
                table: "ClientSubCategoryMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategoryMasters_CategoryMasters_CategoryMasterId",
                table: "SubCategoryMasters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategoryMasters",
                table: "SubCategoryMasters");

            migrationBuilder.RenameTable(
                name: "SubCategoryMasters",
                newName: "SubCategoryMaster");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "SubCategoryMaster",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_SubCategoryMasters_CategoryMasterId",
                table: "SubCategoryMaster",
                newName: "IX_SubCategoryMaster_CategoryMasterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategoryMaster",
                table: "SubCategoryMaster",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientSubCategoryMaster_SubCategoryMaster_subCategoryMastersId",
                table: "ClientSubCategoryMaster",
                column: "subCategoryMastersId",
                principalTable: "SubCategoryMaster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategoryMaster_CategoryMasters_CategoryMasterId",
                table: "SubCategoryMaster",
                column: "CategoryMasterId",
                principalTable: "CategoryMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNW_Bazzar.Entity.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_CategoryMasters_CategoryMasterId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_CategoryMasterId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CategoryMasterId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Clients",
                newName: "WhatsAppNumber");

            migrationBuilder.RenameColumn(
                name: "ContactPerson",
                table: "Clients",
                newName: "Highlights");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "SubCategoryMaster",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryMasterId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoryMaster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategoryMaster_CategoryMasters_CategoryMasterId",
                        column: x => x.CategoryMasterId,
                        principalTable: "CategoryMasters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientSubCategoryMaster",
                columns: table => new
                {
                    ClientsId = table.Column<long>(type: "bigint", nullable: false),
                    subCategoryMastersId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientSubCategoryMaster", x => new { x.ClientsId, x.subCategoryMastersId });
                    table.ForeignKey(
                        name: "FK_ClientSubCategoryMaster_Clients_ClientsId",
                        column: x => x.ClientsId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientSubCategoryMaster_SubCategoryMaster_subCategoryMastersId",
                        column: x => x.subCategoryMastersId,
                        principalTable: "SubCategoryMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientSubCategoryMaster_subCategoryMastersId",
                table: "ClientSubCategoryMaster",
                column: "subCategoryMastersId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoryMaster_CategoryMasterId",
                table: "SubCategoryMaster",
                column: "CategoryMasterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientSubCategoryMaster");

            migrationBuilder.DropTable(
                name: "SubCategoryMaster");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "WhatsAppNumber",
                table: "Clients",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Highlights",
                table: "Clients",
                newName: "ContactPerson");

            migrationBuilder.AddColumn<long>(
                name: "CategoryMasterId",
                table: "Clients",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CategoryMasterId",
                table: "Clients",
                column: "CategoryMasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_CategoryMasters_CategoryMasterId",
                table: "Clients",
                column: "CategoryMasterId",
                principalTable: "CategoryMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

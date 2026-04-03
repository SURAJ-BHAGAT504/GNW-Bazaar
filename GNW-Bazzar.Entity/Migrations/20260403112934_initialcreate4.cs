using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNW_Bazzar.Entity.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Sponsors");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Sponsors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

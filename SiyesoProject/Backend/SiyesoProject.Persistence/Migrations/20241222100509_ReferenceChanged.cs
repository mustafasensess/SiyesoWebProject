using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiyesoProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ReferenceChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "References",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleEn",
                table: "References",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "References");

            migrationBuilder.DropColumn(
                name: "TitleEn",
                table: "References");
        }
    }
}

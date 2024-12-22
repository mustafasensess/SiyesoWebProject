using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiyesoProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InfoBoxChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainTitle",
                table: "Specialties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainTitleEn",
                table: "Specialties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainDescription",
                table: "DigitalProblems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainDescriptionEn",
                table: "DigitalProblems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainTitle",
                table: "DigitalProblems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainTitleEn",
                table: "DigitalProblems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainTitle",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "MainTitleEn",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "MainDescription",
                table: "DigitalProblems");

            migrationBuilder.DropColumn(
                name: "MainDescriptionEn",
                table: "DigitalProblems");

            migrationBuilder.DropColumn(
                name: "MainTitle",
                table: "DigitalProblems");

            migrationBuilder.DropColumn(
                name: "MainTitleEn",
                table: "DigitalProblems");
        }
    }
}

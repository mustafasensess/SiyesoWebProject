using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiyesoProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InfoBoxChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "MainTitle",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "MainTitleEn",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "DigitalProblems");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "DigitalProblems");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "DigitalProblems");

            migrationBuilder.DropColumn(
                name: "MainTitle",
                table: "DigitalProblems");

            migrationBuilder.DropColumn(
                name: "MainTitleEn",
                table: "DigitalProblems");

            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DigitalProblemId = table.Column<int>(type: "int", nullable: true),
                    SpecialtyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Card_DigitalProblems_DigitalProblemId",
                        column: x => x.DigitalProblemId,
                        principalTable: "DigitalProblems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Card_Specialties_SpecialtyId",
                        column: x => x.SpecialtyId,
                        principalTable: "Specialties",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Card_DigitalProblemId",
                table: "Card",
                column: "DigitalProblemId");

            migrationBuilder.CreateIndex(
                name: "IX_Card_SpecialtyId",
                table: "Card",
                column: "SpecialtyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Specialties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Specialties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Specialties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                name: "Description",
                table: "DigitalProblems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "DigitalProblems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
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
    }
}

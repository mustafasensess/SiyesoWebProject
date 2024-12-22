using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiyesoProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InfoBoxChangess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "UserInfoCard");

            migrationBuilder.RenameColumn(
                name: "TitleEn",
                table: "TeamMembers",
                newName: "ProfileTitleEn");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "TeamMembers",
                newName: "ProfileTitle");

            migrationBuilder.RenameColumn(
                name: "DescriptionEn",
                table: "TeamMembers",
                newName: "ProfilePicture");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "TeamMembers",
                newName: "ProfileName");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Specialties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "DigitalProblems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "DigitalProblems");

            migrationBuilder.RenameColumn(
                name: "ProfileTitleEn",
                table: "TeamMembers",
                newName: "TitleEn");

            migrationBuilder.RenameColumn(
                name: "ProfileTitle",
                table: "TeamMembers",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ProfilePicture",
                table: "TeamMembers",
                newName: "DescriptionEn");

            migrationBuilder.RenameColumn(
                name: "ProfileName",
                table: "TeamMembers",
                newName: "Description");

            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DigitalProblemId = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialtyId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "UserInfoCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileTitleEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfoCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInfoCard_TeamMembers_TeamId",
                        column: x => x.TeamId,
                        principalTable: "TeamMembers",
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

            migrationBuilder.CreateIndex(
                name: "IX_UserInfoCard_TeamId",
                table: "UserInfoCard",
                column: "TeamId");
        }
    }
}

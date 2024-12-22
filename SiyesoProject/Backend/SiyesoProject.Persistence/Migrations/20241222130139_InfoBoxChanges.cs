using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiyesoProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InfoBoxChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "ProfileName",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "ProfileTitle",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "ProfileTitleEn",
                table: "TeamMembers");

            migrationBuilder.RenameColumn(
                name: "MainDescriptionEn",
                table: "DigitalProblems",
                newName: "DescriptionEn");

            migrationBuilder.RenameColumn(
                name: "MainDescription",
                table: "DigitalProblems",
                newName: "Description");

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
                name: "DescriptionEn",
                table: "Card",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleEn",
                table: "Card",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                name: "IX_UserInfoCard_TeamId",
                table: "UserInfoCard",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserInfoCard");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Card");

            migrationBuilder.DropColumn(
                name: "TitleEn",
                table: "Card");

            migrationBuilder.RenameColumn(
                name: "DescriptionEn",
                table: "DigitalProblems",
                newName: "MainDescriptionEn");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "DigitalProblems",
                newName: "MainDescription");

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfileName",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfileTitle",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfileTitleEn",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

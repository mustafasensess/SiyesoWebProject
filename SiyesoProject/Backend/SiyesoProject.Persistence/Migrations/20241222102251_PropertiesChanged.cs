using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiyesoProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PropertiesChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamMembers_UserInfoCard_UserInfoCardId",
                table: "TeamMembers");

            migrationBuilder.DropTable(
                name: "UserInfoCard");

            migrationBuilder.DropIndex(
                name: "IX_TeamMembers_UserInfoCardId",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "UserInfoCardId",
                table: "TeamMembers");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "TeamMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddColumn<string>(
                name: "TitleEn",
                table: "TeamMembers",
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
                name: "TitleEn",
                table: "Specialties",
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
                name: "TitleEn",
                table: "DigitalProblems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "AboutUs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleEn",
                table: "AboutUs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "TeamMembers");

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

            migrationBuilder.DropColumn(
                name: "TitleEn",
                table: "TeamMembers");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "TitleEn",
                table: "Specialties");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "DigitalProblems");

            migrationBuilder.DropColumn(
                name: "TitleEn",
                table: "DigitalProblems");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "TitleEn",
                table: "AboutUs");

            migrationBuilder.AddColumn<int>(
                name: "UserInfoCardId",
                table: "TeamMembers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserInfoCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfoCard", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_UserInfoCardId",
                table: "TeamMembers",
                column: "UserInfoCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMembers_UserInfoCard_UserInfoCardId",
                table: "TeamMembers",
                column: "UserInfoCardId",
                principalTable: "UserInfoCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

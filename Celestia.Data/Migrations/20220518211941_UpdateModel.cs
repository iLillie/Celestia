using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Celestia.Data.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "logo_url",
                table: "companies",
                newName: "website_url");

            migrationBuilder.RenameColumn(
                name: "homepage_url",
                table: "companies",
                newName: "icon_url");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "accounts",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "website_url",
                table: "companies",
                newName: "logo_url");

            migrationBuilder.RenameColumn(
                name: "icon_url",
                table: "companies",
                newName: "homepage_url");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "accounts",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);
        }
    }
}

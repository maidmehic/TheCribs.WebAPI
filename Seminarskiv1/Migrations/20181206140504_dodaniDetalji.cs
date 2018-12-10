using Microsoft.EntityFrameworkCore.Migrations;

namespace Seminarskiv1.Migrations
{
    public partial class dodaniDetalji : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "BlindiranaVrata",
                table: "ViseDetalja",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Kvadrata",
                table: "ViseDetalja",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimarnaOrjentacija",
                table: "ViseDetalja",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "VideoNadzor",
                table: "ViseDetalja",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "VrstaPoda",
                table: "ViseDetalja",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlindiranaVrata",
                table: "ViseDetalja");

            migrationBuilder.DropColumn(
                name: "Kvadrata",
                table: "ViseDetalja");

            migrationBuilder.DropColumn(
                name: "PrimarnaOrjentacija",
                table: "ViseDetalja");

            migrationBuilder.DropColumn(
                name: "VideoNadzor",
                table: "ViseDetalja");

            migrationBuilder.DropColumn(
                name: "VrstaPoda",
                table: "ViseDetalja");
        }
    }
}

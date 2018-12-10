using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Seminarskiv1.Migrations
{
    public partial class ispravka2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adresa",
                table: "ViseDetalja");

            migrationBuilder.DropColumn(
                name: "DatumObjave",
                table: "ViseDetalja");

            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "DetaljiStana");

            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "DetaljiStana");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adresa",
                table: "ViseDetalja",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumObjave",
                table: "ViseDetalja",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "Cijena",
                table: "DetaljiStana",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "DetaljiStana",
                nullable: true);
        }
    }
}

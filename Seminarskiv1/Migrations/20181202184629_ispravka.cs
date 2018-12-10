using Microsoft.EntityFrameworkCore.Migrations;

namespace Seminarskiv1.Migrations
{
    public partial class ispravka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ViseDetalja_Stan_StanId",
                table: "ViseDetalja");

            migrationBuilder.RenameColumn(
                name: "StanId",
                table: "ViseDetalja",
                newName: "DetaljiStanaId");

            migrationBuilder.RenameIndex(
                name: "IX_ViseDetalja_StanId",
                table: "ViseDetalja",
                newName: "IX_ViseDetalja_DetaljiStanaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ViseDetalja_DetaljiStana_DetaljiStanaId",
                table: "ViseDetalja",
                column: "DetaljiStanaId",
                principalTable: "DetaljiStana",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ViseDetalja_DetaljiStana_DetaljiStanaId",
                table: "ViseDetalja");

            migrationBuilder.RenameColumn(
                name: "DetaljiStanaId",
                table: "ViseDetalja",
                newName: "StanId");

            migrationBuilder.RenameIndex(
                name: "IX_ViseDetalja_DetaljiStanaId",
                table: "ViseDetalja",
                newName: "IX_ViseDetalja_StanId");

            migrationBuilder.AddForeignKey(
                name: "FK_ViseDetalja_Stan_StanId",
                table: "ViseDetalja",
                column: "StanId",
                principalTable: "Stan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

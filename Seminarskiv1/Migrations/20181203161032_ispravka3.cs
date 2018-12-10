using Microsoft.EntityFrameworkCore.Migrations;

namespace Seminarskiv1.Migrations
{
    public partial class ispravka3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetaljiStana_Grad_GradId",
                table: "DetaljiStana");

            migrationBuilder.DropIndex(
                name: "IX_DetaljiStana_GradId",
                table: "DetaljiStana");

            migrationBuilder.DropColumn(
                name: "GradId",
                table: "DetaljiStana");

            migrationBuilder.AddColumn<int>(
                name: "GradId",
                table: "Stan",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stan_GradId",
                table: "Stan",
                column: "GradId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stan_Grad_GradId",
                table: "Stan",
                column: "GradId",
                principalTable: "Grad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stan_Grad_GradId",
                table: "Stan");

            migrationBuilder.DropIndex(
                name: "IX_Stan_GradId",
                table: "Stan");

            migrationBuilder.DropColumn(
                name: "GradId",
                table: "Stan");

            migrationBuilder.AddColumn<int>(
                name: "GradId",
                table: "DetaljiStana",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DetaljiStana_GradId",
                table: "DetaljiStana",
                column: "GradId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetaljiStana_Grad_GradId",
                table: "DetaljiStana",
                column: "GradId",
                principalTable: "Grad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Seminarskiv1.Migrations
{
    public partial class dodanaKategorijaStanu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategorijaId",
                table: "Stan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stan_KategorijaId",
                table: "Stan",
                column: "KategorijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stan_Kategorija_KategorijaId",
                table: "Stan",
                column: "KategorijaId",
                principalTable: "Kategorija",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stan_Kategorija_KategorijaId",
                table: "Stan");

            migrationBuilder.DropIndex(
                name: "IX_Stan_KategorijaId",
                table: "Stan");

            migrationBuilder.DropColumn(
                name: "KategorijaId",
                table: "Stan");
        }
    }
}

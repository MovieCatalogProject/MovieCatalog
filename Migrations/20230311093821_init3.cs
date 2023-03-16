using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Katalog.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Movie",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Genre",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movie",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Genre",
                newName: "id");
        }
    }
}

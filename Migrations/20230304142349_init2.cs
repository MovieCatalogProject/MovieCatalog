using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Katalog.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) //Методът Up създава таблиците на базата данни
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "AspNetUsers",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder) //Методът Down изтрива таблиците на базата данни
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "Number");
        }
    }
}

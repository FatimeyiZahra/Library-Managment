using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_Managment.Migrations
{
    public partial class addedRowToBookTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Barcode",
                table: "Books",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Bookshelf",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Barcode",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Bookshelf",
                table: "Books");
        }
    }
}

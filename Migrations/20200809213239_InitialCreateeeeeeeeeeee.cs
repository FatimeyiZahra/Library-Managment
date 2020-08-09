using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_Managment.Migrations
{
    public partial class InitialCreateeeeeeeeeeee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IssueDateId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "ReturnDateId",
                table: "Baskets");

            migrationBuilder.RenameColumn(
                name: "ReturnDate",
                table: "Issues",
                newName: "ReturnDateId");

            migrationBuilder.AddColumn<string>(
                name: "BarcodeId",
                table: "Issues",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PriceId",
                table: "Baskets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReturnDate",
                table: "Baskets",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BarcodeId",
                table: "Issues");

            migrationBuilder.DropColumn(
                name: "PriceId",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "Baskets");

            migrationBuilder.RenameColumn(
                name: "ReturnDateId",
                table: "Issues",
                newName: "ReturnDate");

            migrationBuilder.AddColumn<int>(
                name: "IssueDateId",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReturnDateId",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

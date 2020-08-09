using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_Managment.Migrations
{
    public partial class addedBasketModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fine",
                table: "Issues");

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarcodeId = table.Column<int>(nullable: false),
                    BookNameId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    IssueDateId = table.Column<int>(nullable: false),
                    ReturnDateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.AddColumn<double>(
                name: "Fine",
                table: "Issues",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}

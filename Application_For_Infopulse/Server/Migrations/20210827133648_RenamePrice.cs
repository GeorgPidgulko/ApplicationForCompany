using Microsoft.EntityFrameworkCore.Migrations;

namespace Application_For_Infopulse.Server.Migrations
{
    public partial class RenamePrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "ProductsInOders",
                newName: "ProductPrice");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductPrice",
                table: "ProductsInOders",
                newName: "Price");
        }
    }
}

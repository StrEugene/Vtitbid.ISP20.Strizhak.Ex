using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vtitbid.ISP20.Strizhak.Ex.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ShopName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Cost = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices_Id", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prices");
        }
    }
}

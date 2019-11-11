using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppXmlToDB.Migrations
{
    public partial class mih1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    quentity = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

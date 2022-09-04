using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asp.net_Core_MVC_GestionMag.Migrations
{
    public partial class InitialCreateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomArticle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionArticle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QtiteArticle = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}

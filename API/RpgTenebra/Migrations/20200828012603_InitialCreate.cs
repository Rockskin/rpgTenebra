using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgTenebra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GlosseryOfTheDamned",
                columns: table => new
                {
                    GodId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "varchar(750)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlosseryOfTheDamned", x => x.GodId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GlosseryOfTheDamned");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgTenebra.Migrations
{
    public partial class AddParagraphsandtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParagraphId",
                table: "Rows",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Paragraphs",
                columns: table => new
                {
                    ParagraphId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(250)", nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false),
                    ChapterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paragraphs", x => x.ParagraphId);
                    table.ForeignKey(
                        name: "FK_Paragraphs_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "ChapterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    TableId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParagraphId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.TableId);
                    table.ForeignKey(
                        name: "FK_Tables_Paragraphs_ParagraphId",
                        column: x => x.ParagraphId,
                        principalTable: "Paragraphs",
                        principalColumn: "ParagraphId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rows_ParagraphId",
                table: "Rows",
                column: "ParagraphId");

            migrationBuilder.CreateIndex(
                name: "IX_Paragraphs_ChapterId",
                table: "Paragraphs",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_ParagraphId",
                table: "Tables",
                column: "ParagraphId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rows_Paragraphs_ParagraphId",
                table: "Rows",
                column: "ParagraphId",
                principalTable: "Paragraphs",
                principalColumn: "ParagraphId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rows_Paragraphs_ParagraphId",
                table: "Rows");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "Paragraphs");

            migrationBuilder.DropIndex(
                name: "IX_Rows_ParagraphId",
                table: "Rows");

            migrationBuilder.DropColumn(
                name: "ParagraphId",
                table: "Rows");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgTenebra.Migrations
{
    public partial class Cleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DramaRows_Disciplines_DisciplineId",
                table: "DramaRows");

            migrationBuilder.DropTable(
                name: "DescriptionRows");

            migrationBuilder.DropTable(
                name: "PowerRows");

            migrationBuilder.DropTable(
                name: "Rows");

            migrationBuilder.DropTable(
                name: "SystemRows");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "Paragraphs");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropColumn(
                name: "RowId",
                table: "DramaRows");

            migrationBuilder.DropColumn(
                name: "BloodResonance",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "DangerForTheMasquerade",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Characteristics");

            migrationBuilder.AddColumn<int>(
                name: "DisciplineId",
                table: "Powers",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DisciplineId",
                table: "DramaRows",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Row",
                table: "DramaRows",
                type: "varchar(2000)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CharacteristicRows",
                columns: table => new
                {
                    CharacteristicRowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Row = table.Column<string>(type: "varchar(2000)", nullable: false),
                    CharacteristicId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacteristicRows", x => x.CharacteristicRowId);
                    table.ForeignKey(
                        name: "FK_CharacteristicRows_Characteristics_CharacteristicId",
                        column: x => x.CharacteristicId,
                        principalTable: "Characteristics",
                        principalColumn: "CharacteristicId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DisciplineRows",
                columns: table => new
                {
                    DisciplineRowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Row = table.Column<string>(type: "varchar(2000)", nullable: false),
                    DisciplineId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplineRows", x => x.DisciplineRowId);
                    table.ForeignKey(
                        name: "FK_DisciplineRows_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "DisciplineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PowerDescriptionRows",
                columns: table => new
                {
                    DescriptionRowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Row = table.Column<string>(type: "varchar(2000)", nullable: false),
                    PowerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerDescriptionRows", x => x.DescriptionRowId);
                    table.ForeignKey(
                        name: "FK_PowerDescriptionRows_Powers_PowerId",
                        column: x => x.PowerId,
                        principalTable: "Powers",
                        principalColumn: "PowerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PowerSystemRows",
                columns: table => new
                {
                    SystemRowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Row = table.Column<string>(type: "varchar(2000)", nullable: false),
                    PowerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerSystemRows", x => x.SystemRowId);
                    table.ForeignKey(
                        name: "FK_PowerSystemRows_Powers_PowerId",
                        column: x => x.PowerId,
                        principalTable: "Powers",
                        principalColumn: "PowerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Powers_DisciplineId",
                table: "Powers",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacteristicRows_CharacteristicId",
                table: "CharacteristicRows",
                column: "CharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplineRows_DisciplineId",
                table: "DisciplineRows",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_PowerDescriptionRows_PowerId",
                table: "PowerDescriptionRows",
                column: "PowerId");

            migrationBuilder.CreateIndex(
                name: "IX_PowerSystemRows_PowerId",
                table: "PowerSystemRows",
                column: "PowerId");

            migrationBuilder.AddForeignKey(
                name: "FK_DramaRows_Disciplines_DisciplineId",
                table: "DramaRows",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "DisciplineId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Powers_Disciplines_DisciplineId",
                table: "Powers",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "DisciplineId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DramaRows_Disciplines_DisciplineId",
                table: "DramaRows");

            migrationBuilder.DropForeignKey(
                name: "FK_Powers_Disciplines_DisciplineId",
                table: "Powers");

            migrationBuilder.DropTable(
                name: "CharacteristicRows");

            migrationBuilder.DropTable(
                name: "DisciplineRows");

            migrationBuilder.DropTable(
                name: "PowerDescriptionRows");

            migrationBuilder.DropTable(
                name: "PowerSystemRows");

            migrationBuilder.DropIndex(
                name: "IX_Powers_DisciplineId",
                table: "Powers");

            migrationBuilder.DropColumn(
                name: "DisciplineId",
                table: "Powers");

            migrationBuilder.DropColumn(
                name: "Row",
                table: "DramaRows");

            migrationBuilder.AlterColumn<int>(
                name: "DisciplineId",
                table: "DramaRows",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RowId",
                table: "DramaRows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BloodResonance",
                table: "Characteristics",
                type: "varchar(500)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DangerForTheMasquerade",
                table: "Characteristics",
                type: "varchar(500)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Characteristics",
                type: "varchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "DescriptionRows",
                columns: table => new
                {
                    DescriptionRowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PowerId = table.Column<int>(type: "int", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescriptionRows", x => x.DescriptionRowId);
                    table.ForeignKey(
                        name: "FK_DescriptionRows_Powers_PowerId",
                        column: x => x.PowerId,
                        principalTable: "Powers",
                        principalColumn: "PowerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PowerRows",
                columns: table => new
                {
                    PowerRowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisciplineId = table.Column<int>(type: "int", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerRows", x => x.PowerRowId);
                    table.ForeignKey(
                        name: "FK_PowerRows_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "DisciplineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    QuoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Signature = table.Column<string>(type: "varchar(2500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.QuoteId);
                });

            migrationBuilder.CreateTable(
                name: "SystemRows",
                columns: table => new
                {
                    SystemRowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PowerId = table.Column<int>(type: "int", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemRows", x => x.SystemRowId);
                    table.ForeignKey(
                        name: "FK_SystemRows_Powers_PowerId",
                        column: x => x.PowerId,
                        principalTable: "Powers",
                        principalColumn: "PowerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    ChapterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    QuoteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.ChapterId);
                    table.ForeignKey(
                        name: "FK_Chapters_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "QuoteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Paragraphs",
                columns: table => new
                {
                    ParagraphId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChapterId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(250)", nullable: false)
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
                name: "Rows",
                columns: table => new
                {
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacteristicId = table.Column<int>(type: "int", nullable: true),
                    DisciplineId = table.Column<int>(type: "int", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    ParagraphId = table.Column<int>(type: "int", nullable: true),
                    QuoteId = table.Column<int>(type: "int", nullable: true),
                    Text = table.Column<string>(type: "varchar(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rows", x => x.RowId);
                    table.ForeignKey(
                        name: "FK_Rows_Characteristics_CharacteristicId",
                        column: x => x.CharacteristicId,
                        principalTable: "Characteristics",
                        principalColumn: "CharacteristicId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rows_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "DisciplineId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rows_Paragraphs_ParagraphId",
                        column: x => x.ParagraphId,
                        principalTable: "Paragraphs",
                        principalColumn: "ParagraphId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rows_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "QuoteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    TableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParagraphId = table.Column<int>(type: "int", nullable: true)
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
                name: "IX_Chapters_QuoteId",
                table: "Chapters",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionRows_PowerId",
                table: "DescriptionRows",
                column: "PowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Paragraphs_ChapterId",
                table: "Paragraphs",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_PowerRows_DisciplineId",
                table: "PowerRows",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_CharacteristicId",
                table: "Rows",
                column: "CharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_DisciplineId",
                table: "Rows",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_ParagraphId",
                table: "Rows",
                column: "ParagraphId");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_QuoteId",
                table: "Rows",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemRows_PowerId",
                table: "SystemRows",
                column: "PowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_ParagraphId",
                table: "Tables",
                column: "ParagraphId");

            migrationBuilder.AddForeignKey(
                name: "FK_DramaRows_Disciplines_DisciplineId",
                table: "DramaRows",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "DisciplineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

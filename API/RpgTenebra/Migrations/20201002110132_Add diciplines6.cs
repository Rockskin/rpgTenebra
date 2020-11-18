using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgTenebra.Migrations
{
    public partial class Adddiciplines6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rows_Disciplines_DisciplineId1",
                table: "Rows");

            migrationBuilder.DropForeignKey(
                name: "FK_Rows_Disciplines_DisciplineId2",
                table: "Rows");

            migrationBuilder.DropForeignKey(
                name: "FK_Rows_Powers_PowerId",
                table: "Rows");

            migrationBuilder.DropForeignKey(
                name: "FK_Rows_Powers_PowerId1",
                table: "Rows");

            migrationBuilder.DropIndex(
                name: "IX_Rows_DisciplineId1",
                table: "Rows");

            migrationBuilder.DropIndex(
                name: "IX_Rows_DisciplineId2",
                table: "Rows");

            migrationBuilder.DropIndex(
                name: "IX_Rows_PowerId",
                table: "Rows");

            migrationBuilder.DropIndex(
                name: "IX_Rows_PowerId1",
                table: "Rows");

            migrationBuilder.DropColumn(
                name: "DisciplineId1",
                table: "Rows");

            migrationBuilder.DropColumn(
                name: "DisciplineId2",
                table: "Rows");

            migrationBuilder.DropColumn(
                name: "PowerId",
                table: "Rows");

            migrationBuilder.DropColumn(
                name: "PowerId1",
                table: "Rows");

            migrationBuilder.CreateTable(
                name: "DescriptionRows",
                columns: table => new
                {
                    DescriptionRowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowId = table.Column<int>(nullable: false),
                    PowerId = table.Column<int>(nullable: false)
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
                name: "DramaRows",
                columns: table => new
                {
                    DramaRowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowId = table.Column<int>(nullable: false),
                    DisciplineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DramaRows", x => x.DramaRowId);
                    table.ForeignKey(
                        name: "FK_DramaRows_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "DisciplineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PowerRows",
                columns: table => new
                {
                    PowerRowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowId = table.Column<int>(nullable: false),
                    DisciplineId = table.Column<int>(nullable: false)
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
                name: "SystemRows",
                columns: table => new
                {
                    SystemRowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RowId = table.Column<int>(nullable: false),
                    PowerId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionRows_PowerId",
                table: "DescriptionRows",
                column: "PowerId");

            migrationBuilder.CreateIndex(
                name: "IX_DramaRows_DisciplineId",
                table: "DramaRows",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_PowerRows_DisciplineId",
                table: "PowerRows",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemRows_PowerId",
                table: "SystemRows",
                column: "PowerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DescriptionRows");

            migrationBuilder.DropTable(
                name: "DramaRows");

            migrationBuilder.DropTable(
                name: "PowerRows");

            migrationBuilder.DropTable(
                name: "SystemRows");

            migrationBuilder.AddColumn<int>(
                name: "DisciplineId1",
                table: "Rows",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisciplineId2",
                table: "Rows",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PowerId",
                table: "Rows",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PowerId1",
                table: "Rows",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rows_DisciplineId1",
                table: "Rows",
                column: "DisciplineId1");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_DisciplineId2",
                table: "Rows",
                column: "DisciplineId2");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_PowerId",
                table: "Rows",
                column: "PowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_PowerId1",
                table: "Rows",
                column: "PowerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Rows_Disciplines_DisciplineId1",
                table: "Rows",
                column: "DisciplineId1",
                principalTable: "Disciplines",
                principalColumn: "DisciplineId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rows_Disciplines_DisciplineId2",
                table: "Rows",
                column: "DisciplineId2",
                principalTable: "Disciplines",
                principalColumn: "DisciplineId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rows_Powers_PowerId",
                table: "Rows",
                column: "PowerId",
                principalTable: "Powers",
                principalColumn: "PowerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rows_Powers_PowerId1",
                table: "Rows",
                column: "PowerId1",
                principalTable: "Powers",
                principalColumn: "PowerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

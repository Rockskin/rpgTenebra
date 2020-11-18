using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgTenebra.Migrations
{
    public partial class Adddiciplines3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CharacteristicId",
                table: "Rows",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisciplineId",
                table: "Rows",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisciplineId1",
                table: "Rows",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PowerId",
                table: "Rows",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PowerId1",
                table: "Rows",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Characteristics",
                columns: table => new
                {
                    CharacteristicId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "varchar(250)", nullable: false),
                    DangerForTheMasquerade = table.Column<string>(type: "varchar(500)", nullable: false),
                    BloodResonance = table.Column<string>(type: "varchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristics", x => x.CharacteristicId);
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    DisciplineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(250)", nullable: false),
                    NickName = table.Column<string>(type: "varchar(2000)", nullable: false),
                    CharacteristicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.DisciplineId);
                    table.ForeignKey(
                        name: "FK_Disciplines_Characteristics_CharacteristicId",
                        column: x => x.CharacteristicId,
                        principalTable: "Characteristics",
                        principalColumn: "CharacteristicId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Powers",
                columns: table => new
                {
                    PowerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rank = table.Column<int>(nullable: false),
                    Name = table.Column<string>(type: "varchar(250)", nullable: false),
                    DicePool = table.Column<string>(type: "varchar(500)", nullable: true),
                    Cost = table.Column<string>(type: "varchar(500)", nullable: false),
                    Duration = table.Column<string>(type: "varchar(2000)", nullable: false),
                    DisciplineId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Powers", x => x.PowerId);
                    table.ForeignKey(
                        name: "FK_Powers_Disciplines_DisciplineId",
                        column: x => x.DisciplineId,
                        principalTable: "Disciplines",
                        principalColumn: "DisciplineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rows_CharacteristicId",
                table: "Rows",
                column: "CharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_DisciplineId",
                table: "Rows",
                column: "DisciplineId");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_DisciplineId1",
                table: "Rows",
                column: "DisciplineId1");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_PowerId",
                table: "Rows",
                column: "PowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_PowerId1",
                table: "Rows",
                column: "PowerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_CharacteristicId",
                table: "Disciplines",
                column: "CharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_Powers_DisciplineId",
                table: "Powers",
                column: "DisciplineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rows_Characteristics_CharacteristicId",
                table: "Rows",
                column: "CharacteristicId",
                principalTable: "Characteristics",
                principalColumn: "CharacteristicId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rows_Disciplines_DisciplineId",
                table: "Rows",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "DisciplineId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rows_Disciplines_DisciplineId1",
                table: "Rows",
                column: "DisciplineId1",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rows_Characteristics_CharacteristicId",
                table: "Rows");

            migrationBuilder.DropForeignKey(
                name: "FK_Rows_Disciplines_DisciplineId",
                table: "Rows");

            migrationBuilder.DropForeignKey(
                name: "FK_Rows_Disciplines_DisciplineId1",
                table: "Rows");

            migrationBuilder.DropForeignKey(
                name: "FK_Rows_Powers_PowerId",
                table: "Rows");

            migrationBuilder.DropForeignKey(
                name: "FK_Rows_Powers_PowerId1",
                table: "Rows");

            migrationBuilder.DropTable(
                name: "Powers");

            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "Characteristics");

            migrationBuilder.DropIndex(
                name: "IX_Rows_CharacteristicId",
                table: "Rows");

            migrationBuilder.DropIndex(
                name: "IX_Rows_DisciplineId",
                table: "Rows");

            migrationBuilder.DropIndex(
                name: "IX_Rows_DisciplineId1",
                table: "Rows");

            migrationBuilder.DropIndex(
                name: "IX_Rows_PowerId",
                table: "Rows");

            migrationBuilder.DropIndex(
                name: "IX_Rows_PowerId1",
                table: "Rows");

            migrationBuilder.DropColumn(
                name: "CharacteristicId",
                table: "Rows");

            migrationBuilder.DropColumn(
                name: "DisciplineId",
                table: "Rows");

            migrationBuilder.DropColumn(
                name: "DisciplineId1",
                table: "Rows");

            migrationBuilder.DropColumn(
                name: "PowerId",
                table: "Rows");

            migrationBuilder.DropColumn(
                name: "PowerId1",
                table: "Rows");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgTenebra.Migrations
{
    public partial class Adddiciplines5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Powers_Disciplines_DisciplineId",
                table: "Powers");

            migrationBuilder.DropIndex(
                name: "IX_Powers_DisciplineId",
                table: "Powers");

            migrationBuilder.DropColumn(
                name: "DisciplineId",
                table: "Powers");

            migrationBuilder.AddColumn<int>(
                name: "DisciplineId2",
                table: "Rows",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rows_DisciplineId2",
                table: "Rows",
                column: "DisciplineId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Rows_Disciplines_DisciplineId2",
                table: "Rows",
                column: "DisciplineId2",
                principalTable: "Disciplines",
                principalColumn: "DisciplineId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rows_Disciplines_DisciplineId2",
                table: "Rows");

            migrationBuilder.DropIndex(
                name: "IX_Rows_DisciplineId2",
                table: "Rows");

            migrationBuilder.DropColumn(
                name: "DisciplineId2",
                table: "Rows");

            migrationBuilder.AddColumn<int>(
                name: "DisciplineId",
                table: "Powers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Powers_DisciplineId",
                table: "Powers",
                column: "DisciplineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Powers_Disciplines_DisciplineId",
                table: "Powers",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "DisciplineId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

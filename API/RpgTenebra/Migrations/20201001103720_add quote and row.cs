﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace RpgTenebra.Migrations
{
    public partial class addquoteandrow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuoteId",
                table: "Chapters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    QuoteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Signature = table.Column<string>(type: "varchar(2500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.QuoteId);
                });

            migrationBuilder.CreateTable(
                name: "Rows",
                columns: table => new
                {
                    RowId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "varchar(2000)", nullable: false),
                    DisplayOrder = table.Column<int>(nullable: false),
                    QuoteId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rows", x => x.RowId);
                    table.ForeignKey(
                        name: "FK_Rows_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "QuoteId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_QuoteId",
                table: "Chapters",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_QuoteId",
                table: "Rows",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Quotes_QuoteId",
                table: "Chapters",
                column: "QuoteId",
                principalTable: "Quotes",
                principalColumn: "QuoteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Quotes_QuoteId",
                table: "Chapters");

            migrationBuilder.DropTable(
                name: "Rows");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropIndex(
                name: "IX_Chapters_QuoteId",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "QuoteId",
                table: "Chapters");
        }
    }
}
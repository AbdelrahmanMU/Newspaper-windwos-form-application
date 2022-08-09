using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day2.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    hireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NewsDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pdf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reference = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsDetails", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "news",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    btief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    author_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_news", x => x.id);
                    table.ForeignKey(
                        name: "FK_news_Authors_author_id",
                        column: x => x.author_id,
                        principalTable: "Authors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_news_author_id",
                table: "news",
                column: "author_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "news");

            migrationBuilder.DropTable(
                name: "NewsDetails");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day2.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "btief",
                table: "news",
                newName: "brief");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "brief",
                table: "news",
                newName: "btief");
        }
    }
}

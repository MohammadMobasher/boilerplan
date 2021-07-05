using Microsoft.EntityFrameworkCore.Migrations;

namespace markaz.Migrations
{
    public partial class addsomefieldtoTestTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TestTbl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "TestTbl",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "TestTbl");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "TestTbl");
        }
    }
}

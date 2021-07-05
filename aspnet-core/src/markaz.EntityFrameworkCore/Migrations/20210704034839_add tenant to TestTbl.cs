using Microsoft.EntityFrameworkCore.Migrations;

namespace markaz.Migrations
{
    public partial class addtenanttoTestTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "TestTbl",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "TestTbl");
        }
    }
}

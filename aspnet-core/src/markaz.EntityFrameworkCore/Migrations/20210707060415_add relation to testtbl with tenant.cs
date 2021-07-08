using Microsoft.EntityFrameworkCore.Migrations;

namespace markaz.Migrations
{
    public partial class addrelationtotesttblwithtenant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TestTbl_TenantId",
                table: "TestTbl",
                column: "TenantId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestTbl_AbpTenants_TenantId",
                table: "TestTbl",
                column: "TenantId",
                principalTable: "AbpTenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestTbl_AbpTenants_TenantId",
                table: "TestTbl");

            migrationBuilder.DropIndex(
                name: "IX_TestTbl_TenantId",
                table: "TestTbl");
        }
    }
}

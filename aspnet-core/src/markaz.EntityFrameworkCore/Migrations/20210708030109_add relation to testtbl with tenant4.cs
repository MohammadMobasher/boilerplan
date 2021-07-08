using Microsoft.EntityFrameworkCore.Migrations;

namespace markaz.Migrations
{
    public partial class addrelationtotesttblwithtenant4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_TestTbl_TestTblId",
                table: "AbpTenants");

            migrationBuilder.DropIndex(
                name: "IX_AbpTenants_TestTblId",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "TestTblId",
                table: "AbpTenants");

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

            migrationBuilder.AddColumn<int>(
                name: "TestTblId",
                table: "AbpTenants",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_TestTblId",
                table: "AbpTenants",
                column: "TestTblId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_TestTbl_TestTblId",
                table: "AbpTenants",
                column: "TestTblId",
                principalTable: "TestTbl",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

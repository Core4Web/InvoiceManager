using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceManager.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvoiceAccountId",
                table: "Invoices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_InvoiceAccountId",
                table: "Invoices",
                column: "InvoiceAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_InvoiceAccounts_InvoiceAccountId",
                table: "Invoices",
                column: "InvoiceAccountId",
                principalTable: "InvoiceAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_InvoiceAccounts_InvoiceAccountId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_InvoiceAccountId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "InvoiceAccountId",
                table: "Invoices");
        }
    }
}

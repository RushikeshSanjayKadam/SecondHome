using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Tax_Invoice_Changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CGSTRate",
                table: "TaxTbl");

            migrationBuilder.DropColumn(
                name: "IGSTRate",
                table: "TaxTbl");

            migrationBuilder.DropColumn(
                name: "SGSTAmount",
                table: "InvoiceTaxTbl");

            migrationBuilder.RenameColumn(
                name: "SGSTRate",
                table: "TaxTbl",
                newName: "TaxPercentage");

            migrationBuilder.RenameColumn(
                name: "IGSTAmount",
                table: "InvoiceTaxTbl",
                newName: "TaxPercentage");

            migrationBuilder.RenameColumn(
                name: "CGSTAmount",
                table: "InvoiceTaxTbl",
                newName: "TaxAmount");

            migrationBuilder.AddColumn<long>(
                name: "CheckOutID",
                table: "Invoice",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_CheckOutID",
                table: "Invoice",
                column: "CheckOutID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_BookingCheckOutTbl_CheckOutID",
                table: "Invoice",
                column: "CheckOutID",
                principalTable: "BookingCheckOutTbl",
                principalColumn: "BookingCheckOutID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_BookingCheckOutTbl_CheckOutID",
                table: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_CheckOutID",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "CheckOutID",
                table: "Invoice");

            migrationBuilder.RenameColumn(
                name: "TaxPercentage",
                table: "TaxTbl",
                newName: "SGSTRate");

            migrationBuilder.RenameColumn(
                name: "TaxPercentage",
                table: "InvoiceTaxTbl",
                newName: "IGSTAmount");

            migrationBuilder.RenameColumn(
                name: "TaxAmount",
                table: "InvoiceTaxTbl",
                newName: "CGSTAmount");

            migrationBuilder.AddColumn<decimal>(
                name: "CGSTRate",
                table: "TaxTbl",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "IGSTRate",
                table: "TaxTbl",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "SGSTAmount",
                table: "InvoiceTaxTbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}

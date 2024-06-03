using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Payment_Changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentTbl_BookinRoomTbl_BookingRoomID",
                table: "PaymentTbl");

            migrationBuilder.RenameColumn(
                name: "BookingRoomID",
                table: "PaymentTbl",
                newName: "BookingID");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentTbl_BookingRoomID",
                table: "PaymentTbl",
                newName: "IX_PaymentTbl_BookingID");

            migrationBuilder.AddColumn<long>(
                name: "DocumentType",
                table: "BookingCheckInTbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentTbl_BookingTbl_BookingID",
                table: "PaymentTbl",
                column: "BookingID",
                principalTable: "BookingTbl",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentTbl_BookingTbl_BookingID",
                table: "PaymentTbl");

            migrationBuilder.DropColumn(
                name: "DocumentType",
                table: "BookingCheckInTbl");

            migrationBuilder.RenameColumn(
                name: "BookingID",
                table: "PaymentTbl",
                newName: "BookingRoomID");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentTbl_BookingID",
                table: "PaymentTbl",
                newName: "IX_PaymentTbl_BookingRoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentTbl_BookinRoomTbl_BookingRoomID",
                table: "PaymentTbl",
                column: "BookingRoomID",
                principalTable: "BookinRoomTbl",
                principalColumn: "BookingRoomID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

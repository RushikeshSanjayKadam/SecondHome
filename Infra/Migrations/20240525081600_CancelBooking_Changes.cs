using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class CancelBooking_Changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CancelBookingTbl_BookinRoomTbl_BookingRoomID",
                table: "CancelBookingTbl");

            migrationBuilder.RenameColumn(
                name: "BookingRoomID",
                table: "CancelBookingTbl",
                newName: "BookingID");

            migrationBuilder.RenameIndex(
                name: "IX_CancelBookingTbl_BookingRoomID",
                table: "CancelBookingTbl",
                newName: "IX_CancelBookingTbl_BookingID");

            migrationBuilder.AddForeignKey(
                name: "FK_CancelBookingTbl_BookingTbl_BookingID",
                table: "CancelBookingTbl",
                column: "BookingID",
                principalTable: "BookingTbl",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CancelBookingTbl_BookingTbl_BookingID",
                table: "CancelBookingTbl");

            migrationBuilder.RenameColumn(
                name: "BookingID",
                table: "CancelBookingTbl",
                newName: "BookingRoomID");

            migrationBuilder.RenameIndex(
                name: "IX_CancelBookingTbl_BookingID",
                table: "CancelBookingTbl",
                newName: "IX_CancelBookingTbl_BookingRoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_CancelBookingTbl_BookinRoomTbl_BookingRoomID",
                table: "CancelBookingTbl",
                column: "BookingRoomID",
                principalTable: "BookinRoomTbl",
                principalColumn: "BookingRoomID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

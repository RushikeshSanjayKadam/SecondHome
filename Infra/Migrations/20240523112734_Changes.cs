using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingCheckInTbl_BookinRoomTbl_BookingRoomID",
                table: "BookingCheckInTbl");

            migrationBuilder.RenameColumn(
                name: "BookingRoomID",
                table: "BookingCheckInTbl",
                newName: "BookingID");

            migrationBuilder.RenameIndex(
                name: "IX_BookingCheckInTbl_BookingRoomID",
                table: "BookingCheckInTbl",
                newName: "IX_BookingCheckInTbl_BookingID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingCheckInTbl_BookingTbl_BookingID",
                table: "BookingCheckInTbl",
                column: "BookingID",
                principalTable: "BookingTbl",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingCheckInTbl_BookingTbl_BookingID",
                table: "BookingCheckInTbl");

            migrationBuilder.RenameColumn(
                name: "BookingID",
                table: "BookingCheckInTbl",
                newName: "BookingRoomID");

            migrationBuilder.RenameIndex(
                name: "IX_BookingCheckInTbl_BookingID",
                table: "BookingCheckInTbl",
                newName: "IX_BookingCheckInTbl_BookingRoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingCheckInTbl_BookinRoomTbl_BookingRoomID",
                table: "BookingCheckInTbl",
                column: "BookingRoomID",
                principalTable: "BookinRoomTbl",
                principalColumn: "BookingRoomID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

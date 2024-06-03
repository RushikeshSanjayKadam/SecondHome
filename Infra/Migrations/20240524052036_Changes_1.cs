using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Changes_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingCheckOutTbl_BookinRoomTbl_BookingRoomID",
                table: "BookingCheckOutTbl");

            migrationBuilder.RenameColumn(
                name: "BookingRoomID",
                table: "BookingCheckOutTbl",
                newName: "BookingID");

            migrationBuilder.RenameIndex(
                name: "IX_BookingCheckOutTbl_BookingRoomID",
                table: "BookingCheckOutTbl",
                newName: "IX_BookingCheckOutTbl_BookingID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingCheckOutTbl_BookingTbl_BookingID",
                table: "BookingCheckOutTbl",
                column: "BookingID",
                principalTable: "BookingTbl",
                principalColumn: "BookingID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingCheckOutTbl_BookingTbl_BookingID",
                table: "BookingCheckOutTbl");

            migrationBuilder.RenameColumn(
                name: "BookingID",
                table: "BookingCheckOutTbl",
                newName: "BookingRoomID");

            migrationBuilder.RenameIndex(
                name: "IX_BookingCheckOutTbl_BookingID",
                table: "BookingCheckOutTbl",
                newName: "IX_BookingCheckOutTbl_BookingRoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingCheckOutTbl_BookinRoomTbl_BookingRoomID",
                table: "BookingCheckOutTbl",
                column: "BookingRoomID",
                principalTable: "BookinRoomTbl",
                principalColumn: "BookingRoomID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

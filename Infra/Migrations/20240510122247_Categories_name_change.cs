using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Categories_name_change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomCatgeoryTbl_HotelTbl_HotelID",
                table: "RoomCatgeoryTbl");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomServiceTbl_RoomCatgeoryTbl_RoomCategoryID",
                table: "RoomServiceTbl");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomTbl_RoomCatgeoryTbl_RoomCategoryID",
                table: "RoomTbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomCatgeoryTbl",
                table: "RoomCatgeoryTbl");

            migrationBuilder.RenameTable(
                name: "RoomCatgeoryTbl",
                newName: "RoomCategoryTbl");

            migrationBuilder.RenameColumn(
                name: "RoomCatgeoryID",
                table: "RoomCategoryTbl",
                newName: "RoomCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_RoomCatgeoryTbl_HotelID",
                table: "RoomCategoryTbl",
                newName: "IX_RoomCategoryTbl_HotelID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomCategoryTbl",
                table: "RoomCategoryTbl",
                column: "RoomCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCategoryTbl_HotelTbl_HotelID",
                table: "RoomCategoryTbl",
                column: "HotelID",
                principalTable: "HotelTbl",
                principalColumn: "HotelID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomServiceTbl_RoomCategoryTbl_RoomCategoryID",
                table: "RoomServiceTbl",
                column: "RoomCategoryID",
                principalTable: "RoomCategoryTbl",
                principalColumn: "RoomCategoryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomTbl_RoomCategoryTbl_RoomCategoryID",
                table: "RoomTbl",
                column: "RoomCategoryID",
                principalTable: "RoomCategoryTbl",
                principalColumn: "RoomCategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomCategoryTbl_HotelTbl_HotelID",
                table: "RoomCategoryTbl");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomServiceTbl_RoomCategoryTbl_RoomCategoryID",
                table: "RoomServiceTbl");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomTbl_RoomCategoryTbl_RoomCategoryID",
                table: "RoomTbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomCategoryTbl",
                table: "RoomCategoryTbl");

            migrationBuilder.RenameTable(
                name: "RoomCategoryTbl",
                newName: "RoomCatgeoryTbl");

            migrationBuilder.RenameColumn(
                name: "RoomCategoryID",
                table: "RoomCatgeoryTbl",
                newName: "RoomCatgeoryID");

            migrationBuilder.RenameIndex(
                name: "IX_RoomCategoryTbl_HotelID",
                table: "RoomCatgeoryTbl",
                newName: "IX_RoomCatgeoryTbl_HotelID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomCatgeoryTbl",
                table: "RoomCatgeoryTbl",
                column: "RoomCatgeoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomCatgeoryTbl_HotelTbl_HotelID",
                table: "RoomCatgeoryTbl",
                column: "HotelID",
                principalTable: "HotelTbl",
                principalColumn: "HotelID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomServiceTbl_RoomCatgeoryTbl_RoomCategoryID",
                table: "RoomServiceTbl",
                column: "RoomCategoryID",
                principalTable: "RoomCatgeoryTbl",
                principalColumn: "RoomCatgeoryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomTbl_RoomCatgeoryTbl_RoomCategoryID",
                table: "RoomTbl",
                column: "RoomCategoryID",
                principalTable: "RoomCatgeoryTbl",
                principalColumn: "RoomCatgeoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

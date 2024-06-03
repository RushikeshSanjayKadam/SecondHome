using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminTbl",
                columns: table => new
                {
                    AdminID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminTbl", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "CountryTbl",
                columns: table => new
                {
                    CountryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryTbl", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    InvoiceID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.InvoiceID);
                });

            migrationBuilder.CreateTable(
                name: "TaxTbl",
                columns: table => new
                {
                    TaxID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CGSTRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SGSTRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IGSTRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HSNSACNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxTbl", x => x.TaxID);
                });

            migrationBuilder.CreateTable(
                name: "StateTbl",
                columns: table => new
                {
                    StateID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateTbl", x => x.StateID);
                    table.ForeignKey(
                        name: "FK_StateTbl_CountryTbl_CountryID",
                        column: x => x.CountryID,
                        principalTable: "CountryTbl",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceTaxTbl",
                columns: table => new
                {
                    InvoiceTaxID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IGSTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CGSTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SGSTAmount = table.Column<long>(type: "bigint", nullable: false),
                    InvoiceID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceTaxTbl", x => x.InvoiceTaxID);
                    table.ForeignKey(
                        name: "FK_InvoiceTaxTbl_Invoice_InvoiceID",
                        column: x => x.InvoiceID,
                        principalTable: "Invoice",
                        principalColumn: "InvoiceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateID = table.Column<long>(type: "bigint", nullable: false),
                    CountryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_City_CountryTbl_CountryID",
                        column: x => x.CountryID,
                        principalTable: "CountryTbl",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_City_StateTbl_StateID",
                        column: x => x.StateID,
                        principalTable: "StateTbl",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HotelTbl",
                columns: table => new
                {
                    HotelID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebSiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsGSTApplicable = table.Column<bool>(type: "bit", nullable: false),
                    GSTINNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelTbl", x => x.HotelID);
                    table.ForeignKey(
                        name: "FK_HotelTbl_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTbl",
                columns: table => new
                {
                    UserID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTbl", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_UserTbl_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BedType",
                columns: table => new
                {
                    BedTypeID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BedTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedType", x => x.BedTypeID);
                    table.ForeignKey(
                        name: "FK_BedType_HotelTbl_HotelID",
                        column: x => x.HotelID,
                        principalTable: "HotelTbl",
                        principalColumn: "HotelID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BuildingTbl",
                columns: table => new
                {
                    BuildingID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingTbl", x => x.BuildingID);
                    table.ForeignKey(
                        name: "FK_BuildingTbl_HotelTbl_HotelID",
                        column: x => x.HotelID,
                        principalTable: "HotelTbl",
                        principalColumn: "HotelID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomCatgeoryTbl",
                columns: table => new
                {
                    RoomCatgeoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HotelID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomCatgeoryTbl", x => x.RoomCatgeoryID);
                    table.ForeignKey(
                        name: "FK_RoomCatgeoryTbl_HotelTbl_HotelID",
                        column: x => x.HotelID,
                        principalTable: "HotelTbl",
                        principalColumn: "HotelID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookingTbl",
                columns: table => new
                {
                    BookingID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    HotelID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingTbl", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_BookingTbl_HotelTbl_HotelID",
                        column: x => x.HotelID,
                        principalTable: "HotelTbl",
                        principalColumn: "HotelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingTbl_UserTbl_UserID",
                        column: x => x.UserID,
                        principalTable: "UserTbl",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HotelRatingTbl",
                columns: table => new
                {
                    HotelRatingID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelID = table.Column<long>(type: "bigint", nullable: false),
                    UserID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRatingTbl", x => x.HotelRatingID);
                    table.ForeignKey(
                        name: "FK_HotelRatingTbl_HotelTbl_HotelID",
                        column: x => x.HotelID,
                        principalTable: "HotelTbl",
                        principalColumn: "HotelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HotelRatingTbl_UserTbl_UserID",
                        column: x => x.UserID,
                        principalTable: "UserTbl",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomBedTbl",
                columns: table => new
                {
                    RoomBedID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoofBeds = table.Column<long>(type: "bigint", nullable: false),
                    BedTypeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomBedTbl", x => x.RoomBedID);
                    table.ForeignKey(
                        name: "FK_RoomBedTbl_BedType_BedTypeID",
                        column: x => x.BedTypeID,
                        principalTable: "BedType",
                        principalColumn: "BedTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FloorTbl",
                columns: table => new
                {
                    FloorID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FloorNumber = table.Column<long>(type: "bigint", nullable: false),
                    BuildingID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloorTbl", x => x.FloorID);
                    table.ForeignKey(
                        name: "FK_FloorTbl_BuildingTbl_BuildingID",
                        column: x => x.BuildingID,
                        principalTable: "BuildingTbl",
                        principalColumn: "BuildingID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomServiceTbl",
                columns: table => new
                {
                    RoomServiceID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomServicePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RoomCategoryID = table.Column<long>(type: "bigint", nullable: false),
                    HotelID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomServiceTbl", x => x.RoomServiceID);
                    table.ForeignKey(
                        name: "FK_RoomServiceTbl_HotelTbl_HotelID",
                        column: x => x.HotelID,
                        principalTable: "HotelTbl",
                        principalColumn: "HotelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomServiceTbl_RoomCatgeoryTbl_RoomCategoryID",
                        column: x => x.RoomCategoryID,
                        principalTable: "RoomCatgeoryTbl",
                        principalColumn: "RoomCatgeoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomTbl",
                columns: table => new
                {
                    RoomID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<long>(type: "bigint", nullable: false),
                    RoomCharges = table.Column<long>(type: "bigint", nullable: false),
                    MaxNoofAdults = table.Column<long>(type: "bigint", nullable: false),
                    MaxNoofChilds = table.Column<long>(type: "bigint", nullable: false),
                    RoomCategoryID = table.Column<long>(type: "bigint", nullable: false),
                    FloorID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTbl", x => x.RoomID);
                    table.ForeignKey(
                        name: "FK_RoomTbl_FloorTbl_FloorID",
                        column: x => x.FloorID,
                        principalTable: "FloorTbl",
                        principalColumn: "FloorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomTbl_RoomCatgeoryTbl_RoomCategoryID",
                        column: x => x.RoomCategoryID,
                        principalTable: "RoomCatgeoryTbl",
                        principalColumn: "RoomCatgeoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookinRoomTbl",
                columns: table => new
                {
                    BookingRoomID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    RoomID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookinRoomTbl", x => x.BookingRoomID);
                    table.ForeignKey(
                        name: "FK_BookinRoomTbl_RoomTbl_RoomID",
                        column: x => x.RoomID,
                        principalTable: "RoomTbl",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookinRoomTbl_UserTbl_UserID",
                        column: x => x.UserID,
                        principalTable: "UserTbl",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomPhototTbl",
                columns: table => new
                {
                    RoomPhotoID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomPhototTbl", x => x.RoomPhotoID);
                    table.ForeignKey(
                        name: "FK_RoomPhototTbl_RoomTbl_RoomID",
                        column: x => x.RoomID,
                        principalTable: "RoomTbl",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookingCheckInTbl",
                columns: table => new
                {
                    BookinCheckInID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingCheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoofAdults = table.Column<long>(type: "bigint", nullable: false),
                    NoofChilds = table.Column<long>(type: "bigint", nullable: false),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAddressProofFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingRoomID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingCheckInTbl", x => x.BookinCheckInID);
                    table.ForeignKey(
                        name: "FK_BookingCheckInTbl_BookinRoomTbl_BookingRoomID",
                        column: x => x.BookingRoomID,
                        principalTable: "BookinRoomTbl",
                        principalColumn: "BookingRoomID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookingCheckOutTbl",
                columns: table => new
                {
                    BookingCheckOutID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingCheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingRoomID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingCheckOutTbl", x => x.BookingCheckOutID);
                    table.ForeignKey(
                        name: "FK_BookingCheckOutTbl_BookinRoomTbl_BookingRoomID",
                        column: x => x.BookingRoomID,
                        principalTable: "BookinRoomTbl",
                        principalColumn: "BookingRoomID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CancelBookingTbl",
                columns: table => new
                {
                    CancelBookingID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CancelBookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReasonToCancel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdvance = table.Column<bool>(type: "bit", nullable: false),
                    BookingRoomID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CancelBookingTbl", x => x.CancelBookingID);
                    table.ForeignKey(
                        name: "FK_CancelBookingTbl_BookinRoomTbl_BookingRoomID",
                        column: x => x.BookingRoomID,
                        principalTable: "BookinRoomTbl",
                        principalColumn: "BookingRoomID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTbl",
                columns: table => new
                {
                    PaymentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsAdvance = table.Column<bool>(type: "bit", nullable: false),
                    BookingRoomID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTbl", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_PaymentTbl_BookinRoomTbl_BookingRoomID",
                        column: x => x.BookingRoomID,
                        principalTable: "BookinRoomTbl",
                        principalColumn: "BookingRoomID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AdminTbl",
                columns: new[] { "AdminID", "EmailID", "FirstName", "LastName", "MobileNo", "Password" },
                values: new object[] { 1L, "rskadam1176@gmail.com", "Rushikesh", "Kadam", "8208391176", "rsk@1176" });

            migrationBuilder.CreateIndex(
                name: "IX_BedType_HotelID",
                table: "BedType",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingCheckInTbl_BookingRoomID",
                table: "BookingCheckInTbl",
                column: "BookingRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingCheckOutTbl_BookingRoomID",
                table: "BookingCheckOutTbl",
                column: "BookingRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTbl_HotelID",
                table: "BookingTbl",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTbl_UserID",
                table: "BookingTbl",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_BookinRoomTbl_RoomID",
                table: "BookinRoomTbl",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_BookinRoomTbl_UserID",
                table: "BookinRoomTbl",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingTbl_HotelID",
                table: "BuildingTbl",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_CancelBookingTbl_BookingRoomID",
                table: "CancelBookingTbl",
                column: "BookingRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryID",
                table: "City",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_City_StateID",
                table: "City",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_FloorTbl_BuildingID",
                table: "FloorTbl",
                column: "BuildingID");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRatingTbl_HotelID",
                table: "HotelRatingTbl",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRatingTbl_UserID",
                table: "HotelRatingTbl",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_HotelTbl_CityID",
                table: "HotelTbl",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceTaxTbl_InvoiceID",
                table: "InvoiceTaxTbl",
                column: "InvoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTbl_BookingRoomID",
                table: "PaymentTbl",
                column: "BookingRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBedTbl_BedTypeID",
                table: "RoomBedTbl",
                column: "BedTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomCatgeoryTbl_HotelID",
                table: "RoomCatgeoryTbl",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomPhototTbl_RoomID",
                table: "RoomPhototTbl",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomServiceTbl_HotelID",
                table: "RoomServiceTbl",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomServiceTbl_RoomCategoryID",
                table: "RoomServiceTbl",
                column: "RoomCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomTbl_FloorID",
                table: "RoomTbl",
                column: "FloorID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomTbl_RoomCategoryID",
                table: "RoomTbl",
                column: "RoomCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_StateTbl_CountryID",
                table: "StateTbl",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_UserTbl_CityID",
                table: "UserTbl",
                column: "CityID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminTbl");

            migrationBuilder.DropTable(
                name: "BookingCheckInTbl");

            migrationBuilder.DropTable(
                name: "BookingCheckOutTbl");

            migrationBuilder.DropTable(
                name: "BookingTbl");

            migrationBuilder.DropTable(
                name: "CancelBookingTbl");

            migrationBuilder.DropTable(
                name: "HotelRatingTbl");

            migrationBuilder.DropTable(
                name: "InvoiceTaxTbl");

            migrationBuilder.DropTable(
                name: "PaymentTbl");

            migrationBuilder.DropTable(
                name: "RoomBedTbl");

            migrationBuilder.DropTable(
                name: "RoomPhototTbl");

            migrationBuilder.DropTable(
                name: "RoomServiceTbl");

            migrationBuilder.DropTable(
                name: "TaxTbl");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "BookinRoomTbl");

            migrationBuilder.DropTable(
                name: "BedType");

            migrationBuilder.DropTable(
                name: "RoomTbl");

            migrationBuilder.DropTable(
                name: "UserTbl");

            migrationBuilder.DropTable(
                name: "FloorTbl");

            migrationBuilder.DropTable(
                name: "RoomCatgeoryTbl");

            migrationBuilder.DropTable(
                name: "BuildingTbl");

            migrationBuilder.DropTable(
                name: "HotelTbl");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "StateTbl");

            migrationBuilder.DropTable(
                name: "CountryTbl");
        }
    }
}

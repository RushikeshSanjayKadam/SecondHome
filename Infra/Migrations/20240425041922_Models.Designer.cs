﻿// <auto-generated />
using System;
using Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20240425041922_Models")]
    partial class Models
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Admin", b =>
                {
                    b.Property<long>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("AdminID"));

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.ToTable("AdminTbl");

                    b.HasData(
                        new
                        {
                            AdminID = 1L,
                            EmailID = "rskadam1176@gmail.com",
                            FirstName = "Rushikesh",
                            LastName = "Kadam",
                            MobileNo = "8208391176",
                            Password = "rsk@1176"
                        });
                });

            modelBuilder.Entity("Core.BedType", b =>
                {
                    b.Property<long>("BedTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("BedTypeID"));

                    b.Property<string>("BedTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("HotelID")
                        .HasColumnType("bigint");

                    b.HasKey("BedTypeID");

                    b.HasIndex("HotelID");

                    b.ToTable("BedType");
                });

            modelBuilder.Entity("Core.Booking", b =>
                {
                    b.Property<long>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("BookingID"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("HotelID")
                        .HasColumnType("bigint");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("BookingID");

                    b.HasIndex("HotelID");

                    b.HasIndex("UserID");

                    b.ToTable("BookingTbl");
                });

            modelBuilder.Entity("Core.BookingCheckIn", b =>
                {
                    b.Property<long>("BookinCheckInID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("BookinCheckInID"));

                    b.Property<DateTime>("BookingCheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("BookingRoomID")
                        .HasColumnType("bigint");

                    b.Property<string>("IsAddressProofFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("NoofAdults")
                        .HasColumnType("bigint");

                    b.Property<long>("NoofChilds")
                        .HasColumnType("bigint");

                    b.Property<string>("PersonName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookinCheckInID");

                    b.HasIndex("BookingRoomID");

                    b.ToTable("BookingCheckInTbl");
                });

            modelBuilder.Entity("Core.BookingCheckOut", b =>
                {
                    b.Property<long>("BookingCheckOutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("BookingCheckOutID"));

                    b.Property<DateTime>("BookingCheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("BookingRoomID")
                        .HasColumnType("bigint");

                    b.HasKey("BookingCheckOutID");

                    b.HasIndex("BookingRoomID");

                    b.ToTable("BookingCheckOutTbl");
                });

            modelBuilder.Entity("Core.BookingRoom", b =>
                {
                    b.Property<long>("BookingRoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("BookingRoomID"));

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("RoomID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("BookingRoomID");

                    b.HasIndex("RoomID");

                    b.HasIndex("UserID");

                    b.ToTable("BookinRoomTbl");
                });

            modelBuilder.Entity("Core.Building", b =>
                {
                    b.Property<long>("BuildingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("BuildingID"));

                    b.Property<string>("BuildingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("HotelID")
                        .HasColumnType("bigint");

                    b.HasKey("BuildingID");

                    b.HasIndex("HotelID");

                    b.ToTable("BuildingTbl");
                });

            modelBuilder.Entity("Core.CancelBooking", b =>
                {
                    b.Property<long>("CancelBookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CancelBookingID"));

                    b.Property<long>("BookingRoomID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CancelBookingDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAdvance")
                        .HasColumnType("bit");

                    b.Property<string>("ReasonToCancel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CancelBookingID");

                    b.HasIndex("BookingRoomID");

                    b.ToTable("CancelBookingTbl");
                });

            modelBuilder.Entity("Core.City", b =>
                {
                    b.Property<long>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CityID"));

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CountryID")
                        .HasColumnType("bigint");

                    b.Property<long>("StateID")
                        .HasColumnType("bigint");

                    b.HasKey("CityID");

                    b.HasIndex("CountryID");

                    b.HasIndex("StateID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Core.Country", b =>
                {
                    b.Property<long>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CountryID"));

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.ToTable("CountryTbl");
                });

            modelBuilder.Entity("Core.Floor", b =>
                {
                    b.Property<long>("FloorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("FloorID"));

                    b.Property<long>("BuildingID")
                        .HasColumnType("bigint");

                    b.Property<long>("FloorNumber")
                        .HasColumnType("bigint");

                    b.HasKey("FloorID");

                    b.HasIndex("BuildingID");

                    b.ToTable("FloorTbl");
                });

            modelBuilder.Entity("Core.Hotel", b =>
                {
                    b.Property<long>("HotelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("HotelID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CityID")
                        .HasColumnType("bigint");

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPersonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GSTINNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsGSTApplicable")
                        .HasColumnType("bit");

                    b.Property<string>("LogoFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebSiteUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelID");

                    b.HasIndex("CityID");

                    b.ToTable("HotelTbl");
                });

            modelBuilder.Entity("Core.HotelRating", b =>
                {
                    b.Property<long>("HotelRatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("HotelRatingID"));

                    b.Property<long>("HotelID")
                        .HasColumnType("bigint");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("HotelRatingID");

                    b.HasIndex("HotelID");

                    b.HasIndex("UserID");

                    b.ToTable("HotelRatingTbl");
                });

            modelBuilder.Entity("Core.Invoice", b =>
                {
                    b.Property<long>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("InvoiceID"));

                    b.Property<decimal>("DiscountAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TaxAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TaxPercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("InvoiceID");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("Core.InvoiceTax", b =>
                {
                    b.Property<long>("InvoiceTaxID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("InvoiceTaxID"));

                    b.Property<decimal>("CGSTAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("IGSTAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("InvoiceID")
                        .HasColumnType("bigint");

                    b.Property<long>("SGSTAmount")
                        .HasColumnType("bigint");

                    b.HasKey("InvoiceTaxID");

                    b.HasIndex("InvoiceID");

                    b.ToTable("InvoiceTaxTbl");
                });

            modelBuilder.Entity("Core.Payment", b =>
                {
                    b.Property<long>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PaymentID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("BookingRoomID")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsAdvance")
                        .HasColumnType("bit");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.HasKey("PaymentID");

                    b.HasIndex("BookingRoomID");

                    b.ToTable("PaymentTbl");
                });

            modelBuilder.Entity("Core.Room", b =>
                {
                    b.Property<long>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RoomID"));

                    b.Property<long>("FloorID")
                        .HasColumnType("bigint");

                    b.Property<long>("MaxNoofAdults")
                        .HasColumnType("bigint");

                    b.Property<long>("MaxNoofChilds")
                        .HasColumnType("bigint");

                    b.Property<long>("RoomCategoryID")
                        .HasColumnType("bigint");

                    b.Property<long>("RoomCharges")
                        .HasColumnType("bigint");

                    b.Property<long>("RoomNumber")
                        .HasColumnType("bigint");

                    b.HasKey("RoomID");

                    b.HasIndex("FloorID");

                    b.HasIndex("RoomCategoryID");

                    b.ToTable("RoomTbl");
                });

            modelBuilder.Entity("Core.RoomBed", b =>
                {
                    b.Property<long>("RoomBedID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RoomBedID"));

                    b.Property<long>("BedTypeID")
                        .HasColumnType("bigint");

                    b.Property<long>("NoofBeds")
                        .HasColumnType("bigint");

                    b.HasKey("RoomBedID");

                    b.HasIndex("BedTypeID");

                    b.ToTable("RoomBedTbl");
                });

            modelBuilder.Entity("Core.RoomCategory", b =>
                {
                    b.Property<long>("RoomCatgeoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RoomCatgeoryID"));

                    b.Property<decimal>("BaseCharges")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("HotelID")
                        .HasColumnType("bigint");

                    b.Property<string>("RoomCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomCatgeoryID");

                    b.HasIndex("HotelID");

                    b.ToTable("RoomCatgeoryTbl");
                });

            modelBuilder.Entity("Core.RoomPhoto", b =>
                {
                    b.Property<long>("RoomPhotoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RoomPhotoID"));

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RoomID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RoomPhotoID");

                    b.HasIndex("RoomID");

                    b.ToTable("RoomPhototTbl");
                });

            modelBuilder.Entity("Core.RoomService", b =>
                {
                    b.Property<long>("RoomServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RoomServiceID"));

                    b.Property<long>("HotelID")
                        .HasColumnType("bigint");

                    b.Property<long>("RoomCategoryID")
                        .HasColumnType("bigint");

                    b.Property<string>("RoomServiceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RoomServicePrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("RoomServiceID");

                    b.HasIndex("HotelID");

                    b.HasIndex("RoomCategoryID");

                    b.ToTable("RoomServiceTbl");
                });

            modelBuilder.Entity("Core.State", b =>
                {
                    b.Property<long>("StateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("StateID"));

                    b.Property<long>("CountryID")
                        .HasColumnType("bigint");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateID");

                    b.HasIndex("CountryID");

                    b.ToTable("StateTbl");
                });

            modelBuilder.Entity("Core.Tax", b =>
                {
                    b.Property<long>("TaxID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TaxID"));

                    b.Property<decimal>("CGSTRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HSNSACNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("IGSTRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SGSTRate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("TaxID");

                    b.ToTable("TaxTbl");
                });

            modelBuilder.Entity("Core.User", b =>
                {
                    b.Property<long>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CityID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateofBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("CityID");

                    b.ToTable("UserTbl");
                });

            modelBuilder.Entity("Core.BedType", b =>
                {
                    b.HasOne("Core.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Core.Booking", b =>
                {
                    b.HasOne("Core.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.BookingCheckIn", b =>
                {
                    b.HasOne("Core.BookingRoom", "BookingRoom")
                        .WithMany()
                        .HasForeignKey("BookingRoomID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BookingRoom");
                });

            modelBuilder.Entity("Core.BookingCheckOut", b =>
                {
                    b.HasOne("Core.BookingRoom", "BookingRoom")
                        .WithMany()
                        .HasForeignKey("BookingRoomID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BookingRoom");
                });

            modelBuilder.Entity("Core.BookingRoom", b =>
                {
                    b.HasOne("Core.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Building", b =>
                {
                    b.HasOne("Core.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Core.CancelBooking", b =>
                {
                    b.HasOne("Core.BookingRoom", "BookingRoom")
                        .WithMany()
                        .HasForeignKey("BookingRoomID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BookingRoom");
                });

            modelBuilder.Entity("Core.City", b =>
                {
                    b.HasOne("Core.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.State", "State")
                        .WithMany()
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("State");
                });

            modelBuilder.Entity("Core.Floor", b =>
                {
                    b.HasOne("Core.Building", "Building")
                        .WithMany()
                        .HasForeignKey("BuildingID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Building");
                });

            modelBuilder.Entity("Core.Hotel", b =>
                {
                    b.HasOne("Core.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Core.HotelRating", b =>
                {
                    b.HasOne("Core.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.InvoiceTax", b =>
                {
                    b.HasOne("Core.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("Core.Payment", b =>
                {
                    b.HasOne("Core.BookingRoom", "BookingRoom")
                        .WithMany()
                        .HasForeignKey("BookingRoomID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BookingRoom");
                });

            modelBuilder.Entity("Core.Room", b =>
                {
                    b.HasOne("Core.Floor", "Floor")
                        .WithMany()
                        .HasForeignKey("FloorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.RoomCategory", "RoomCategory")
                        .WithMany()
                        .HasForeignKey("RoomCategoryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Floor");

                    b.Navigation("RoomCategory");
                });

            modelBuilder.Entity("Core.RoomBed", b =>
                {
                    b.HasOne("Core.BedType", "BedType")
                        .WithMany()
                        .HasForeignKey("BedTypeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BedType");
                });

            modelBuilder.Entity("Core.RoomCategory", b =>
                {
                    b.HasOne("Core.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Core.RoomPhoto", b =>
                {
                    b.HasOne("Core.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Core.RoomService", b =>
                {
                    b.HasOne("Core.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.RoomCategory", "RoomCategory")
                        .WithMany()
                        .HasForeignKey("RoomCategoryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("RoomCategory");
                });

            modelBuilder.Entity("Core.State", b =>
                {
                    b.HasOne("Core.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Core.User", b =>
                {
                    b.HasOne("Core.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });
#pragma warning restore 612, 618
        }
    }
}
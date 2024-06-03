using Core;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> opt) : base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            foreach(var relationship in mb.Model.GetEntityTypes().SelectMany(e=>e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            mb.Entity<Admin>().HasData(
               new Admin()
               {
                   AdminID = 1,
                   FirstName = "Rushikesh",
                   LastName = "Kadam",
                   EmailID = "rskadam1176@gmail.com",
                   MobileNo = "8208391176",
                   Password = "rsk@1176",
               });
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<BedType> BedTypes { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingCheckIn> BookingsCheckIn { get; set;}
        public DbSet<BookingCheckOut> BookingsCheckOut { get; set;}
        public DbSet<BookingRoom> BookingsRooms { get; set;}
        public DbSet<Building> Buildings { get; set; }
        public DbSet<CancelBooking> CancelBooking { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRating> HotelRatings { get; set;}
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceTax> InvoicesTax { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomBed> RoomBeds { get; set;}
        public DbSet<RoomCategory> RoomCategories { get; set; }
        public DbSet<RoomPhoto> RoomPhotos { get; set; }
        public DbSet<RoomService> RoomService { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Tax> Taxs { get; set; }
        public DbSet<User> Users { get; set; }

    }
}

using Core;
using Infra;
using Microsoft.EntityFrameworkCore;
using Repo;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(
      opt =>
      {
          opt.Cookie.HttpOnly = true;
          opt.IdleTimeout = TimeSpan.FromMinutes(20);
          opt.Cookie.IsEssential = true;
      }
     );
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CompanyContext>(
    opt => opt.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("scon"))
    );

builder.Services.AddScoped<IAdminRepo,AdminRepo>();
builder.Services.AddScoped<ICountryRepo, CountryRepo>();
builder.Services.AddScoped<IStateRepo, StateRepo>();
builder.Services.AddScoped<ICityRepo, CityRepo>();
builder.Services.AddScoped<ITaxRepo, TaxRepo>();
builder.Services.AddScoped<IHotelRepo,HotelRepo>();
builder.Services.AddScoped<IRoomCategoryRepo,RoomCategoryRepo>();
builder.Services.AddScoped<IBedTypeRepo, BedTypeRepo>();
builder.Services.AddScoped<IBuildingRepo,BuildingRepo>();
builder.Services.AddScoped<IFloorRepo,FloorRepo>();
builder.Services.AddScoped<IRoomRepo,RoomRepo>();
builder.Services.AddScoped<IRoomServiceRepo,RoomServiceRepo>();
builder.Services.AddScoped<IBookingRoomRepo,BookingRoomRepo>();
builder.Services.AddScoped<IBookingRepo,BookingRepo>();
builder.Services.AddScoped<ICheckInRepo, CheckInRepo>();
builder.Services.AddScoped<ICheckOutRepo, CheckOutRepo>();
builder.Services.AddScoped<IInvoiceRepo, InvoiceRepo>();
builder.Services.AddScoped<IPaymentRepo, PaymentRepo>();
builder.Services.AddScoped<ICancelBookingRepo, CancelBookingRepo>();
builder.Services.AddScoped<IRoomPhotosRepo,RoomPhotosRepo>();
builder.Services.AddScoped<IUserRepo,UserRepo>();

var app = builder.Build();
app.UseStaticFiles();
app.UseSession();
app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );
app.MapDefaultControllerRoute();
app.Run();

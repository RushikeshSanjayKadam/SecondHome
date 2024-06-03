using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IBookingRepo : IGenRepo<Booking>
    {
        List<Booking> GetAll();
        Booking GetByID(Int64 id);
        RepoResultVM Add(Booking rec);
        RepoResultVM Update(Booking rec);
        RepoResultVM Delete(Int64 id);
        List<Booking> GetNewBookings();
        List<Booking> GetBookings(Int64 id);
    }
}

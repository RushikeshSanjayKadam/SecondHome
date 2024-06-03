using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface ICheckInRepo : IGenRepo<BookingCheckIn>
    {
        List<BookingCheckIn> GetAll();
        RepoResultVM Add(BookingCheckIn rec);
        RepoResultVM Update(BookingCheckIn rec);
        RepoResultVM Delete(Int64 id);
        List<BookingCheckIn> GetCheckIns();
        List<BookingCheckIn> GetBookingCheckIns(Int64 id);
    }
}

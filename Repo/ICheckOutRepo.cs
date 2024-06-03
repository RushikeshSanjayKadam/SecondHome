using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface ICheckOutRepo : IGenRepo<BookingCheckOut>
    {
        List<BookingCheckOut> GetAll();
        List<BookingCheckOut> GetCheckOuts();
        List<BookingCheckOut> GetCheckOutsfromCheckIns(Int64 id);
        BookingCheckOut GetByID(Int64 id);
        RepoResultVM Add(BookingCheckOut rec, Int64 rid);
        RepoResultVM Update(BookingCheckOut rec);
        RepoResultVM Delete(Int64 id);
    }
}

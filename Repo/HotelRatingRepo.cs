using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class HotelRatingRepo : GenRepo<HotelRating> , IHotelRatingRepo
    {
        CompanyContext cc;

        public HotelRatingRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }
    }
}

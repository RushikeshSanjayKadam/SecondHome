using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class CancelBookingRepo:GenRepo<CancelBooking>, ICancelBookingRepo
    {
        CompanyContext cc;

        public CancelBookingRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }
    }
}

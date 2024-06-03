using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class RoomBedRepo:GenRepo<RoomBed>, IRoomBedRepo
    {
        CompanyContext cc;

        public RoomBedRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }
    }
}

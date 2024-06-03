using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class RoomServiceRepo : GenRepo<RoomService>, IRoomServiceRepo
    {
        CompanyContext cc;
        public RoomServiceRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

        public List<RoomService> GetById(int id)
        {
            return this.cc.RoomService.Where(p=>p.HotelID==id).ToList();
        }
    }
}

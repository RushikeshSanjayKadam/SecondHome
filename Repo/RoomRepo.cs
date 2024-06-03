using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class RoomRepo:GenRepo<Room>, IRoomRepo
    {
        CompanyContext cc;
        public RoomRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }
        public List<Room> GetById(int id)
        {
            return this.cc.Rooms.Where(p=>p.Floor.Building.HotelID==id).ToList();
        }
    }
}

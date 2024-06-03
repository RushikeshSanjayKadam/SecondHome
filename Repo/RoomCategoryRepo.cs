using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class RoomCategoryRepo:GenRepo<RoomCategory>,IRoomCategoryRepo
    {
        CompanyContext cc;
        public RoomCategoryRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

        public List<RoomCategory> GetByID(long id)
        {
            return this.cc.RoomCategories.Where(p=>p.HotelID==id).ToList();
        }

        public List<RoomCategory> GetHotelsByRoomCategories(long id)
        {
                var v = from t in this.cc.RoomCategories
                        where (from t1 in this.cc.Hotels
                                select t1.CityID)
                                .Contains(t.Hotel.CityID)
                        select t;
                return v.ToList();
        }
    }
}

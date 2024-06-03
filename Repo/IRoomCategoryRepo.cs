using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IRoomCategoryRepo:IGenRepo<RoomCategory>
    {
        List<RoomCategory> GetByID(Int64 id);
        List<RoomCategory> GetHotelsByRoomCategories(Int64 id);
    }
}

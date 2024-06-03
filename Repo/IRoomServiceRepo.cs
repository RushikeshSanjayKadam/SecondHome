using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IRoomServiceRepo : IGenRepo<RoomService>
    {
        List<RoomService> GetById(int id);
    }
}

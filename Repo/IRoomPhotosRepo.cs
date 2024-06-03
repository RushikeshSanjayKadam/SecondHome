using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IRoomPhotosRepo:IGenRepo<RoomPhoto>
    {
        List<RoomPhoto> GetAll();
        RoomPhoto GetByID(Int64 id);
        RepoResultVM Add(RoomPhoto rec);
        RepoResultVM Update(RoomPhoto rec);
        RepoResultVM Delete(Int64 id);
    }
}

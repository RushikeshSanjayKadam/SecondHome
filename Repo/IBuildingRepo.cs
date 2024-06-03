using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IBuildingRepo:IGenRepo<Building>
    {
        List<Building> GetById(int id);
    }
}

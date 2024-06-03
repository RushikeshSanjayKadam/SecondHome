using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IBedTypeRepo:IGenRepo<BedType>
    {
        List<BedType> GetById(int id);
    }
}

using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class FloorRepo:GenRepo<Floor>,IFloorRepo
    {
        CompanyContext cc;
        public FloorRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

        public List<Floor> GetById(int id)
        {
            return this.cc.Floors.Where(p=>p.Building.HotelID==id).ToList();
        }
    }
}

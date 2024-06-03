using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class BuildingRepo:GenRepo<Building>,IBuildingRepo
    {
        CompanyContext cc;

        public BuildingRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

        public List<Building> GetById(int id)
        {
            return this.cc.Buildings.Where(p=>p.HotelID==id).ToList();
        }
    }
}

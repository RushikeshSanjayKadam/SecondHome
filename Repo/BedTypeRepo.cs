using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class BedTypeRepo : GenRepo<BedType>, IBedTypeRepo
    {
        CompanyContext cc;

        public BedTypeRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

        public List<BedType> GetById(int id)
        {
            return this.cc.BedTypes.Where(p=>p.HotelID==id).ToList();
        }
    }
}

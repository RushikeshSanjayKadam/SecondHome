using Core;
using Infra;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class CityRepo : GenRepo<City>, ICityRepo
    {
        CompanyContext cc;

        public CityRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<CityVM> GetCityByStateID(long StateID)
        {
            var v = from t in this.cc.Cities
                    where t.StateID == StateID
                    select new CityVM
                    {
                        CityID = t.CityID,
                        CityName = t.CityName,
                    };
            return v.ToList();
        }

    }

}

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
    public class StateRepo : GenRepo<State> , IStateRepo
    {
        CompanyContext cc;

        public StateRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

        public List<StateVM> GetStateByCountryID(long id)
        {
            var v = from t in this.cc.States
                    where t.CountryID == id
                    select new StateVM
                    {
                        StateID = t.StateID,
                        StateName = t.StateName,
                    };
            return v.ToList();
        }
    }
}

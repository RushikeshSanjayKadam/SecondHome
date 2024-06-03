using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class TaxRepo:GenRepo<Tax>,ITaxRepo
    {
        CompanyContext cc;
        public TaxRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }
    }
}

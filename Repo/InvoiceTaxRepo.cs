using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public class InvoiceTaxRepo:GenRepo<InvoiceTax> , IInvoiceTaxRepo
    {
        CompanyContext cc;
        public InvoiceTaxRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }

    }
}

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
    public class PaymentRepo:GenRepo<Payment>, IPaymentRepo
    {
        CompanyContext cc;
        public PaymentRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }
    }
}

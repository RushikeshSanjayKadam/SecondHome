using Core;
using Repo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo
{
    public interface IInvoiceRepo : IGenRepo<Invoice>
    {
        List<Invoice> GetAll();
        List<Invoice> GetInvoices(Int64 id);
        Invoice GetByID(Int64 id);
        RepoResultVM Add(BillDetailsVM rec);
        RepoResultVM Update(Invoice rec);
        RepoResultVM Delete(Int64 id);
    }
}

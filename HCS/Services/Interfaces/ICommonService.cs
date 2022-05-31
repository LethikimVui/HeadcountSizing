using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICommonService
    {
        Task<List<VCustomer>> GetWCAsync(int WCId, string token);
        Task<List<VCustomer>> GetWCByNTIDAsync(string Ntlogin, string token);
        Task<List<VShift>> GetShift();
        Task<List<VFiscalYear>> Master_FiscalYear_get();
        Task<List<VDowntime>> GetDowntimeDetailByDowntimeTypeTechAsync(GetDowntimeViewModel model);
        Task<List<VDowntime>> GetDowntimeDetailByDowntimeTypeOperatorAsync(GetDowntimeViewModel model);
        Task<List<VDowntime>> Master_Downtime_get_bydowntimetype(string downtimetype);


        Task<List<VSummary>> Summary(SummaryViewModel model);

    }
}

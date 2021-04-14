using SharedObjects.Common;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IDebugService
    {      
        Task<ResponseResult> AddDebugRawData(AddDebugRawDataViewModel model);
        Task<ResponseResult> UpdateDebugRawData(AddDebugRawDataViewModel model);
      
        Task<List<VDebugRawData>> GetDebugRawDataByWCAsync(string wc);
        Task<ResponseResult> UpdateDebugRawDataAsync(UpdateDebugRawDataByWCandMonthViewModel model);
        Task<ResponseResult> AddDebugDataAsync(AddDebugDataViewModel model);
        Task<ResponseResult> AddActualLockedOperatorAsync(AddActualLoggedViewModel model);
        Task<List<VDebugData>> GetDebugDataByWCAsync(string wc);
        Task<ResponseResult> DeleteDebugDataByIdAsync(DeleteSingleDebugDataByIdViewModel model);
        Task<ResponseResult> UpdateDebugAsync(UpdateSingleDebugDataByIdViewModel model);
        Task<List<VDebugResult>> GetDebugResultAsync(string wc);
        Task<ResponseResult> UpdateDebugTechAsync(UpdateLockedHeadcountViewModel model);

        Task<List<VWC>> GetAllAsync();

    }
}

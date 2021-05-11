using SharedObjects.Commons;
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
        Task<List<VRawData>> GetRawDataAsync(string token, int wcId);
        Task<ResponseResult> AddRawDataAsync(AddRawDataViewModel model, string token);
        Task<ResponseResult> UpdateRawDataAsync(AddRawDataViewModel model, string token);
        Task<List<VDebugData>> GetDebugDataAsync(string token, int wcId);
        Task<ResponseResult> UpdateDebugDataAsync(DebugDataViewModel model, string token);
        Task<ResponseResult> AddDebugDataAsync(DebugDataViewModel model, string token);
        Task<ResponseResult> DeleteAsync(DebugDataViewModel model, string token);
        Task<List<VDebugResult>> GetDebugResultAsync(string token, int wcId);
        Task<ResponseResult> UpdateDebugTechAsync(UpdateHeadcountViewModel model, string token);

    }
}

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
    public interface ITestTechService
    {
        Task<List<VStation>> GetallStationAsync(int wcId, string token);
        Task<List<VEquipmentQuantity>> GetEquipmentQuantityAsync(GetEquipmentQuantity model, string token);
        Task<ResponseResult> AddStationDataAsync(AddStationDataViewModel model, string token);
        Task<List<VDowntime>> GetDowntimeTypeAndDowntimeDetailAsync(int wcId);
        Task<List<VActivities>> GetAllDowntimeByWCAsync(int wcId, string token);
        Task<ResponseResult> UpdateDowntimeAsync(UpdateDowntimeViewModel model, string token);
        Task<ResponseResult> UpdateStationQuantityAsync(UpdateStationQuantityViewModel model, string token);
        Task<List<VTestResult>> GetFinalResultAsync(int wcId, string token);
        Task<ResponseResult> UpdateTestTechAsync(UpdateLockedHeadcountViewModel model, string token);


    }
}

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
    public interface ITestTechService
    {
        Task<List<VTestResult>> GetFinalResultAsync(string wc);
        Task<List<VStation>> GetallStation(string wc);
        Task<List<VDowntime>> GetallDowntimeDetailAsync(string wc);
        Task<List<VDowntime>> GetDowntimeDetailByDowntimeTypeAsync(GetDowntimeViewModel model);
        Task<List<VActivities>> GetAllDowntimeByWC(string wc);
        Task<List<VEquipmentQuantity>> EquipmentQuantityAsync(GetEquipmentQuantity model);
        Task<ResponseResult> AddStationDataAsync(AddStationDataViewModel model);
        Task<ResponseResult> UpdateStationQuantityAsync(UpdateStationQuantityViewModel model);
        Task<ResponseResult> UpdateDowntime(UpdateDowntimeViewModel model);
        Task<ResponseResult> UpdateTestTechAsync(UpdateLockedHeadcountViewModel model);


    }
}

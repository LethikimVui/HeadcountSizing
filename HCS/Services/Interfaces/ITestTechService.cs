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
        Task<List<VStation>> Equipment_GetStationList_technician(TestViewModel model);
        Task<List<VEquipmentQuantity>> GetEquipmentQuantityAsync(GetEquipmentQuantity model, string token);
        Task<ResponseResult> Equipment_add(AddStationDataViewModel model);
        Task<List<VDowntime>> GetDowntimeTypeAndDowntimeDetailAsync(int wcId);
        Task<List<VDowntime>> Activities_get_DowntimeTypeAndDowntimeDetail(TestViewModel model);
        
        Task<List<VActivities>> GetAllDowntimeByWCAsync(int wcId, string token);
        Task<List<VActivities>> GetAllDowntimeByWC(TestViewModel model);
        Task<ResponseResult> UpdateDowntime(UpdateDowntimeViewModel model);
        Task<ResponseResult> UpdateStationQuantityAsync(UpdateStationQuantityViewModel model, string token);
        Task<List<VTestResult>> Result_test_technician_calculation(TestViewModel model);
        Task<ResponseResult> UpdateTestTechAsync(UpdateLockedHeadcountViewModel model);


        Task<ResponseResult> Test_Equipment_add(TestViewModel model);


    }
}

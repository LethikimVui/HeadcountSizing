using Newtonsoft.Json;
using Services.Interfaces;
using SharedObjects.Common;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class TestTechService : BaseService, ITestTechService
    {
        public async Task<ResponseResult> AddStationDataAsync(AddStationDataViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/LineSupport/AddStationData", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VEquipmentQuantity>> EquipmentQuantityAsync(GetEquipmentQuantity model)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            List<VEquipmentQuantity> quantity = new List<VEquipmentQuantity>();

            using (var response = await httpClient.PostAsync("api/LineSupport/getquantity", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                quantity = JsonConvert.DeserializeObject< List<VEquipmentQuantity>>(apiResponse);
            }
            return quantity;
        }

        public async Task<List<VStation>> GetallStation(string wc)
        {
            List<VStation> stations = new List<VStation>();

            using (var response = await httpClient.GetAsync("api/LineSupport/getallstation/" + wc))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                stations = JsonConvert.DeserializeObject<List<VStation>>(apiResponse);
            }
            return stations;
        }

        public async Task<ResponseResult> UpdateStationQuantityAsync(UpdateStationQuantityViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/LineSupport/UpdateStationQuantity", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
        public async Task<ResponseResult> UpdateDowntime(UpdateDowntimeViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/LineSupport/UpdateDowntime", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VDowntime>> GetallDowntimeDetailAsync(string wc)
        {
            List<VDowntime> downtimedetail = new List<VDowntime>();

            using (var response = await httpClient.GetAsync("api/LineSupport/getalldowntimedetail/" + wc))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                downtimedetail = JsonConvert.DeserializeObject<List<VDowntime>>(apiResponse);
            }
            return downtimedetail;
        }

        public async Task<List<VActivities>> GetAllDowntimeByWC(string wc)
        {
            List<VActivities> test = new List<VActivities>();

            using (var response = await httpClient.GetAsync("api/LineSupport/getalldowntimebywc/" + wc))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                test = JsonConvert.DeserializeObject<List<VActivities>>(apiResponse);
            }
            return test;
        }

        public async Task<List<VTestResult>> GetFinalResultAsync(string wc)
        {
            List<VTestResult> downtimedetail = new List<VTestResult>();

            using (var response = await httpClient.GetAsync("api/LineSupport/getfinalresult/" + wc))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                downtimedetail = JsonConvert.DeserializeObject<List<VTestResult>>(apiResponse);
            }
            return downtimedetail;
        }

       

        public async Task<List<VDowntime>> GetDowntimeDetailByDowntimeTypeAsync(GetDowntimeViewModel model)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            List<VDowntime> downtimedetail = new List<VDowntime>();

            using (var response = await httpClient.PostAsync("api/LineSupport/GetDowntimeDetailByDowntimeType/", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                downtimedetail = JsonConvert.DeserializeObject<List<VDowntime>>(apiResponse);
            }
            return downtimedetail;
        }

        public async Task<ResponseResult> UpdateTestTechAsync(UpdateLockedHeadcountViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/LineSupport/UpdateTestTech", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
    }
}

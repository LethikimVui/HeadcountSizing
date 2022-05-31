using Newtonsoft.Json;
using Services.Interfaces;
using SharedObjects.Commons;
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
    public class TestOperatorService : BaseService, ITestOperatorService
    {
        public async Task<ResponseResult> AddStationDataAsync(AddStationDataViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/TestOperator/AddStationData", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VDowntime>> GetDowntimeTypeAndDowntimeDetailAsync(int wcId)
        {
            List<VDowntime> downtimedetail = new List<VDowntime>();

            using (var response = await httpClient.GetAsync("api/TestOperator/getalldowntime/" + wcId))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                downtimedetail = JsonConvert.DeserializeObject<List<VDowntime>>(apiResponse);
            }
            return downtimedetail;
        }

        public async Task<List<VStation>> GetallStationAsync(int wcId, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            List<VStation> stations = new List<VStation>();

            using (var response = await httpClient.GetAsync("api/TestOperator/GetStationList/" + wcId))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                stations = JsonConvert.DeserializeObject<List<VStation>>(apiResponse);
            }
            return stations;
        }

        public async Task<List<VEquipmentQuantity>> GetEquipmentQuantityAsync(GetEquipmentQuantity model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            List<VEquipmentQuantity> quantity = new List<VEquipmentQuantity>();

            using (var response = await httpClient.PostAsync("api/TestOperator/getquantity", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                quantity = JsonConvert.DeserializeObject<List<VEquipmentQuantity>>(apiResponse);
            }
            return quantity;

        }

        public async Task<List<VActivities>> GetAllDowntimeByWCAsync(int wcId, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            List<VActivities> results = new List<VActivities>();

            using (var response = await httpClient.GetAsync("api/TestOperator/getalldowntimebywc/" + wcId))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VActivities>>(apiResponse);
            }
            return results;
        }

        public async Task<ResponseResult> UpdateDowntimeAsync(UpdateDowntimeViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/TestOperator/UpdateDowntime", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<ResponseResult> UpdateStationQuantityAsync(UpdateStationQuantityViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/TestOperator/UpdateStationQuantity", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VTestResult>> GetFinalResultAsync(int wcId, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            List<VTestResult> result = new List<VTestResult>();

            using (var response = await httpClient.GetAsync("api/TestOperator/getfinalresult/" + wcId))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<VTestResult>>(apiResponse);
            }
            return result;
        }

        public async Task<ResponseResult> UpdateTestTechAsync(UpdateLockedHeadcountViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/TestOperator/UpdateTestTech", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
    }
}

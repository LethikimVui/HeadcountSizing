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
    public class TestTechService : BaseService, ITestTechService
    {
        public async Task<ResponseResult> Equipment_add(AddStationDataViewModel model)
        {
            //httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/TestTech/Equipment_add", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VDowntime>> GetDowntimeTypeAndDowntimeDetailAsync(int wcId)
        {
            List<VDowntime> downtimedetail = new List<VDowntime>();

            using (var response = await httpClient.GetAsync("api/TestTech/getalldowntime/" + wcId))
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

            using (var response = await httpClient.GetAsync("api/TestTech/GetStationList/" + wcId))
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

            using (var response = await httpClient.PostAsync("api/TestTech/getquantity", content))
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

            using (var response = await httpClient.GetAsync("api/TestTech/getalldowntimebywc/" + wcId))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VActivities>>(apiResponse);
            }
            return results;
        }

        public async Task<ResponseResult> UpdateDowntime(UpdateDowntimeViewModel model)
        {
            //httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/TestTech/UpdateDowntime", content))
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
            using (var response = await httpClient.PostAsync("api/TestTech/UpdateStationQuantity", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VTestResult>> Result_test_technician_calculation(TestViewModel model)
        {
            List<VTestResult> result = new List<VTestResult>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/TestTech/Result_test_technician_calculation/", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<VTestResult>>(apiResponse);
            }
            return result;
        }

        public async Task<ResponseResult> UpdateTestTechAsync(UpdateLockedHeadcountViewModel model)
        {
            //httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/TestTech/UpdateTestTech", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VStation>> Equipment_GetStationList_technician(TestViewModel model)
        {
            List<VStation> stations = new List<VStation>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/TestTech/Equipment_GetStationList_technician/", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                stations = JsonConvert.DeserializeObject<List<VStation>>(apiResponse);
            }
            return stations;
        }

        public async Task<List<VDowntime>> Activities_get_DowntimeTypeAndDowntimeDetail(TestViewModel model)
        {
            List<VDowntime> downtimedetail = new List<VDowntime>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/TestTech/Activities_get_DowntimeTypeAndDowntimeDetail/", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                downtimedetail = JsonConvert.DeserializeObject<List<VDowntime>>(apiResponse);
            }
            return downtimedetail;
        }

        public async Task<List<VActivities>> GetAllDowntimeByWC(TestViewModel model)
        {
            List<VActivities> results = new List<VActivities>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/TestTech/getalldowntimebywc/", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VActivities>>(apiResponse);
            }
            return results;
        }

        public async Task<ResponseResult> Test_Equipment_add(TestViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/TestTech/Test_Equipment_add", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
    }
}

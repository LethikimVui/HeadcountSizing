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
    public class DebugService : BaseService, IDebugService
    {
        public async Task<ResponseResult> AddDebugDataAsync(DebugDataViewModel model, string token)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/AddDebugData", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<ResponseResult> AddRawDataAsync(AddRawDataViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/addRawData", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<ResponseResult> DeleteAsync(DebugDataViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/delete", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VDebugData>> GetDebugDataAsync(string token, int wcId)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            List<VDebugData> debugData = new List<VDebugData>();

            using (var response = await httpClient.GetAsync("api/debug/getactive/" + wcId))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                debugData = JsonConvert.DeserializeObject<List<VDebugData>>(apiResponse);
            }
            return debugData;
        }

        public async Task<List<VDebugResult>> Result_Debug_calculation(DebugDataViewModel model)
        {
            var results = new List<VDebugResult>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/Result_Debug_calculation", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VDebugResult>>(apiResponse);
            }
            return results;
        }

        public async Task<List<VDebugResult>> GetDebugResultAsync(string token, int wcId)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            List<VDebugResult> debugResult = new List<VDebugResult>();

            using (var response = await httpClient.GetAsync("api/debug/getresult/" + wcId))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                debugResult = JsonConvert.DeserializeObject<List<VDebugResult>>(apiResponse);
            }
            return debugResult;
        }

        public async Task<List<VRawData>> GetRawData(AddRawDataViewModel model)
        {
            var results = new List<VRawData>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/GetRawData", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VRawData>>(apiResponse);
            }
            return results;
        }

        public async Task<List<VRawData>> GetRawDataAsync(string token, int wcId)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            List<VRawData> debugData = new List<VRawData>();

            using (var response = await httpClient.GetAsync("api/debug/GetRawData/" + wcId))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                debugData = JsonConvert.DeserializeObject<List<VRawData>>(apiResponse);
            }
            return debugData;
        }

        public async Task<ResponseResult> UpdateDebugDataAsync(DebugDataViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/UpdateDebugData", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<ResponseResult> UpdateDebugTechAsync(UpdateHeadcountViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/UpdateDebugTech", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<ResponseResult> UpdateRawDataAsync(AddRawDataViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/UpdateRawData", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VDebugData>> Debug_Data_getactive(DebugDataViewModel model)
        {
            var results = new List<VDebugData>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/Debug_Data_getactive", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VDebugData>>(apiResponse);
            }
            return results;
        }
    }
}

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
    public class DebugService : BaseService, IDebugService
    {
        public async Task<ResponseResult> AddDebugDataAsync(AddDebugDataViewModel model)
        {

            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/addDebugData", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<ResponseResult> AddDebugRawData(AddDebugRawDataViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/AddDebugRawData", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
        public async Task<ResponseResult> UpdateDebugRawData(AddDebugRawDataViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/UpdateDebugRawData", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VWC>> GetAllAsync()
        {
            List<VWC> WCs = new List<VWC>();

            using (var response = await httpClient.GetAsync("api/debug/getallwc"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                WCs = JsonConvert.DeserializeObject<List<VWC>>(apiResponse);
            }
            return WCs;
        }

        public async Task<List<VDebugData>> GetDebugDataByWCAsync(string wc)
        {
            List<VDebugData> debugData = new List<VDebugData>();

            using (var response = await httpClient.GetAsync("api/debug/getallactivedebugdatabywc/" + wc))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                debugData = JsonConvert.DeserializeObject<List<VDebugData>>(apiResponse);
            }
            return debugData;
        }     

        public async Task<List<VDebugRawData>> GetDebugRawDataByWCAsync(string wc)
        {
            List<VDebugRawData> debugData = new List<VDebugRawData>();

            using (var response = await httpClient.GetAsync("api/debug/DebugRawData_getallbyWC/" + wc))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                debugData = JsonConvert.DeserializeObject<List<VDebugRawData>>(apiResponse);
            }
            return debugData;
        }



        

        public async Task<List<VDebugResult>> GetDebugResultAsync(string wc)
        {
            List<VDebugResult> debugResult = new List<VDebugResult>();

            using (var response = await httpClient.GetAsync("api/debug/getdebugresult/" + wc))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                debugResult = JsonConvert.DeserializeObject<List<VDebugResult>>(apiResponse);
            }
            return debugResult;
        }

        public async Task<VDebugData> GetSingleDebugDataByIdAsync(int id)
        {
            VDebugData debugData = new VDebugData();

            using (var response = await httpClient.GetAsync("api/debug/getsingledebugdata/" + id))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                debugData = JsonConvert.DeserializeObject<VDebugData>(apiResponse);
            }
            return debugData;
        }

        public async Task<ResponseResult> UpdateDebugRawDataAsync(UpdateDebugRawDataByWCandMonthViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/updateDebugRawData", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

  
 

        public async Task<ResponseResult> DeleteDebugDataByIdAsync(DeleteSingleDebugDataByIdViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/delete", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<ResponseResult> UpdateDebugTechAsync(UpdateLockedHeadcountViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/UpdateDebugTech", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
        public async Task<ResponseResult> AddActualLockedOperatorAsync(AddActualLoggedViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/AddActualLockedOpertor", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<ResponseResult> UpdateDebugAsync(UpdateSingleDebugDataByIdViewModel model)
        {
            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/debug/UpdateDebug", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }
    }
}


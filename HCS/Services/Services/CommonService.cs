﻿using Newtonsoft.Json;
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
    public class CommonService : BaseService, ICommonService
    {
        public async Task<List<VCustomer>> GetWCAsync(int WCId, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            List<VCustomer> Customers = new List<VCustomer>();
            using (var response = await httpClient.GetAsync("api/common/getWC/" + WCId))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                Customers = JsonConvert.DeserializeObject<List<VCustomer>>(apiResponse);
            }
            return Customers;
        }
        public async Task<List<VCustomer>> GetWCByNTIDAsync(string Ntlogin, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            List<VCustomer> Customers = new List<VCustomer>();
            using (var response = await httpClient.GetAsync("api/common/getWCbyntid/" + Ntlogin))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                Customers = JsonConvert.DeserializeObject<List<VCustomer>>(apiResponse);
            }
            return Customers;
        }
        public async Task<List<VShift>> GetShift()
        {
            //httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            List<VShift> Customers = new List<VShift>();
            using (var response = await httpClient.GetAsync("api/common/GetShift"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                Customers = JsonConvert.DeserializeObject<List<VShift>>(apiResponse);
            }
            return Customers;
        }
        public async Task<List<VDowntime>> GetDowntimeDetailByDowntimeTypeTechAsync(GetDowntimeViewModel model)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            List<VDowntime> downtimedetail = new List<VDowntime>();

            using (var response = await httpClient.PostAsync("api/common/GetDowntimeDetailByDowntimeType_tech/", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                downtimedetail = JsonConvert.DeserializeObject<List<VDowntime>>(apiResponse);
            }
            return downtimedetail;
        }
        public async Task<List<VDowntime>> GetDowntimeDetailByDowntimeTypeOperatorAsync(GetDowntimeViewModel model)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            List<VDowntime> downtimedetail = new List<VDowntime>();

            using (var response = await httpClient.PostAsync("api/common/GetDowntimeDetailByDowntimeType_Op/", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                downtimedetail = JsonConvert.DeserializeObject<List<VDowntime>>(apiResponse);
            }
            return downtimedetail;
        }

        public async Task<List<VSummary>> Summary(SummaryViewModel model)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            var results = new List<VSummary>();
            using (var response = await httpClient.PostAsync("api/common/summary", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VSummary>>(apiResponse);
            }
            return results;
        }

        public async Task<List<VFiscalYear>> Master_FiscalYear_get()
        {
            List<VFiscalYear> fiscalYear = new List<VFiscalYear>();
            using (var response = await httpClient.GetAsync("api/common/Master_FiscalYear_get"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                fiscalYear = JsonConvert.DeserializeObject<List<VFiscalYear>>(apiResponse);
            }
            return fiscalYear;
        }

        public async Task<List<VDowntime>> Master_Downtime_get_bydowntimetype(string downtimetype)
        {
            List<VDowntime> customers = new List<VDowntime>();
            using (var response = await httpClient.GetAsync("api/common/Master_Downtime_get_bydowntimetype/" + downtimetype))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                customers = JsonConvert.DeserializeObject<List<VDowntime>>(apiResponse);
            }
            return customers;
        }
    }
}
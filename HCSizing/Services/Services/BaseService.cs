﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class BaseService
    {
        protected HttpClient httpClient = null;
        public BaseService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://vnhcmm0teapp02/hcsapi/");

            //httpClient.BaseAddress = new Uri("http://localhost:50979");
        }
    }
}

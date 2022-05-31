﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class GetDowntimeViewModel
    {
        public int CustId { get; set; }
        public int FiscalYearId { get; set; }

        public string DowntimeType { get; set; }
        public string DowntimeDetail { get; set; }

    }
}
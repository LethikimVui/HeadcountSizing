﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class TestViewModel
    {
       
        public int CustId { get; set; }
        public int FiscalYearId { get; set; }
        public int Quantity { get; set; }
        public string Station { get; set; }
        public string UpdatedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace HCSizingAPI.Models
{
    public partial class Hc
    {
        public int Id { get; set; }
        public string Wc { get; set; }
        public string Month { get; set; }
        public int? LoggedTech { get; set; }
        public int? LoggedOperator { get; set; }
        public int? FiscalYear { get; set; }
    }
}

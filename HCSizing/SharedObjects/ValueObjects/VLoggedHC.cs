using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VLoggedHC
    {
        public int Id { get; set; }
        public string Wc { get; set; }
        public string Month { get; set; }
        public int? LoggedTech { get; set; }
        public int? LoggedOperator { get; set; }
        public int? FiscalYear { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VEquipmentQuantity
    {
        public string month { get; set; }
        public string stationOrTester { get; set; }
        public int? quantity { get; set; }
    }
}

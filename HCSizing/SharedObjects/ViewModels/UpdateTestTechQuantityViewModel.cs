using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class UpdateTestTechQuantityViewModel
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string UpdatedBy { get; set; }       
    }
}

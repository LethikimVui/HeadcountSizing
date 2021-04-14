using System;
using System.Collections.Generic;

namespace HCSizingAPI.Models
{
    public partial class Wc
    {
        public int Id { get; set; }
        public string Wcname { get; set; }
        public byte? IsActive { get; set; }
    }
}

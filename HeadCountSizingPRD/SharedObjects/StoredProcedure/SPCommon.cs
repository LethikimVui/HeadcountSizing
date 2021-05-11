using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoreProcedure
{
    public class SPCommon
    {
        public static string GetWC = "usp_Master_Customer_select @p0";
        public static string GetWCbyNTID = "usp_Master_Customer_selectbyNTID @p0";
        public static string GetShift = "usp_Master_Shift_select";


        public static string Master_Downtime_get_bydowntimetype_technician = "usp_Master_Downtime_get_bydowntimetype_technician @p0,@p1";
        public static string Master_Downtime_get_bydowntimetype_operator = "usp_Master_Downtime_get_bydowntimetype_operator @p0,@p1";

    }
}

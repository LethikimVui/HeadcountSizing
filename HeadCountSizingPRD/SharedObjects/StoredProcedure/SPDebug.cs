using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoredProcedure
{
    public class SPDebug
    {
        public static string RawData_getbyCust = "usp_RawData_getbyCust @p0";
        public static string RawData_add = "usp_RawData_add @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7";
        public static string RawData_update = "usp_RawData_update @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8";

        public static string Debug_getallactive = "usp_Debug_Data_getactive @p0";
        public static string Debug_Data_update = "usp_Debug_Data_update @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9";
        public static string Debug_Data_add = "usp_Debug_Data_add @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9";
        public static string Debug_Data_delete = "usp_Debug_Data_delete @p0";

        public static string Result_get = "usp_Result_Debug_calculation @p0";
        public static string HeadCount_update = "usp_HeadCount_update_debugtech @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13";

    }
}

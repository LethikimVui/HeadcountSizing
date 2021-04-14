using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoreProcedure
{
    public class SPDebug
    {
        public static string DebugRawData_add = "usp_DebugRawData_add @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7";
        public static string DebugRawData_update = "usp_DebugRawData_update @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8";        
        public static string DebugRawData_getallbyWC = "usp_DebugRawData_getallbyWC @p0";
       
        public static string Debug_add = "usp_Debug_add @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9";
        public static string Debug_getallactive = "usp_Debug_getallactive @p0";

        public static string Debug_update = "usp_Debug_update @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9";

        //

        public static string DeleteDebugDataById = "SP_HCSDeleteDebugDataById @p0";
        public static string AddActualLoggedOperator = "SP_HCSAddActualLoggedOperator @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12";
        //

        public static string CurrentHC_update_debugtech = "usp_CurrentHC_update_debugtech @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13";        
        public static string GetDebugResult = "SP_HCSGetFinalDebugResult @p0";
        public static string GetAllWC = "SP_HCSGetAllWC";      

    }
}

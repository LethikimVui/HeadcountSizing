using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoredProcedure
{
    public class SPTestOperator
    {
        public static string GetStationList = "usp_Equipment_GetStationList_operator @p0";
        public static string Equipment_get_quantity_by_station = "usp_Equipment_get_quantity_by_station_operator @p0,@p1";
        public static string Equipment_add = "usp_Equipment_add_operator @p0,@p1,@p2,@p3,@p4";
        public static string Equipment_update = "usp_Equipment_update_operator @p0,@p1,@p2,@p3,@p4";

        public static string Activities_get_DowntimeTypeAndDowntimeDetail = "usp_Activities_get_DowntimeTypeAndDowntimeDetail_operator @p0";
        public static string Activities_getallbyWC = "usp_Activities_getallbyWC_operator @p0";
        public static string Activities_update = "usp_Activities_update_operator @p0,@p1,@p2,@p3,@p4,@p5";

        public static string CurrentHC_update = "usp_HeadCount_update_testoperator @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13";
        public static string GetFinalResult = "usp_Result_test_operator_calculation @p0";

    }
}

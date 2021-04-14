using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoreProcedure
{
    public class SPTestTech
    {     
        public static string Master_WCDowntime_get_bydowntimetype = "usp_Master_WCDowntime_get_bydowntimetype @p0,@p1";

        public static string GetStationList = "USP_HCS_Equipment_GetStationList @p0";
        public static string get_equipment_quantity_by_Station = "usp_Equipment_get_quantity_by_station @p0,@p1";
        public static string equipment_add_station = "usp_equipment_add_station @p0,@p1,@p2,@p3,@p4,@p5";
        public static string equipment_update_station_quantity = "usp_equipment_update_station_quantity @p0,@p1,@p2,@p3,@p4";

        public static string Activities_update = "usp_Activities_update @p0,@p1,@p2,@p3,@p4,@p5";
        public static string Activities_getallbyWC = "usp_Activities_getallbyWC @p0";
        public static string Activities_get_all_downtimeDetail = "usp_Activities_get_all_downtimeDetail @p0";

        public static string CurrentHC_update_testtech = "usp_CurrentHC_update_testtech @p0,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13";

        public static string GetFinalResult = "test_testtech_calculation @p0";



    }
}

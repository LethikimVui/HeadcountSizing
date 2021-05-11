using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.StoredProcedure
{
    public class SPAdmin
    {
        public static string Access_Role_select = "usp_Access_Role_select";

        public static string Access_UserRole_get = "usp_Access_UserRole_get";
        public static string Access_UserRole_get_byNTLogin = "usp_Access_UserRole_get_byNTLogin @p0";
        public static string Access_UserRole_add = "usp_Access_UserRole_add @p0,@p1,@p2,@p3,@p4,@p5";
        public static string Access_UserRole_delete = "usp_Access_UserRole_delete @p0,@p1";

    }
}

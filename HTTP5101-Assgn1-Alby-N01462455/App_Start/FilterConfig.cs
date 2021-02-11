using System.Web;
using System.Web.Mvc;

namespace HTTP5101_Assgn1_Alby_N01462455
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

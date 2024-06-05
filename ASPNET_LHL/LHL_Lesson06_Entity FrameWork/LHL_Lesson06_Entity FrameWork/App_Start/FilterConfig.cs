using System.Web;
using System.Web.Mvc;

namespace LHL_Lesson06_Entity_FrameWork
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

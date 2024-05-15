using System.Web;
using System.Web.Mvc;

namespace BaiLab_ThucHanh_LHL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

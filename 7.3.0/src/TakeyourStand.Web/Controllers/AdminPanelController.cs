using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TakeyourStand.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AdminPanelController : TakeyourStandControllerBase
    {
        public ActionResult Dashboard()
        {
            return View();
        }
	}
}
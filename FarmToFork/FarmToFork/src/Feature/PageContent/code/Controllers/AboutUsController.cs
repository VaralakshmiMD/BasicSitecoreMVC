using Foundation.Serialization;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;


namespace Feature.PageContent.Controllers
{
    public class AboutUsController : Controller
    {
        public ActionResult AboutPage()
        {
            var mvcContext = new MvcContext();
            var model = mvcContext.GetDataSourceItem<AboutUs>();

            return View("~/Views/FarmToFork/AboutUs/AboutUs.cshtml", model);
        }
    }
}



using Foundation.Serialization;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Feature.Navigation.Controllers
{
    public class FooterController : Controller
    {
        public ActionResult FooterPage()
        {
            var mvcContext = new MvcContext();
            var model = mvcContext.GetDataSourceItem<Footer>();

            return View("~/Views/FarmToFork/Footer/Footer.cshtml", model);
        }
    }
}
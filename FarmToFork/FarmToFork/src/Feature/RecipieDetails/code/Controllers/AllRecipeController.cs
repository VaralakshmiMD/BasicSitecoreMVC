using Foundation.Serialization;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Feature.RecipieDetails.Controllers
{
    public class AllRecipeController : Controller
    {
        public ActionResult AllFeature()
        {
            var mvcContext = new MvcContext();
            var model = mvcContext.GetDataSourceItem<RecipeMultiList>();

            return View("~/Views/FarmToFork/AllRecipe.cshtml", model);
        }
    }
}
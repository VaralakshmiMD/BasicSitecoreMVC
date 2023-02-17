using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Foundation.Serialization;
using Glass.Mapper.Sc.Web.Mvc;


namespace Feature.RecipieDetails.Controllers
{
    public class RecipesController : Controller
    {
        public ActionResult RecipesDetail()
        {
            var mvcContext = new MvcContext();
            var model = mvcContext.GetContextItem<RecipeDetail>();
            return View("~/Views/FarmToFork/RecipesDetail.cshtml", model);
        }
    }

}




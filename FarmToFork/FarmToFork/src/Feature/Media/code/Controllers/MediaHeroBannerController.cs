using Sitecore.Data.Fields;
using Sitecore.Mvc.Presentation;
using Sitecore.Resources.Media;
using Sitecore.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Feature.Media.Models;

namespace Featute.Media.Controllers
{
    public class MediaHeroBannerController : Controller
           {
            public ActionResult MediaSliders()
            {
                var model = new HeroBannerModel();
         

            List<Slides> slides = new List<Slides>();

                var dataSource = RenderingContext.Current?.Rendering.Item;
                MultilistField slidesField = dataSource.Fields["Slides"];
                if (slidesField?.Count > 0)
                {
                    //string images = "";
                    var slideItems = slidesField.GetItems();
                    foreach (var slideItem in slideItems)
                    {
                        //var titleField = slideItem.Fields["Title"];
                        //var titles = titleField?.Value;

                        var title = new MvcHtmlString(FieldRenderer.Render(slideItem, "Title"));
                        var subTitle = new MvcHtmlString(FieldRenderer.Render(slideItem, "Sub_Title"));

                        ImageField imageField = slideItem.Fields["Image"];
                        var images = MediaManager.GetMediaUrl(imageField.MediaItem);


                    slides.Add(new Slides
                    {
                        Title = title,
                        SubTitle = subTitle,
                        ImagePath = images,
                      
                    });
                    model.Slides = slides;
                }
                }
                return View("~/Views/FarmToFork/Herobanner/HeroBanner.cshtml", model);
            }
        }
    }

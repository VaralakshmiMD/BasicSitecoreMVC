using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Feature.Media.Models
{
    public class HeroBannerModel

    {
        public List<Slides> Slides { get; set; }
    }
    public class Slides
    {
        public HtmlString Title { get; set; }
        public MvcHtmlString SubTitle { get; set; }
        public MvcHtmlString Image { get; set; }
        public string ImagePath { get; set; }
       
    }
}

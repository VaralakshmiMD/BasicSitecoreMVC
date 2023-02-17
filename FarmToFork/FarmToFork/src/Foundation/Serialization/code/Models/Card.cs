using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Foundation.Serialization
{
    public partial class RecipeDetail : GlassBase, IRecipeDetail
    {
        [SitecoreInfo(Glass.Mapper.Sc.Configuration.SitecoreInfoType.Url)]
        public virtual string URL { get; set; }

        [SitecoreInfo(Glass.Mapper.Sc.Configuration.SitecoreInfoType.Path)]
        public virtual string Path { get; set; }
    }
}


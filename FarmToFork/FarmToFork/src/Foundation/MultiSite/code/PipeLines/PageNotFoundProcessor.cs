using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Pipelines.HttpRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foundation.MultiSite.PipeLines
{
    public class PageNotFoundProcessor: HttpRequestProcessor
    
    {
        public override void Process(HttpRequestArgs args)
        {
            if (Sitecore.Context.Item != null || Sitecore.Context.Database == null || Sitecore.Context.Site == null)
            {
                return;
            }
            var errorPageUrl = GetErrorPageUrl();

            if (string.IsNullOrWhiteSpace(errorPageUrl)) return;

            try
            {
                HttpContext.Current.Response.Redirect(errorPageUrl);
            }
            catch (Exception)
            {
                //Left blank intentionally
            }
        }
        private static string GetErrorPageUrl()
        {
            var database = Sitecore.Context.Database;
            var homeItemPath = Sitecore.Context.Site.StartPath;

            Item homeItem = database.GetItem(homeItemPath);
            if (homeItem == null) return string.Empty;

            LinkField errorlinkField = homeItem.Fields["ErrorPage"];
            if (errorlinkField == null) return string.Empty;

            return errorlinkField.GetFriendlyUrl();
        }
    }
}

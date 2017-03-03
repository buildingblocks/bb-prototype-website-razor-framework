using BB.Prototype.Website.Razor.Framework.Controllers;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;

namespace BB.Prototype.Website.Razor.Framework.Extensions
{
    public static class ViewComponentHelperExtensions
    {
        public static IHtmlContent Render(this IViewComponentHelper helper, string viewName, string componentPath)
        {
            return helper.InvokeAsync(typeof(JsonModelDrivenViewComponent), new { viewName, componentPath }).Result;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using BB.Prototype.Website.Razor.Framework.Models;

namespace BB.Prototype.Website.Razor.Framework.Controllers
{
    public class PageListViewComponent : ViewComponent
    {
        private static readonly string _modelPath = "data/";

        public IViewComponentResult Invoke(string listingFile)
        {
            var pages = JsonConvert.DeserializeObject<List<PageListing>>(File.ReadAllText(_modelPath + listingFile));

            return View("~/Views/Components/_bb/pageList.cshtml", pages);
        }
    }
}

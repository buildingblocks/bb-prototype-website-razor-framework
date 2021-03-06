﻿using System.Dynamic;
using System.Threading.Tasks;
using BB.Prototype.Website.Razor.Framework.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace BB.Prototype.Website.Razor.Framework.Controllers
{
    public class JsonModelDrivenViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string viewName, string componentPath)
        {
            dynamic model = new {};
            if (!string.IsNullOrEmpty(componentPath))
            {
                string componentFile = $"{componentPath.Split('.')[0]}.json";
                string path = componentPath.Substring(componentPath.IndexOf('.'));
                model = ModelHelper.GetModel(componentFile, path);
            }
            await Task.Delay(10);
            return View(viewName, model);
        }
    }
}

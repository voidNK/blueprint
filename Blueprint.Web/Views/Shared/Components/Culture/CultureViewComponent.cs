﻿using Microsoft.AspNetCore.Mvc;

namespace Blueprint.Web.Views.Shared.Components.Culture
{
    public class CultureViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RouxAcademy
{
    public class CustomViewEngine: RazorViewEngine
    {
        public CustomViewEngine()
        {
            this.PartialViewLocationFormats = new string[]
            {
                "~/Views/Partial/{0}.cshtml",
                "~/Views/Partial/{1}/{0}.cshtml"
            };

            this.AreaMasterLocationFormats = base.AreaMasterLocationFormats;

            this.ViewLocationFormats = base.ViewLocationFormats;
        }
    }
}
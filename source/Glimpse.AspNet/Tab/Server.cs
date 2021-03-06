﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Glimpse.AspNet.Extensibility;
using Glimpse.AspNet.Extensions;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Extensions;

namespace Glimpse.AspNet.Tab
{
    public class Server : AspNetTab, IDocumentation
    {
        public override string Name
        {
            get { return "Server"; }
        }

        public string DocumentationUri
        {
            // TODO: Update to proper Uri
            get { return "http://localhost/someUrl"; }
        }

        public override object GetData(ITabContext context)
        {
            var httpContext = context.GetHttpContext();

            return httpContext.Request.ServerVariables.ToDictionary();
        }
    }
}

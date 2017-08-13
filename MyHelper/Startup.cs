﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(MyHelper.Startup))]

namespace MyHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = GlobalConfiguration.Configuration;
            ConfigureAuth(app);
            config.DependencyResolver = GlobalConfiguration.Configuration.DependencyResolver;
        }
    }
}

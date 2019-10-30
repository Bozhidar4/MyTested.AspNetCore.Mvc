// <copyright file="TestPlugin.cs" company="MyTested.AspNetCore.MVC - ASP.NET Core MVC Fluent Testing Framework 2019 Ivaylo Kenov">
// Copyright (c) MyTested.AspNetCore.MVC - ASP.NET Core MVC Fluent Testing Framework 2019 Ivaylo Kenov. All rights reserved.
// </copyright>

namespace MyTested.AspNetCore.Mvc.Plugins
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    public class TestPlugin : IDefaultRegistrationPlugin
    {
        public long Priority => 0;

        public Action<IServiceCollection> DefaultServiceRegistrationDelegate
            => serviceCollection => serviceCollection.AddMvc();
    }
}

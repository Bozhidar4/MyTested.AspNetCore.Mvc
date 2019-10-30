// <copyright file="ServiceCollectionExtensions.cs" company="MyTested.AspNetCore.MVC - ASP.NET Core MVC Fluent Testing Framework 2019 Ivaylo Kenov">
// Copyright (c) MyTested.AspNetCore.MVC - ASP.NET Core MVC Fluent Testing Framework 2019 Ivaylo Kenov. All rights reserved.
// </copyright>

namespace MyTested.AspNetCore.Mvc
{
    using Microsoft.Extensions.DependencyInjection;
    using MyTested.AspNetCore.Mvc.Utilities.Validators;

    /// <summary>
    /// Contains extension methods for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds MVC testing services.
        /// </summary>
        /// <param name="serviceCollection">Instance of <see cref="IServiceCollection"/> type.</param>
        /// <returns>The same <see cref="IServiceCollection"/>.</returns>
        public static IServiceCollection AddMvcTesting(this IServiceCollection serviceCollection)
        {
            CommonValidator.CheckForNullReference(serviceCollection, nameof(serviceCollection));

            serviceCollection
                .AddMvcCoreTesting()
                .AddViewFeaturesTesting()
                .AddStringInputFormatter()
                .ReplaceOptions();

            return serviceCollection;
        }
    }
}

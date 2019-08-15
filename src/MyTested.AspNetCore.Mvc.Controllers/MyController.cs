﻿namespace MyTested.AspNetCore.Mvc
{
    using System;
    using System.Linq.Expressions;
    using Builders.Contracts.Controllers;
    using Builders.Controllers;
    using Internal.Application;
    using Internal.TestContexts;
    using MyTested.AspNetCore.Mvc.Builders.Contracts.Actions;

    /// <summary>
    /// Provides methods to specify an ASP.NET Core MVC controller test case.
    /// </summary>
    /// <typeparam name="TController">Type of ASP.NET Core MVC controller to test.</typeparam>
    public class MyController<TController> : ControllerBuilder<TController>
        where TController : class
    {
        static MyController() => TestApplication.TryInitialize();

        /// <summary>
        /// Initializes a new instance of the <see cref="MyController{TController}"/> class.
        /// </summary>
        public MyController()
            : this((TController)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyController{TController}"/> class.
        /// </summary>
        /// <param name="controller">Instance of the ASP.NET Core MVC controller to test.</param>
        public MyController(TController controller)
            : this(() => controller)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyController{TController}"/> class.
        /// </summary>
        /// <param name="construction">Construction function returning the instantiated controller.</param>
        public MyController(Func<TController> construction)
            : base(new ControllerTestContext { ComponentConstructionDelegate = construction })
        {
        }

        /// <summary>
        /// Starts a controller test.
        /// </summary>
        /// <returns>Test builder of <see cref="IControllerBuilder{TController}"/> type.</returns>
        public static IControllerBuilder<TController> Instance() 
            => Instance((TController)null);

        /// <summary>
        /// Starts a controller test.
        /// </summary>
        /// <param name="controller">Instance of the ASP.NET Core MVC controller to test.</param>
        /// <returns>Test builder of <see cref="IControllerBuilder{TController}"/> type.</returns>
        public static IControllerBuilder<TController> Instance(TController controller) 
            => Instance(() => controller);

        /// <summary>
        /// Starts a controller test.
        /// </summary>
        /// <param name="construction">Construction function returning the instantiated controller.</param>
        /// <returns>Test builder of <see cref="IControllerBuilder{TController}"/> type.</returns>
        public static IControllerBuilder<TController> Instance(Func<TController> construction) 
            => new MyController<TController>(construction);


        /// <summary>
        /// Starts a controller test.
        /// </summary>
        /// <param name="actionCall">Construction function returning the instantiated controller.</param>
        /// <returns>Test builder of <see cref="IActionResultTestBuilder{TActionResult}"/> type.</returns>
        public new static IActionResultTestBuilder<TActionResult> Calling<TActionResult>(Expression<Func<TController, TActionResult>> actionCall)
            => Instance((TController)null).Calling(actionCall);
    }
}

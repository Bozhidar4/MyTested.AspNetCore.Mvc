﻿namespace MyTested.Mvc.Builders.Contracts.Actions
{
    using Base;
    using ActionResults.Ok;
    using System;
    using ActionResults.Created;
    using ActionResults.Content;
    using ActionResults.Json;
    using Models;
    using ActionResults.HttpBadRequest;
    using ActionResults.File;
    using System.Net;
    using ActionResults.LocalRedirect;
    using ActionResults.Challenge;

    /// <summary>
    /// Used for testing action returned result.
    /// </summary>
    /// <typeparam name="TActionResult">Result from invoked action in ASP.NET MVC controller.</typeparam>
    public interface IShouldReturnTestBuilder<TActionResult> : IBaseTestBuilderWithActionResult<TActionResult>
    {
        /// <summary>
        /// Tests whether action result is the default value of the type.
        /// </summary>
        /// <returns>Base test builder with action result.</returns>
        IBaseTestBuilderWithActionResult<TActionResult> DefaultValue();

        /// <summary>
        /// Tests whether action result is null.
        /// </summary>
        /// <returns>Base test builder with action result.</returns>
        IBaseTestBuilderWithActionResult<TActionResult> Null();

        /// <summary>
        /// Tests whether action result is not null.
        /// </summary>
        /// <returns>Base test builder with action result.</returns>
        IBaseTestBuilderWithActionResult<TActionResult> NotNull();

        // TODO: may not be used
        ///// <summary>
        ///// Tests whether action result is HttpResponseMessage.
        ///// </summary>
        ///// <returns>HTTP response message test builder.</returns>
        //IHttpResponseMessageTestBuilder HttpResponseMessage();

        /// <summary>
        /// Tests whether action result is OkResult or OkNegotiatedContentResult{T}.
        /// </summary>
        /// <returns>Ok test builder.</returns>
        IOkTestBuilder Ok();

        /// <summary>
        /// Tests whether action result is ChallengeResult.
        /// </summary>
        /// <returns>Challenge test builder.</returns>
        IChallengeTestBuilder Challenge();

        /// <summary>
        /// Tests whether action result is CreatedNegotiatedContentResult{T} or CreatedAtRouteNegotiatedContentResult{T}.
        /// </summary>
        /// <returns>Created test builder.</returns>
        ICreatedTestBuilder Created();

        /// <summary>
        /// Tests whether action result is FileStreamResult, VirtualFileResult or FileContentResult.
        /// </summary>
        /// <returns>File test builder.</returns>
        IFileTestBuilder File();

        /// <summary>
        /// Tests whether action result is ContentResult.
        /// </summary>
        /// <returns>Content test builder.</returns>
        IContentTestBuilder Content();

        /// <summary>
        /// Tests whether action result is ContentResult.
        /// </summary>
        /// <param name="content">Expected content as string.</param>
        /// <returns>Content test builder.</returns>
        IContentTestBuilder Content(string content);

        /// <summary>
        /// Tests whether action result is LocalRedirectResult.
        /// </summary>
        /// <returns>Local redirect test builder.</returns>
        ILocalRedirectTestBuilder LocalRedirect();

        // TODO: ?
        ///// <summary>
        ///// Tests whether action result is RedirectResult or RedirectToRouteResult.
        ///// </summary>
        ///// <returns>Redirect test builder.</returns>
        //IRedirectTestBuilder Redirect();

        /// <summary>
        /// Tests whether action result is HttpStatusCodeResult.
        /// </summary>
        /// <returns>Base test builder with action result.</returns>
        IBaseTestBuilderWithActionResult<TActionResult> StatusCode();

        /// <summary>
        /// Tests whether action result is HttpStatusCodeResult and is the same as provided HttpStatusCode.
        /// </summary>
        /// <param name="statusCode">HttpStatusCode enumeration.</param>
        /// <returns>Base test builder with action result.</returns>
        IBaseTestBuilderWithActionResult<TActionResult> StatusCode(HttpStatusCode statusCode);

        /// <summary>
        /// Tests whether action result is NotFoundResult.
        /// </summary>
        /// <returns>Base test builder with action result.</returns>
        IBaseTestBuilderWithActionResult<TActionResult> NotFound();

        /// <summary>
        /// Tests whether action result is BadRequestResult, InvalidModelStateResult or BadRequestErrorMessageResult.
        /// </summary>
        /// <returns>Bad request test builder.</returns>
        IHttpBadRequestTestBuilder HttpBadRequest();

        // TODO: ?
        ///// <summary>
        ///// Tests whether action result is ConflictResult.
        ///// </summary>
        ///// <returns>Base test builder with action result.</returns>
        //IBaseTestBuilderWithActionResult<TActionResult> Conflict();

        /// <summary>
        /// Tests whether action result is HttpUnauthorizedResult.
        /// </summary>
        /// <returns>Base test builder with action result.</returns>
        IBaseTestBuilderWithActionResult<TActionResult> HttpUnauthorized();

        ///// <summary>
        ///// Tests whether action result is InternalServerErrorResult or ExceptionResult.
        ///// </summary>
        ///// <returns>Internal server error test builder.</returns>
        //IInternalServerErrorTestBuilder InternalServerError();

        /// <summary>
        /// Tests whether action result is JSON Result.
        /// </summary>
        /// <returns>JSON test builder.</returns>
        IJsonTestBuilder Json();

        /// <summary>
        /// Tests whether action result is of the provided generic type.
        /// </summary>
        /// <typeparam name="TResponseModel">Expected response type.</typeparam>
        /// <returns>Response model details test builder.</returns>
        IModelDetailsTestBuilder<TActionResult> ResultOfType<TResponseModel>();

        /// <summary>
        /// Tests whether action result is of the provided type.
        /// </summary>
        /// <param name="returnType">Expected return type.</param>
        /// <returns>Response model details test builder.</returns>
        IModelDetailsTestBuilder<TActionResult> ResultOfType(Type returnType);
    }
}
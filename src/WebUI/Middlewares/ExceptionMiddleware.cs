using CleanTemplate.WebUI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CleanTemplate.WebUI.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation("Request!");
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                _logger.LogError("Exception occured while handling the request", exception);
                await HandleExceptionAsync(context,exception);
            }                      
        }

        private Task HandleExceptionAsync(HttpContext context,Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            return context.Response.WriteAsync(new ErrorViewModel
            {
                StatusCode = context.Response.StatusCode,
                Message = exception.Message,
                Stacktrace = exception.StackTrace
            }.ToString());
        }

        //public static void ConfigureExceptionMiddleware(this IApplicationBuilder app)
        //{
            
        //}
    }
}

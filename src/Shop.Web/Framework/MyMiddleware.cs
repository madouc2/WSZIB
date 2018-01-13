using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Shop.Web.Framework
{
    public class MyMiddleware
    {
        private readonly RequestDelegate _next;

        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)//asynchronicznie bo czekamy na odpowiedz serwera jakiegos. a nie chcemy zzerac zasobow. ale gdy zasoby procesora uzywane- matematyczne to to nic nie da. tylko do zewnetrznych.
        {
            Console.WriteLine($"My middleware: {httpContext.Request.Path}");
            await _next.Invoke(httpContext);
        }


    }
}

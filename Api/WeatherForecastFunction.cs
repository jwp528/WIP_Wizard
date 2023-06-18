using System;
using System.Linq;
using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace ApiIsolated
{
    public class HttpTrigger
    {
        private readonly ILogger _logger;

        public HttpTrigger(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<HttpTrigger>();
        }

        [Function("api/v1")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            var randomNumber = new Random();
            var temp = randomNumber.Next(1, 100);
            
            var responseObj = new
            {
                Number  = temp,
                Message = "Testing"
            };

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.WriteAsJsonAsync(responseObj);

            return response;
        }
    }
}

using Azure.Messaging.ServiceBus;
using CourseSignUp.Api.Mediators;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Statistics
{
    public static class StatisticsGet
    {
        private static IMediator _mediator;

        [FunctionName("StatisticsGet")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "StatisticsGet/{idCourse:int}")] HttpRequest req,
            int idCourse)        
        {
            var command = new StatisticsCommand { IdCourse = idCourse };
            var response = await _mediator.Send(command);

            var json = JsonConvert.SerializeObject(new
            {
                statistics = response
            });

            return new OkObjectResult(json);
        }
    }
}
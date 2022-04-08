using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Kw.Model;
using System.Collections.Generic;

namespace Kw.Api
{
    public static class FamilyMembers
    {
        [FunctionName("FamilyMembers")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            //log.LogInformation("C# HTTP trigger function processed a request.");

            //string name = req.Query["name"];

            //string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

            //string responseMessage = string.IsNullOrEmpty(name)
            //    ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
            //    : $"Hello, {name}. This HTTP triggered function executed successfully.";

            return new OkObjectResult(Users());
        }


        private static List<User> Users()
        {
            var user = new User
            {
                Id = 1,
                Name = "Brent Gore"
            };

            return new List<User> {
                user,
                new User
                {
                    Id = 2,
                    Name = "Panther",
                },
                new User
                {
                    Id = 3,
                    Name = "Monkey",
                },
                new User
                {
                    Id = 4,
                    Name = "Fox",
                },
                new User
                {
                    Id = 5,
                    Name = "Zebra",
                },
                new User
                {
                    Id = 6,
                    Name = "Moose",
                },
            };
        }
    }

    
}

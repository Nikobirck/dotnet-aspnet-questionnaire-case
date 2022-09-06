using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ApplicationCore.Interfaces;
using ApplicationCore.Models;

namespace Functions.Functions
{
    public class SubmitResponseFunc
    {
        private readonly IQuestionaireService _questionaireService;
        public SubmitResponseFunc(IQuestionaireService questionaireService)
        {
            _questionaireService = questionaireService;
        }
        [FunctionName("SubmitResponseFunc")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "api/questionaire/{id}/response")][FromBody] QuestionaireResponse questionaireResponse,
            ILogger log, Guid id)
        {

            var res = _questionaireService.SubmitQuestionaireResponse(id, questionaireResponse);

            if (!res.Succes)
            {
                return new BadRequestObjectResult(res.Message);
            }

            return new OkObjectResult("Successfully submitted");
        }
    }
}
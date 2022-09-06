using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Infrastructure.Services;
using ApplicationCore.Interfaces;

namespace Functions.Functions
{
    public class GetAllQuestionaireFunc
    {
        private readonly IQuestionaireService _questionaireService;
        public GetAllQuestionaireFunc(IQuestionaireService questionaireService)
        {
            _questionaireService = questionaireService;
        }
        [FunctionName("GetAllQuestionaireFunc")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "api/questionaire")] HttpRequest req,
            ILogger log)
        {

            var questionaires = _questionaireService.GetAllQuestionaire();

            return new OkObjectResult(questionaires);
        }
    }
}

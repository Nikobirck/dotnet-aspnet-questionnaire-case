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

namespace Functions.Functions
{
    public class GetQuestionaireFunc
    {
        private readonly IQuestionaireService _questionaireService;
        public GetQuestionaireFunc(IQuestionaireService questionaireService)
        {
            _questionaireService = questionaireService;
        }
        [FunctionName("GetQuestionaireFunc")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get",  Route = "api/questionaire/{id}")] HttpRequest req,
            ILogger log, Guid id)
        {
            
            var questionaire = _questionaireService.GetQuestionaire(id);
            if(questionaire == null)
            {
                return new BadRequestObjectResult("Could not find any questionaire with the given Id: " + id);
            }
            return new OkObjectResult(questionaire);
        }
    }
}

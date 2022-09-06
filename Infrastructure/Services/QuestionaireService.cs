using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class QuestionaireService : IQuestionaireService
    {
        private readonly IDatabaseConnection _database;
        public QuestionaireService(IDatabaseConnection database)
        {
            _database = database;
        }
        public List<Questionaire> GetAllQuestionaire()
        {
            return _database.GetAllQuestionaire();
        }

        public Questionaire GetQuestionaire(Guid id)
        {
            return _database.GetQuestionaire(id);
        }

        public RespondStatus SubmitQuestionaireResponse(Guid id, QuestionaireResponse response)
        {
            var respond = new RespondStatus
            {
                Succes = false,
                Message = ""
            };
            var questionaire = GetQuestionaire(id);
            if (questionaire == null)
            {
                respond.Message = "No questionaire matching that Id";
            }
            else
            {
                if (questionaire?.Questions?.Count < response?.Answers?.Count)
                {
                    respond.Message = "More answers than questions";
                }
                else
                {
                    if (_database.SubmitQuestionaireResponse(id, response))
                    {
                        respond.Succes = true;
                    }
                    else
                    {
                        respond.Message = "Could not add response due to internal difficulties";
                    }
                }

            }

            return respond;
        }
    }
}

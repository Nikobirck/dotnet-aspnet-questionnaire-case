using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IQuestionaireService
    {
        List<Questionaire> GetAllQuestionaire();
        Questionaire GetQuestionaire(Guid id);
        RespondStatus SubmitQuestionaireResponse(Guid id, QuestionaireResponse response);
    }
}

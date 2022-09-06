using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IDatabaseConnection
    {
        List<Questionaire> GetAllQuestionaire();
        Questionaire GetQuestionaire(Guid id);
        bool SubmitQuestionaireResponse(Guid id, QuestionaireResponse response);
    }
}

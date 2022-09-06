using ApplicationCore.Interfaces;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MockDatabase : IDatabaseConnection
    {
        public List<Questionaire> GetAllQuestionaire()
        {
            return questionaires;
        }

        public Questionaire GetQuestionaire(Guid id)
        {
            return questionaires.FirstOrDefault(x => x.Id == id);
        }

        public bool SubmitQuestionaireResponse(Guid id, QuestionaireResponse response)
        {
            var questionaire = questionaires.FirstOrDefault(x => x.Id == id);
            if(questionaire != null)
            {
                //Submit to database
                return true;
            }
            return false;
        }


        public static List<Questionaire> questionaires = new()
        {
            new Questionaire
            {
                Name = "Coffee related",
                Id = new Guid("20f46381-0081-48c4-aec8-447a1f95e45a"),
                Questions = new List<Question>
                {
                    new Question
                    {
                        Text = "Which famous coffee drink contains an shot of espresso with steamed milk?",
                        Answer = "Cappuccino"
                    },
                    new Question
                    {
                        Text = "What is it called when you add a shot of espresso to a regular coffee?",
                        Answer = "Red Eye"
                    },
                    new Question
                    {
                        Text = "What is a single shot of espresso also called?",
                        Answer = "Ristretto"
                    }
                }
            },
            new Questionaire
            {
                Name = "Questions seen in the Office",
                Id = new Guid("e9247f0e-8b8f-4458-acc4-931e2dbe8027"),
                Questions = new List<Question>
                {
                    new Question
                    {
                        Text = "What kind of bear is best?",
                        Answer = "Black Bear"
                    },
                    new Question
                    {
                        Text = "How do you prevent yourself from doing something stupid?",
                        Answer = "You ask your self, 'Would an idiot do that?' And if the answer is yes, you do not do it."
                    }
                }
            }
        };
    }
}

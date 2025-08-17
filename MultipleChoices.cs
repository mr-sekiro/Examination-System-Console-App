using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class MultipleChoices : Question
    {
        public MultipleChoices(string body, int mark, Answer[] answers, int correctAnswerIndex)
           : base("MCQ", body, mark, answers, correctAnswerIndex)
        {
        }
    }
}

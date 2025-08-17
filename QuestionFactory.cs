using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class QuestionFactory
    {
        public static Question CreateQuestion(int type)
        {
            string body = ConsoleUI.ReadText("Enter question body");
            int mark = ConsoleUI.ReadInt("Enter question mark", 1, 10);

            if (type == 1) // True/False
            {
                int correct = ConsoleUI.ReadInt("Enter correct answer (1=True, 2=False)", 1, 2);
                return new TrueOrFalse(body, mark, correct);
            }
            else // MCQ
            {
                int count = ConsoleUI.ReadInt("Enter number of answers", 2, 5);
                Answer[] answers = new Answer[count];
                for (int i = 0; i < count; i++)
                {
                    string text = ConsoleUI.ReadText($"Answer {i + 1}");
                    answers[i] = new Answer(i + 1, text);
                }
                int correct = ConsoleUI.ReadInt("Enter correct answer index", 1, count);
                return new MultipleChoices(body, mark, answers, correct);
            }
        }
    }
}

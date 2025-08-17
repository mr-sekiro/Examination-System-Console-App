using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class ExamFactory
    {
        public static Exam CreateExam(int type)
        {
            int numQuestions = ConsoleUI.ReadInt("Enter number of questions", 1, 60);
            int minutes = ConsoleUI.ReadInt("Enter exam time in minutes", 1, 180);
            TimeSpan duration = TimeSpan.FromMinutes(minutes);

            Question[] questions = new Question[numQuestions];
            for (int i = 0; i < numQuestions; i++)
            {
                Console.WriteLine($"\n=== Creating Question {i + 1} ===");

                if (type == 1) // Practical
                {
                    Console.WriteLine("Choose Question Type\n[1] True/False   [2] MCQ");
                    int qType = ConsoleUI.ReadInt("Enter choice", 1, 2);
                    questions[i] = QuestionFactory.CreateQuestion(qType);
                }
                else // Final
                {
                    questions[i] = QuestionFactory.CreateQuestion(2); // only MCQ
                }
            }

            return type == 1
                ? new PracticalExam(numQuestions, duration, questions)
                : new FinalExam(numQuestions, duration, questions);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int numberOfQuestions, TimeSpan duration, Question[] questions)
            : base(numberOfQuestions, duration, questions) { }

        public override void ShowResult()
        {
            Console.WriteLine("=== Practical Exam Results ===");
            for (int i = 0; i < Questions.Length; i++)
            {
                var q = Questions[i];
                Console.WriteLine($"\nQ{i + 1}: {q.Body}");
                Console.WriteLine($"Your Answer: {q.Answers[q.SelectedAnswerIndex - 1]}");
                Console.WriteLine($"Correct Answer: {q.Answers[q.CorrectAnswerIndex - 1]}");
            }
            base.ShowResult();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Exam
    {
        public int NumberOfQuestions { get; protected set; }
        public Question[] Questions { get; protected set; }
        public TimeSpan Duration { get; protected set; }
        public TimeSpan ElapsedTime { get; private set; }
        public int Score { get; protected set; }
        public int TotalMarks { get; protected set; }

        protected Exam(int numberOfQuestions, TimeSpan duration, Question[] questions)
        {
            NumberOfQuestions = numberOfQuestions;
            Duration = duration;
            Questions = questions;
            TotalMarks = questions.Sum(q => q.Mark);
        }

        public void StartExam()
        {
            var stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"\nQuestion[{i + 1}]: {Questions[i]}");
                int input = ConsoleUI.ReadInt("Enter your answer", 1, Questions[i].Answers.Length);
                Questions[i].SelectedAnswerIndex = input;
            }

            stopwatch.Stop();
            ElapsedTime = stopwatch.Elapsed;

            Console.Clear();
            Evaluate();
            ShowResult();
        }

        public void Evaluate()
        {
            Score = 0;
            foreach (var q in Questions)
            {
                if (q.SelectedAnswerIndex == q.CorrectAnswerIndex)
                    Score += q.Mark;
            }
        }

        public virtual void ShowResult()
        {
            Console.WriteLine("===============================");
            Console.WriteLine($"Your Score: {Score}/{TotalMarks}");
            Console.WriteLine($"Time Spent: {ElapsedTime.Minutes}m {ElapsedTime.Seconds}s");
            Console.WriteLine($"Allowed Duration: {Duration.TotalMinutes} minutes");
            Console.WriteLine("===============================");
        }
    }
}

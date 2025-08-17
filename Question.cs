using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Question
    {
        public string Header { get; protected set; }
        public string Body { get; protected set; }
        public int Mark { get; protected set; }
        public Answer[] Answers { get; protected set; }
        public int CorrectAnswerIndex { get; protected set; }
        public int SelectedAnswerIndex { get; set; } = -1;

        protected Question(string header, string body, int mark, Answer[] answers, int correctAnswerIndex)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < Answers.Length; i++)
                sb.AppendLine($"[{i + 1}] {Answers[i].Text}");

            return $"[{Header}] ({Mark} Marks)\n{Body}\n{new string('-', 40)}\n{sb}";
        }
    }
}

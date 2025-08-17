using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Answer
    {
        public int Id { get; }
        public string Text { get; }

        public Answer(int id, string text)
        {
            Id = id;
            Text = text;
        }

        public override string ToString() => Text;
    }
}

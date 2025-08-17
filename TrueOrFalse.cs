using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class TrueOrFalse : Question
    {
        public TrueOrFalse(string body, int mark, int correctAnswerIndex)
            : base("True/False", body, mark,
                  new Answer[] { new Answer(1, "True"), new Answer(2, "False") },
                  correctAnswerIndex)
        {
        }

        public override string ToString()
        {
            return $"[{Header}] ({Mark} Marks)\n{Body}\n{new string('-', 40)}\n[1] True   [2] False";
        }
    }
}

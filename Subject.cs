using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Subject
    {
        public int Id { get; }
        public string Name { get; }
        public Exam Exam { get; private set; }

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void CreateExam()
        {
            Console.WriteLine("Select Exam Type\n[1] Practical  [2] Final");
            int choice = ConsoleUI.ReadInt("Enter choice", 1, 2);

            Exam = ExamFactory.CreateExam(choice);
        }
    }
}

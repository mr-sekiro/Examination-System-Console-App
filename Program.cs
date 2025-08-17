namespace Examination_System
{
    internal class Program
    {
        static void Main()
        {
            Subject subject = new Subject(1, "C# Basics and OOP");
            Console.WriteLine("=============================================================");
            subject.CreateExam();
            Console.Clear();

            Console.Write("Do you want to start the exam?\n[1] Yes   [2] No: ");
            int input = ConsoleUI.ReadInt("Enter choice", 1, 2);

            if (input == 1)
            {
                Console.Clear();
                subject.Exam.StartExam();
            }
            else
            {
                Console.WriteLine("Exiting system...");
            }
        }
    }
}

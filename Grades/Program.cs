using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradeBook();

            AddGrades(book);
            WriteResults(book);
        }

        private static IGradeTracker CreateGradeBook()
        {
            return new ThrowAwayGradeBook();
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetBookName(IGradeTracker book)
        {
            try
            {
                Console.WriteLine("Enter a name: ");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void WriteResults(IGradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistics();

            foreach (float grade in book)
            {
                Console.WriteLine(grade);
            }



            Console.WriteLine("Average Grade: " + stats.AverageGrade);
            Console.WriteLine("Highest Grade: " + stats.HighestGrade);
            Console.WriteLine("Lowest Grade: " + stats.LowestGrade);
        }
    }
}

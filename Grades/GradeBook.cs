using System;
using System.Collections;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        protected List<float> grades;


        public GradeBook()
        {
            grades = new List<float>();
        }

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("GradeBook::ComputeStatistics");
            GradeStatistics stats = new GradeStatistics();

            stats.HighestGrade = 0;

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = System.Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = System.Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;

        }
        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }
    }
}

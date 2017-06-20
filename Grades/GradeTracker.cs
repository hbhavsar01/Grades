using System.Collections;

namespace Grades
{
    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();

        public abstract IEnumerator GetEnumerator();



        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        protected string name;
    }
}

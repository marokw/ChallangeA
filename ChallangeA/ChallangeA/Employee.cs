
namespace ChallangeA
{
    public class Employee
    {
        public Employee(string Name = "-", string Surname= "-", uint age = 0)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = age;
        }

        public void AddGrade(float grade)
        {
            if (grade < 0.0f) return;

            this.grades.Add(grade);
        }
        
        /// <summary>
        ///  Add minus number to Employee grades
        /// </summary>
        /// <param name="penalty">this param must be negative otherwise it does nothing</param>
        public void AddPenalty(float penalty) 
        {
            if (penalty >= 0.0f) return;
            
            this.grades.Add(penalty);
        }
        
        public void PrintGrades()
        {
            Console.Write("(");
            foreach (int grade in grades)
                Console.Write(grade + ",");
            Console.WriteLine(")");
        }

        public Statistics GetStatistics()
        {
            var stats = new Statistics();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;

            foreach(var grade in this.grades)
            {
                stats.Max = Math.Max(stats.Max, grade);
                stats.Min = Math.Min(stats.Min, grade);
                stats.Average += grade;
            }

            stats.Average /= this.grades.Count;

            return stats;
        }

        public string Name { get; }

        public string Surname { get; }

        public uint   Age { get; }

        public int GradesSum
        {
            get
            {
                return (int)this.grades.Sum();
            }
        }

        private List<float> grades = new List<float>();

    }

}

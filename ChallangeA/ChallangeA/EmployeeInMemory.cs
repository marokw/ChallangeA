namespace ChallangeA
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();
        
        public int GradesSum
        {
            get
            {
                return (int)this.grades.Sum();
            }
        }
        public int GradesCount
        {
            get
            {
                return (int)this.grades.Count;
            }
        }

        public EmployeeInMemory(string name = "-", string surname = "-", uint age = 0)
            : base(name, surname, age)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0.0f && grade <= 100.0f)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception($"[{grade}] -- Invalid grade value");
            }

        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
                AddGrade(result);
            else if (char.TryParse(grade, out char result2))
                AddGrade(result2);
            else
            {
                throw new Exception($"[{grade}] -- Value is not a number");
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception($"[{grade}] -- Wrong Letter");
                    //break;

            }
        }

        public override void AddGrade(double grade)
        {
            AddGrade((float)grade);
        }
        public override void AddGrade(int grade)
        {
            AddGrade((float)grade);
        }
        public override void AddGrade(long grade)
        {
            AddGrade((float)grade);
        }

        public override void AddPenalty(float penalty)
        {
            if (penalty < 0.0f)
                this.grades.Add(penalty);
            else
                throw new Exception($"[{penalty}] -- Penalty should be negative a number!");
        }

        public void PrintGrades()
        {
            Console.Write("(");
            foreach (int grade in grades)
                Console.Write(grade + ",");
            Console.WriteLine(")");
        }

        public override Statistics GetStatistics()
        {
            var stats = new Statistics();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                stats.Max = Math.Max(stats.Max, grade);
                stats.Min = Math.Min(stats.Min, grade);
                stats.Average += grade;
            }

            stats.Average /= this.grades.Count;

            switch (stats.Average)
            {
                case var average when average > 80:
                    stats.AverageLetter = 'A';
                    break;
                case var average when average > 60:
                    stats.AverageLetter = 'B';
                    break;
                case var average when average > 40:
                    stats.AverageLetter = 'C';
                    break;
                case var average when average > 20:
                    stats.AverageLetter = 'D';
                    break;
                default:
                    stats.AverageLetter = 'E';
                    break;
            }

            return stats;
        }

    }
}

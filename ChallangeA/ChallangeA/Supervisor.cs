namespace ChallangeA
{
    public class Supervisor : EmployeeBase
    {
        private List<float> grades = new List<float>();

        public override event GradeAddedDelegate GradeAdded;
        public List<float> Grades { get { return grades; } }

        public Supervisor(string Name = "-", string Surname = "-", uint age = 0)
            : base (Name, Surname, age)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0.0f && grade <= 100.0f)
            {
                this.grades.Add(grade);

                GradeAdded?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                throw new Exception($"[{grade}] -- Invalid grade value");
            }

        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result) && result > 6)
                AddGrade(result);
            else
            {
                bool isPlus = grade.Contains('+');
                bool isMinus = grade.Contains('-');
                if (isPlus && isMinus)
                {
                    throw new Exception("Grade can't have both (+) i (-) !");
                }
                var trimgedGade = grade.Trim(new char[] { '+', '-', ' ' });
                int pointsForGrade;
                switch (trimgedGade)
                {
                    case "6":
                        pointsForGrade = 100;
                        break;
                    case "5":
                        pointsForGrade = 80;
                        break;
                    case "4":
                        pointsForGrade = 60;
                        break;
                    case "3":
                        pointsForGrade = 40;
                        break;
                    case "2":
                        pointsForGrade = 20;
                        break;
                    case "1":
                        pointsForGrade = 0;
                        break;
                    default:
                        throw new Exception("Wrong grade. Should be grade 1-6 (with additional + or - ) or number in 0-100 range");
                }
                if (isPlus)
                    pointsForGrade += 5;
                else if (isMinus)
                    pointsForGrade -= 5;

                AddGrade(Math.Clamp(pointsForGrade, 0, 100));
            }
        }
        public override void AddGrade(char grade)
        {
            AddGrade((float)grade);
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

        public override Statistics GetStatistics()
        {
            var stats = new StatisticsForSupervisor();

            foreach (var grade in this.grades)
            {
                stats.AddGrade(grade);
            }

            return stats;
        }
    }
}

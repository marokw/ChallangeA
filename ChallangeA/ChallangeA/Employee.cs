
namespace ChallangeA
{
    public class Employee : Person
    {
        public Employee(string Name = "-", string Surname= "-", uint age = 0)
            : base(Name,Surname,age)
        {
        }

        public void AddGrade(float grade)
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
        public void AddGrade(string grade)
        {
            if( float.TryParse(grade, out float result) )
                AddGrade(result);
            else if (char.TryParse(grade, out char result2))
                AddGrade(result2);
            else
            {
                throw new Exception($"[{grade}] -- Value is not a number");
            }
        }

        public void AddGrade(char grade)
        {
            switch(grade)
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

        public void AddGrade(double grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(int grade)
        {
            AddGrade((float)grade);
        }
        public void AddGrade(long grade)
        {
            AddGrade((float)grade);
        }

        public void AddPenalty(float penalty) 
        {
            if (penalty >= 0.0f) return;
            
            this.grades.Add(penalty);
        }
        
        //public void PrintGrades()
        //{
        //    Console.Write("(");
        //    foreach (int grade in grades)
        //        Console.Write(grade + ",");
        //    Console.WriteLine(")");
        //}

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

            switch(stats.Average)
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

        public int GradesSum
        {
            get
            {
                return (int)this.grades.Sum();
            }
        }

        private List<float> grades = new List<float>() ;

        public List<float> Grades { get { return grades; } } 

    }

}

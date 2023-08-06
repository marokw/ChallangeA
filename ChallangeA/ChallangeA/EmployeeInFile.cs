using System.Diagnostics;

namespace ChallangeA
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInFile(string name = "-", string surname = "-", uint age = 0)
            : base(name, surname, age)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0.0f && grade <= 100.0f)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                    GradeAdded?.Invoke(this, EventArgs.Empty);
                }
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
            float numberToAdd = 0.0f;

            switch (grade)
            {
                case 'A':
                case 'a':
                    numberToAdd = 100;
                    break;
                case 'B':
                case 'b':
                    numberToAdd = 80;
                    break;
                case 'C':
                case 'c':
                    numberToAdd = 60;
                    break;
                case 'D':
                case 'd':
                    numberToAdd = 40;
                    break;
                case 'E':
                case 'e':
                    numberToAdd = 20;
                    break;
                default:
                    throw new Exception($"[{grade}] -- Wrong Letter");
                    //break;

            }

            AddGrade(numberToAdd);
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
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(penalty);
                }
            }
            else
                throw new Exception($"[{penalty}] -- Penalty should be negative a number!");
        }

        public override Statistics GetStatistics()
        {
            var stats = new Statistics();

            uint gradesCount = 0;

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    string? line;
                    while ( (line = reader.ReadLine()) != null)
                    {
                        if (float.TryParse(line, out float grade))
                        {
                            stats.AddGrade(grade);
                            gradesCount++;
                        }
                    }
                }

            }

            return stats;
        }
    }
}

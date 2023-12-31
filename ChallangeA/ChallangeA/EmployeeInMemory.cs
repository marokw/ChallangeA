﻿namespace ChallangeA
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();

        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInMemory(string name = "-", string surname = "-", uint age = 0)
            : base(name, surname, age)
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
            
            foreach(var grade in this.grades)
            {
                stats.AddGrade(grade);
            }

            return stats;
        }

    }
}

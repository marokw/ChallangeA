
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

        public void AddGrade(int grade)
        {
            if (grade < 0) return;
            this.grades.Add(grade);
        }
        
        /// <summary>
        ///  Add minus number to Employee grades
        /// </summary>
        /// <param name="penalty">this param must be negative otherwise it does nothing</param>
        public void addPenalty(int penalty) 
        {
            if (penalty >= 0) return;
            else
                this.grades.Add(penalty);
        }
        
        public void PrintGrades()
        {
            Console.Write("(");
            foreach (int grade in grades)
                Console.Write(grade + ",");
            Console.WriteLine(")");
        }

        public string Name { get; }

        public string Surname { get; }

        public uint   Age { get; }

        public int GradesSum
        {
            get
            {
                return this.grades.Sum();
            }
        }

        private List<int> grades = new List<int>();

    }

}

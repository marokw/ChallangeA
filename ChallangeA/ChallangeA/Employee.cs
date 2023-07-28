
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
            this.grades.Add(grade);
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

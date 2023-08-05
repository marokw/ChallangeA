namespace ChallangeA
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        
        public abstract event GradeAddedDelegate GradeAdded;
        public int GradesSum { get { return (int)GetStatistics().GradesSum; } }
        public int GradesCount { get { return (int)GetStatistics().GradesCount; } }
        public EmployeeBase(string name, string surname, uint age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public uint Age { get; private set; }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(long grade);

        public abstract void AddPenalty(float penalty);

        public abstract Statistics GetStatistics();

    }

}

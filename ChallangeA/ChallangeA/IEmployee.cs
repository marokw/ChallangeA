namespace ChallangeA
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        uint Age { get; }

        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(char grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(long grade);

        void AddPenalty(float penalty);

        public Statistics GetStatistics();
    }
}

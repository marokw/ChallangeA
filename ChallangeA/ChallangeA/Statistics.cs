namespace ChallangeA
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float GradesSum { get; private set; }
        public int   GradesCount { get; private set; }
        public float Average 
        { 
            get
            {
                return GradesSum / GradesCount;
            }
        }
        public virtual char AverageLetter 
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average > 80:
                        return 'A';
                    case var average when average > 60:
                        return 'B';
                    case var average when average > 40:
                        return 'C';
                    case var average when average > 20:
                        return 'D';
                    default:
                        return 'E';
                }
            } 
             
        }
        public Statistics()
        {
            GradesSum = 0;
            GradesCount = 0;
            Max = float.MinValue;
            Min = float.MaxValue;
        }

        public void AddGrade(float grade)
        {
            GradesCount++;
            GradesSum += grade;
            Max = Math.Max(Max, grade);
            Min = Math.Min(Min, grade);
        }

    }
}

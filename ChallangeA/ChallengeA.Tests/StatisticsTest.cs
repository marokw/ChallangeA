

namespace ChallangeA.Tests
{
    public class StatisticsTests
    {
        [Test]
        public void WhenGetStatistics_ShouldReturnCorrectMax()
        {
            //Arrange
            var employee1 = new EmployeeInMemory("Adam", "Smith", 33);

            employee1.AddGrade(4);
            employee1.AddGrade(-2);
            employee1.AddGrade(2);
            employee1.AddGrade(4);
            employee1.AddGrade(8);

            //Act
            var statistics1 = employee1.GetStatistics();

            //Assert
            Assert.AreEqual(8, statistics1.Max);

        }
        [Test]
        public void WhenGetStatistics_ShouldReturnCorrectMin()
        {
            //Arrange
            var employee1 = new EmployeeInMemory("Adam", "Smith", 33);

            employee1.AddGrade(4);
            employee1.AddGrade(-2);
            employee1.AddGrade(2);
            employee1.AddGrade(4);
            employee1.AddGrade(8);

            //Act
            var statistics1 = employee1.GetStatistics();

            //Assert
            Assert.AreEqual(2, statistics1.Min);
        }
        [Test]
        public void WhenGetStatistics_ShouldReturnCorrectAverage()
        {
            //Arrange
            var employee1 = new EmployeeInMemory("Adam", "Smith", 33);

            employee1.AddGrade(4);
            employee1.AddGrade(-2);
            employee1.AddGrade(2);
            employee1.AddGrade(4);
            employee1.AddGrade(8);

            //Act
            var statistics1 = employee1.GetStatistics();

            //Assert
            Assert.AreEqual(4.5, statistics1.Average);
        }
    }
}


namespace ChallangeA.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenUserCollectTwoSetOfPoints_ShouldReturnCorrectSum()
        {
            // arrange
            var user = new EmployeeInMemory();
            user.AddGrade(5);
            user.AddGrade(6);

            // act
            var result = user.GradesSum;

            // assert 
            Assert.AreEqual(11, result);
        }

        [Test]
        public void WhenUserCollectTwoSetOfPointsAndPenalty_ShouldReturnCorrectSum()
        {
            // arrange
            var user = new EmployeeInMemory();
            user.AddGrade(5);
            user.AddGrade(6);
            user.AddPenalty(-4);

            // act
            var result = user.GradesSum;

            // assert 
            Assert.AreEqual(7, result);
        }
        [Test]
        public void WhenUserCollectTwoSetOfPointsAndPositivePnalty_ShouldReturnCorrectSumWithoutPenalty()
        {
            // arrange
            var user = new EmployeeInMemory();
            user.AddGrade(5);
            user.AddGrade(6);
            user.AddPenalty(4);

            // act
            var result = user.GradesSum;

            // assert 
            Assert.AreEqual(11, result);
        }


        [Test]
        public void WhenCountedAverage_ShouldReturnAverageLetterAsCapitalLetter()
        {
            // arrange
            var user = new EmployeeInMemory();
            user.AddGrade(50);
            user.AddGrade(60);
            user.AddPenalty(40);

            // act
            var result = user.GetStatistics().AverageLetter;

            // assert 
            Assert.AreEqual('C', result);
        }

        [Test]
        public void WhenAddedSmallCharAsGrade_ShouldAddCorrespondingGrade()
        {
            // arrange
            var user = new EmployeeInMemory();
            user.AddGrade('c');

            // act
            var avLetter = user.GetStatistics().AverageLetter;
            var av = user.GetStatistics().Average;
            var min = user.GetStatistics().Min;
            var max = user.GetStatistics().Max;

            // assert 
            Assert.AreEqual('C', avLetter);
            Assert.AreEqual(60, av);
            Assert.AreEqual(60, min);
            Assert.AreEqual(60, max);
        }


        [Test]
        public void WhenCalculatingAverageGrade_ShouldGetStatisticReturnAverageLetterCorrespodingToGrade()
        {
            // arrange
            var user = new EmployeeInMemory();
            user.AddGrade(50);
            user.AddGrade(60);
            user.AddGrade("d");

            // act
            var av = user.GetStatistics().Average;
            var avLetter = user.GetStatistics().AverageLetter;

            // assert 
            Assert.AreEqual(50, av);
            Assert.AreEqual('C', avLetter);
        }


    }
}


namespace ChallangeA.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoSetOfPoints_ShouldReturnCorrectSum()
        {
            // arrange
            var user = new Employee();
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
            var user = new Employee();
            user.AddGrade(5);
            user.AddGrade(6);
            user.addPenalty(-4);

            // act
            var result = user.GradesSum;

            // assert 
            Assert.AreEqual(7, result);
        }
        [Test]
        public void WhenUserCollectTwoSetOfPointsAndPositivePnalty_ShouldReturnCorrectSumWithoutPenalty()
        {
            // arrange
            var user = new Employee();
            user.AddGrade(5);
            user.AddGrade(6);
            user.addPenalty(4);

            // act
            var result = user.GradesSum;

            // assert 
            Assert.AreEqual(11, result);
        }
    }
}
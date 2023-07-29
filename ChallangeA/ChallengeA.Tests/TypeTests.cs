

namespace ChallangeA.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenCreatedTwoEmployeesWithSameNamesButDiffrentObject_ShouldReturnTheyAreNotEqual()
        {
            //arrange
            var employee1 = GetEmployee("Witold", "Groch");
            var employee2 = GetEmployee("Witold", "Groch");
            //act

            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void WhenCreatedTwoStringsWithSameValue_ShouldReturnTheyAreEqual()
        {
            //arrange
            string string1 = "test2";
            string string2 = "test2";
            //act

            //assert
            Assert.AreEqual(string1, string2);
        }

        [Test]
        public void WhenCreatedTwoIntsWithSameValue_ShouldReturnTheyAreEqual()
        {
            //arrange
            int number1 = 5;
            var number2 = 5;
            //act

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenCreatedTwoFloatsWithSameValue_ShouldReturnTheyAreEqual()
        {
            //arrange
            var number1 = 1.5f;
            var number2 = 1.5f;
            //act

            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenComparingTheSameReferences_ShouldReturnTheyAreEqual()
        {
            //arrange
            var employee1 = GetEmployee("Witold", "Groch");
            var employee2 = employee1;
            //act

            //assert
            Assert.AreEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name, string surname, uint age = 0)
        {
            return new Employee(name, surname, age);
        }
    }
}
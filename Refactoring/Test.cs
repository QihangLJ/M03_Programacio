using Refactoring;

namespace TestProjectRefactoring
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MultiplyArray_AscentOrder()
        {
            //Arrange
            int[] numArray = { 1, 2, 3, 4, 5 };

            //Act
            int result = FirstRefactoringExercise.CalculateMultiply(numArray);

            //Assert
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        public void MultiplyArray_DescentOrder()
        {
            //Arrange
            int[] numArray = { 5, 4, 3, 2, 1 };

            //Act
            int result = FirstRefactoringExercise.CalculateMultiply(numArray);

            //Assert
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        public void MultiplyArray_SameValues()
        {
            //Arrange
            int[] numArray = { 5, 5, 100, 100};

            //Act
            int result = FirstRefactoringExercise.CalculateMultiply(numArray);

            //Assert
            Assert.AreEqual(250000, result);
        }

        [TestMethod]
        public void OutOfRange_False_InTheRange()
        {
            //Arrange
            int min = 1, max = 10, value = 5;

            //Act
            bool result = FirstRefactoringExercise.OutOfRange(value, min, max);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void OutOfRange_True_NotInTHeRange()
        {
            //Arrange
            int min = 1, max = 10, value = 15;

            //Act
            bool result = FirstRefactoringExercise.OutOfRange(value, min, max);

            //Assert
            Assert.IsTrue(result);
        }
    }
}

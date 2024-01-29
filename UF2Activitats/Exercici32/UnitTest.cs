using Exercici32_M03UF2;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NameWithOneVocal_ReturnOne()
        {
            //ARRANGE
            string inputName = "Jhon";
            int expectedOutput = 1;

            //ACT
            int output = Super4.ReadNumberOfVocals(inputName);

            //ASSERT
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void NameWithFiveVocal_ReturnFive()
        {
            //ARRANGE
            string inputName = "Aurelio";
            int expectedOutput = 5;

            //ACT
            int output = Super4.ReadNumberOfVocals(inputName);

            //ASSERT
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void MoreThanTwoVocals_ReturnTrue()
        {
            //ARRANGE
            string inputName = "Aurelio";

            //ACT
            bool output = Super4.CheckMinimumTwoVocals(inputName);

            //ASSERT
            Assert.IsTrue(output);
        }

        [TestMethod]
        public void LessThanTwoVocals_ReturnFalse()
        {
            //ARRANGE
            string inputName = "Jannnnnnnn";

            //ACT
            bool output = Super4.CheckMinimumTwoVocals(inputName);

            //ASSERT
            Assert.IsFalse(output);
        }

        [TestMethod]
        public void TwoVocals_ReturnTrue()
        {
            //ARRANGE
            string inputName = "Joan";

            //ACT
            bool output = Super4.CheckMinimumTwoVocals(inputName);

            //ASSERT
            Assert.IsTrue(output);
        }

        [TestMethod]
        public void InputValueInRange_ReturnTrue()
        {
            //ARRANGE
            int inputValue = 5, min = 1, max = 10;

            //ACT
            bool output = Super4.CheckValueInRange(inputValue, min, max);

            //ASSERT
            Assert.IsTrue(output);
        }

        [TestMethod]
        public void InputValueNotInRange_ReturnFalse()
        {
            //ARRANGE
            int inputValue = 15, min = 1, max = 10;

            //ACT
            bool output = Super4.CheckValueInRange(inputValue, min, max);

            //ASSERT
            Assert.IsFalse(output);
        }

        [TestMethod]
        public void Distribute_1000To4_ReturnInt()
        {
            //ARRANGE
            int distributeIn = 4;
            float total = 1000;
            float expectedOutput = 250;

            //ACT
            float output = Super4.DistributeWickedness(total, distributeIn);

            //ASSERT
            Assert.AreEqual(expectedOutput,output);
        }

        [TestMethod]
        public void DistributeOnly5Percentage_1000To4_ReturnInt()
        {
            //ARRANGE
            int distributeIn = 4;
            float total = 1000, percentage = 0.05f;
            float expectedOutput = 12.5f ;

            //ACT
            float output = Super4.DistributeWickedness(total, distributeIn, percentage);

            //ASSERT
            Assert.AreEqual(expectedOutput, output);
        }
    }
}

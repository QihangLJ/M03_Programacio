using Program;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void GasolineAmountIsGreaterThan0_PrintMessage_CarIsDriving()
        {
            //Arrange
            Car car = new Car(10);

            //Act
            string result;
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                car.Drive();

                result = sw.ToString();
            }
            string expectedResult = "Car is driving";

            //Assert
            Assert.AreEqual(expectedResult + Environment.NewLine, result);
        }

        [TestMethod]
        public void GasolineAmountIs0_PrintMessage_CarHasNotGasoline()
        {
            //Arrange
            Car car = new Car(0);

            //Act
            string result;
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                car.Drive();

                result = sw.ToString();
            }
            string expectedResult = "Car has not gasoline";

            //Assert
            Assert.AreEqual(expectedResult + Environment.NewLine, result);
        }

        [TestMethod]
        public void RefuelTheGasolineAmount_Return_True()
        {
            //Arrange
            Car car = new Car(0);

            //Act
            bool result = car.Refuel(10);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
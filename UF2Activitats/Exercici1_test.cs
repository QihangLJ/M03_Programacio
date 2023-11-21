using QihangProgram;

namespace ProjectTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void IsNaturalNum()
        {
            //Arrange:
            int num = 5;

            //Act:
            bool result = QihangCode.NaturalNumber(num);

            //Assert:
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNotNaturalNum()
        {
            //Arrange:
            int num = -5;
            
            //Act:
            bool result = QihangCode.NaturalNumber(num);
            
            //Assert:
            Assert.IsFalse(result);
        }
    }
}

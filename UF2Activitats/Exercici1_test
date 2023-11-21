using QihangProgram;

namespace ProjectTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void IsNaturalNum()
        {
            int num = 5;

            bool result = QihangCode.NaturalNumber(num);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNotNaturalNum()
        {
            int num = -5;

            bool result = QihangCode.NaturalNumber(num);

            Assert.IsFalse(result);
        }
    }
}

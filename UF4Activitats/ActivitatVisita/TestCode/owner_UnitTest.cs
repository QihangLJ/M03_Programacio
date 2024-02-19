using MyObject;

namespace TestProject
{
    [TestClass]
    public class owner_UnitTest
    {
        [TestMethod]
        public void OwnerHaveDNI_Return_False()
        {
            //Arrange
            owner firstOwner = new owner();
            firstOwner.SetDni(12345678);
            firstOwner.SetName("Pepito");
            firstOwner.SetSurname("Perez");
            firstOwner.SetPhone(666666666);

            //Act
            bool result = firstOwner.IsDNIaNIE();
            bool expectedResult = false;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void OwnerHaveNIE_Return_True()
        {
            //Arrange
            owner firstOwner = new owner();
            firstOwner.SetDni(1234567);
            firstOwner.SetName("Pepito");
            firstOwner.SetSurname("Perez");
            firstOwner.SetPhone(666666666);

            //Act
            bool result = firstOwner.IsDNIaNIE();
            bool expectedResult = true;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
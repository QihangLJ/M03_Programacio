using MyObject;

namespace TestProject
{
    [TestClass]
    public class patient_UnitTest
    {
        [TestMethod]
        public void PatientIsYounger_Return_False()
        {
            //Arrange
            patient firstPet = new patient();
            firstPet.SetName("Toby");
            firstPet.SetBreed("Golden Retriever");
            firstPet.SetEdat(5);
            firstPet.SetVaccinated(true);

            //Act
            bool result = firstPet.IsOlderThan(10);
            bool expectedResult = false;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PatientIsOlder_Return_False()
        {
            //Arrange
            patient firstPet = new patient();
            firstPet.SetName("Toby");
            firstPet.SetBreed("Golden Retriever");
            firstPet.SetEdat(15);
            firstPet.SetVaccinated(true);

            //Act
            bool result = firstPet.IsOlderThan(10);
            bool expectedResult = true;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PatientHaveSameYearsOld_Return_False()
        {
            //Arrange
            patient firstPet = new patient();
            firstPet.SetName("Toby");
            firstPet.SetBreed("Golden Retriever");
            firstPet.SetEdat(5);
            firstPet.SetVaccinated(true);

            //Act
            bool result = firstPet.IsOlderThan(5);
            bool expectedResult = false;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
namespace Tester
{
    [TestClass]
    public sealed class TogBilletTest
    {
        Collection.TogBillet togbillet = new();

        [TestMethod]
        public void TestBilletBaby()
        {
            //Arrange
            int age = 0;
            int expected = 0;

            //Act
            int actual = togbillet.BilletPris(age);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBilletBørn()
        {
            //Arrange
            int age = 14;
            int expected = 10;

            //Act
            int actual = togbillet.BilletPris(age);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBilletVoksen()
        {
            //Arrange
            int age = 34;
            int expected = 20;

            //Act
            int actual = togbillet.BilletPris(age);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBilletPensioneret()
        {
            //Arrange
            int age = 77;
            int expected = 5;

            //Act
            int actual = togbillet.BilletPris(age);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

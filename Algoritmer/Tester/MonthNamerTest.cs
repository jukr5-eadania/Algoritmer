namespace Tester;

[TestClass]
public class MonthNamerTest
{
    [TestMethod]
    public void LowestValueOutTest()
    {
        //Arrange
        Collection.MonthNamer monthNamer = new();
        string expected = "Number does not fit a month";
        int number = 0;

        //Act
        string actual = monthNamer.NameMonth(number);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void LowestValueTest()
    {
        //Arrange
        Collection.MonthNamer monthNamer = new();
        string expected = "January";
        int number = 1;

        //Act
        string actual = monthNamer.NameMonth(number);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void HighestValueTest()
    {
        //Arrange
        Collection.MonthNamer monthNamer = new();
        string expected = "December";
        int number = 12;

        //Act
        string actual = monthNamer.NameMonth(number);

        //Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void HighestValueOutTest()
    {
        //Arrange
        Collection.MonthNamer monthNamer = new();
        string expected = "Number does not fit a month";
        int number = 13;

        //Act
        string actual = monthNamer.NameMonth(number);

        //Assert
        Assert.AreEqual(expected, actual);
    }
}

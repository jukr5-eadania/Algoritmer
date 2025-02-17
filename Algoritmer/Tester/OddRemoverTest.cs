using TogBillet;

namespace Tester;

[TestClass]
public class OddRemoverTest
{
    [TestMethod]
    public void TestOddRemover()
    {
        //Arrange
        Collection.OddRemover oddremover = new();
        List<int> actual = new();
        List<int> expected = new() { 2, 4, 6, 8, 10 };

        List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //Act
        actual = oddremover.RemoveOddNumber(numbers);

        //Assert
        CollectionAssert.AreEqual(expected, actual);
    }
}

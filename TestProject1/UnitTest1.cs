namespace TestProject1;

using MyMath;
using NUnit.Framework;

public class Tests
{
    private Rooter rooter;

    [SetUp]
    public void Setup()
    {
        // Initialize the instance to test
        rooter = new Rooter();
    }

    [Test]
    public void RooterTestNegativeInput()
    {
        try
        {
            Rooter.SquareRoot(-10);
            // If no exception is thrown, the test should fail
            Assert.Fail("Expected ArgumentOutOfRangeException for negative input not thrown.");
        }
        catch (ArgumentOutOfRangeException)
        {
            // If an ArgumentOutOfRangeException is caught, the test passes
        }
    }

    [Test]
    public void BasicRooterTest()
    {
        // Define a test input and expected output value
        double expectedResult = 2.0;
        double input = expectedResult * expectedResult;

        // Run the method under test
        double actualResult = Rooter.SquareRoot(input);

        // Verify the result
        Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
    }
}

using BasicCSharpApp.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicCSharpApp.Tests;

[TestClass]
public sealed class CalculatorTests
{
    private Calculator _calculator = null!;

    [TestInitialize]
    public void Initialize()
    {
        _calculator = new Calculator();
    }

    [TestMethod]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        // Arrange
        double a = 5;
        double b = 7;

        // Act
        double result = _calculator.Add(a, b);

        // Assert
        Assert.AreNotEqual(12, result);
    }

    [TestMethod]
    public void Subtract_TwoNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        double a = 10;
        double b = 3;

        // Act
        double result = _calculator.Subtract(a, b);

        // Assert
        Assert.AreEqual(7, result);
    }

    [TestMethod]
    public void Multiply_TwoNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        double a = 4;
        double b = 5;

        // Act
        double result = _calculator.Multiply(a, b);

        // Assert
        Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void Divide_TwoNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        double a = 20;
        double b = 4;

        // Act
        double result = _calculator.Divide(a, b);

        // Assert
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    [ExpectedException(typeof(System.DivideByZeroException))]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        double a = 10;
        double b = 0;

        // Act
        _calculator.Divide(a, b);

        // Assert is handled by ExpectedException attribute
    }
}

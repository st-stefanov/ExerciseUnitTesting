using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool isValidEmail = Email.IsValidEmail(validEmail);

        // Assert
        Assert.IsTrue(isValidEmail);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string validEmail = "testexample.com";

        // Act
        bool isValidEmail = Email.IsValidEmail(validEmail);

        // Assert
        Assert.IsFalse(isValidEmail);
    }

    [Test]
    public void Test_IsValidEmail_WhiteSpaceEmail()
    {
        // Arrange
        string validEmail = "    ";

        // Act
        bool isValidEmail = Email.IsValidEmail(validEmail);

        // Assert
        Assert.IsFalse(isValidEmail);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string validEmail = null;

        // Act
        bool isValidEmail = Email.IsValidEmail(validEmail);

        // Assert
        Assert.IsFalse(isValidEmail);
    }
}

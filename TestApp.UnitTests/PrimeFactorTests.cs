using NuGet.Frameworks;
using NUnit.Compatibility;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        long n = 1;

        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(n), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        long n = 5;

        long result = PrimeFactor.FindLargestPrimeFactor(n);

        Assert.That(result, Is.EqualTo(n));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        long n = 123456789123456789;

        long result = PrimeFactor.FindLargestPrimeFactor(n);

        Assert.That(result, Is.EqualTo(52579));
    }
}

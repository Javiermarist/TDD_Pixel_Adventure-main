using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class NinjaFrogSpeedTests
{
    private NinjaFrogStats stats;

    [SetUp]
    public void SetUp()
    {
        stats = new NinjaFrogStats();
    }

    [Test]
    public void DefaultSpeed_ShouldBeOne()
    {
        Assert.AreEqual(1.0f, stats.speed, 0.01f, "The default speed should be 1.0 but was " + stats.speed);
    }

    [TestCase(true, 1.0f)]
    [TestCase(true, 0.6f)]
    [TestCase(false, 0.5f)]
    [TestCase(false, 0.0f)]
    [TestCase(false, -1.0f)]
    public void CanMove_Cases(bool expected, float speed)
    {
        bool actual = stats.CanMove(speed);
        Assert.AreEqual(expected, actual, "Expected: " + expected + ", but was: " + actual + " for speed: " + speed);
    }
}